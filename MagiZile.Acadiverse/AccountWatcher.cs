using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.Acadiverse
{
    public partial class AccountWatcher
    {
        Account accountData;
        readonly List<MongoDB.Bson.BsonObjectId> ids = new List<MongoDB.Bson.BsonObjectId>();
        readonly List<string> usernames = new List<string>();
        readonly System.Windows.Forms.Timer tmrAccountTimer;
        readonly BackgroundWorker bgwAccountListUpdater;
        List<Account> accountList = new List<Account>();
        List<Account> newAccountList = new List<Account>();

        public event EventHandler<AccountEventArgs> AccountCreated;
        public event EventHandler<AccountEventArgs> AccountDeleted;
        public event EventHandler<AccountEventArgs> AccountInfoUpdated;

        public AccountWatcher()
        {
            tmrAccountTimer = new System.Windows.Forms.Timer();
            bgwAccountListUpdater = new BackgroundWorker();

            tmrAccountTimer.Tick += new EventHandler(TmrAccountTimer_Tick);
            bgwAccountListUpdater.DoWork += new DoWorkEventHandler(BgwAccountListUpdater_DoWork);
            bgwAccountListUpdater.ProgressChanged += new ProgressChangedEventHandler(BgwAccountUpdater_ProgressChanged);

            bgwAccountListUpdater.WorkerReportsProgress = true;
            tmrAccountTimer.Start();
        }

        private void TmrAccountTimer_Tick(object sender, EventArgs e)
        {
            if (!bgwAccountListUpdater.IsBusy)
            {
                bgwAccountListUpdater.RunWorkerAsync();
            }
        }

        private void BgwAccountUpdater_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.UserState.ToString())
            {
                case "ACCOUNT_CREATED":
                    AccountCreated?.Invoke(this, new AccountEventArgs(accountData));
                    break;
                case "ACCOUNT_DELETED":
                    AccountDeleted?.Invoke(this, new AccountEventArgs(accountData));
                    break;
                case "ACCOUNT_INFO_UPDATED":
                    AccountInfoUpdated?.Invoke(this, new AccountEventArgs(accountData));
                    break;
                default:
                    throw (new ArgumentException());

            }
        }

        private void BgwAccountListUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            accountList = Account.GetAccountList();
            Thread.Sleep(100);
            newAccountList = Account.GetAccountList();
            System.Diagnostics.Debug.WriteLine("Account list retrieved successfully.");
            usernames.Clear();
            for (int i = 0; i < accountList.Count; i++)
            {
                Account account = accountList[i];
                if (!accountList.Contains(account))
                {
                    accountList.Add(account);
                    accountData = account;
                    bgwAccountListUpdater.ReportProgress(0, "ACCOUNT_CREATED");
                }
            }
            for (int i = 0; i < accountList.Count; i++)
            {
                Account account = accountList[i];
                if (!newAccountList.Contains(account))
                {
                    accountList.Remove(account);
                    accountData = account;
                    bgwAccountListUpdater.ReportProgress(0, "ACCOUNT_DELETED");
                    i--;
                }
                usernames.Add(account.Username);
            }
            for (int i = 0; i < accountList.Count; i++)
            {
                Account account = accountList[i];
                if (account.ID.Value.ToString() == newAccountList[i].ID.Value.ToString())
                {
                    if (!newAccountList[i].Equals(account))
                    {
                        accountData = account;
                        bgwAccountListUpdater.ReportProgress(0, "ACCOUNT_INFO_UPDATED");
                    }
                }
            }
        }
    }
}
