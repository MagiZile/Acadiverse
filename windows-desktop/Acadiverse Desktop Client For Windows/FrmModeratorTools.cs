using MagiZile.Acadiverse;
using MagiZile.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcadiverseDesktop
{
    public partial class FrmModeratorTools : Form
    {
        readonly AccountWatcher objAccountWatcher = new AccountWatcher();
        private Account selectedAccount;
        public Account loggedInUser;
        bool userCheckedCheckboxes = true;

        public FrmModeratorTools()
        {
            InitializeComponent();
            objAccountWatcher.AccountCreated += new EventHandler<AccountEventArgs>(FrmModeratorTools_AccountCreated);
            objAccountWatcher.AccountDeleted += new EventHandler<AccountEventArgs>(FrmModeratorTools_AccountDeleted);
            objAccountWatcher.AccountInfoUpdated += new EventHandler<AccountEventArgs>(FrmModeratorTools_AccountInfoUpdated);
            foreach (Account account in Account.GetAccountList())
            {
            ListViewItem objItem = new ListViewItem
            {
                Text = account.ID.Value.ToString()
            };

            ListViewItem.ListViewSubItem objSubItem1 = new ListViewItem.ListViewSubItem
            {
                Text = account.Username
            };

            ListViewItem.ListViewSubItem objSubItem2 = new ListViewItem.ListViewSubItem
            {
                Text = account.ProfileBio
            };

            ListViewItem.ListViewSubItem objSubItem3 = new ListViewItem.ListViewSubItem
            {
                Text = account.ReputationPoints.ToString()
            };

            ListViewItem.ListViewSubItem objSubItem4 = new ListViewItem.ListViewSubItem
            {
                Text = account.Money.ToString()
            };

            ListViewItem.ListViewSubItem objSubItem5 = new ListViewItem.ListViewSubItem
            {
                Text = account.AccountBanned.ToString()
            };

            ListViewItem.ListViewSubItem objSubItem6 = new ListViewItem.ListViewSubItem
            {
                Text = account.BanReason
            };

            objItem.SubItems.Add(objSubItem1);
            objItem.SubItems.Add(objSubItem2);
            objItem.SubItems.Add(objSubItem3);
            objItem.SubItems.Add(objSubItem4);
            objItem.SubItems.Add(objSubItem5);
            objItem.SubItems.Add(objSubItem6);
            lvwUsers.Items.Add(objItem);
            }
        }

        private void FrmModeratorTools_AccountCreated(object Sender, AccountEventArgs e)
        {
            ListViewItem objItem = new ListViewItem
            {
                Text = e.Data.ID.Value.ToString()
            };

            ListViewItem.ListViewSubItem objSubItem1 = new ListViewItem.ListViewSubItem
            {
                Text = e.Data.Username
            };

            ListViewItem.ListViewSubItem objSubItem2 = new ListViewItem.ListViewSubItem
            {
                Text = e.Data.ProfileBio
            };

            ListViewItem.ListViewSubItem objSubItem3 = new ListViewItem.ListViewSubItem
            {
                Text = e.Data.ReputationPoints.ToString()
            };

            ListViewItem.ListViewSubItem objSubItem4 = new ListViewItem.ListViewSubItem
            {
                Text = e.Data.Money.ToString()
            };

            ListViewItem.ListViewSubItem objSubItem5 = new ListViewItem.ListViewSubItem
            {
                Text = e.Data.AccountBanned.ToString()
            };

            ListViewItem.ListViewSubItem objSubItem6 = new ListViewItem.ListViewSubItem
            {
                Text = e.Data.BanReason
            };

            objItem.SubItems.Add(objSubItem1);
            objItem.SubItems.Add(objSubItem2);
            objItem.SubItems.Add(objSubItem3);
            objItem.SubItems.Add(objSubItem4);
            objItem.SubItems.Add(objSubItem5);
            objItem.SubItems.Add(objSubItem6);
            lvwUsers.Items.Add(objItem);
        }

        private void FrmModeratorTools_AccountDeleted(object sender, AccountEventArgs e)
        {
            lvwUsers.Items.RemoveByKey(e.Data.ID.Value.ToString());
        }

        private void FrmModeratorTools_AccountInfoUpdated(object sender, AccountEventArgs e)
        {
            if (!UserRole.UserHasRole(loggedInUser, "moderators"))
            {
                Close();
                Globals.ShowErrorMessage("You no longer have access to Acadiverse Moderator Tools because you are no longer a moderator.");
            }
            else
            {
                ListViewItem objItem = lvwUsers.FindItemWithText(e.Data.ID.Value.ToString());
                objItem.Text = e.Data.ID.Value.ToString();
                objItem.Name = e.Data.ID.Value.ToString();
                objItem.SubItems[1].Text = e.Data.Username;
                objItem.SubItems[2].Text = e.Data.ProfileBio;
                objItem.SubItems[3].Text = e.Data.ReputationPoints.ToString();
                objItem.SubItems[4].Text = e.Data.Money.ToString();
                objItem.SubItems[5].Text = e.Data.AccountBanned.ToString();
                objItem.SubItems[6].Text = e.Data.BanReason;
                lvwUsers.Items.Remove(lvwUsers.Items.Find(e.Data.ID.Value.ToString(), false)[0]);
                lvwUsers.Items.Add(objItem);
            }
        }

        private void FrmModeratorTools_Load(object sender, EventArgs e)
        {
            tmrUpdateData.Start();
        }

        private void LvwUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            userCheckedCheckboxes = false;
            if (lvwUsers.SelectedIndices.Count > 0 && lvwUsers.SelectedIndices[0] != -1)
            {
                selectedAccount = Account.LoadFromServer(lvwUsers.SelectedItems[0].SubItems[1].Text);
                if (selectedAccount != null)
                {
                    lblDisplayName.Enabled = true;
                    txtDisplayName.Enabled = true;
                    lblProfileBio.Enabled = true;
                    txtProfileBio.Enabled = true;
                    grpActions.Enabled = true;
                    grpPrivileges.Enabled = true;
                    btnSaveChanges.Enabled = true;
                    lblUsername.Text = selectedAccount.Username + "(ID: " + selectedAccount.ID.Value.ToString() + ")";
                    txtProfileBio.Text = selectedAccount.ProfileBio;
                    chkCanPublish.Checked = selectedAccount.CanPublish;
                    chkCanChat.Checked = selectedAccount.CanChat;
                    if (!selectedAccount.AccountBanned)
                    {
                        btnBanAccount.Text = "Ban Account...";
                    }
                    else
                    {
                        btnBanAccount.Text = "Unban Account...";
                    }
                }
                else
                {
                    lblUsername.Text = "No account selected.";
                    lblDisplayName.Enabled = false;
                    txtDisplayName.Enabled = false;
                    lblProfileBio.Enabled = false;
                    txtProfileBio.Enabled = false;
                    grpActions.Enabled = false;
                    grpPrivileges.Enabled = false;
                    btnSaveChanges.Enabled = false;
                }
            }
            userCheckedCheckboxes = true;
        }

        private void BtnBanAccount_Click(object sender, EventArgs e)
        {
            if (!selectedAccount.AccountBanned)
            {
                if (selectedAccount.Equals(loggedInUser))
                {
                    Globals.ShowErrorMessage("You cannot ban yourself.");
                }
                else
                {
                    new FrmBanUser()
                    {
                        loggedInUser = this.loggedInUser,
                        selectedAccount = this.selectedAccount
                    }.ShowDialog();
                }
            }
            else
            {
                if (Globals.ShowConfirmationMessage("Are you sure you wish to unban " + selectedAccount.Username + "? This user will immediately be able to log into Acadiverse again.", true))
                {
                    selectedAccount.AccountBanned = false;
                    selectedAccount.SaveToServer();
                    btnBanAccount.Text = "Ban Account...";
                }
            }
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            selectedAccount.CanChat = chkCanChat.Checked;
            selectedAccount.CanPublish = chkCanPublish.Checked;
            selectedAccount.ProfileBio = txtProfileBio.Text;
            selectedAccount.SaveToServer();
        }

        private void ChkCanPublish_CheckedChanged(object sender, EventArgs e)
        {
            if (userCheckedCheckboxes)
            {
                if (!chkCanPublish.Checked)
                {
                    string reason = new PromptDialog().ShowPrompt("Acadiverse Moderation Tools", "Why are you banning this user from publishing?");
                    if (reason != "")
                    {
                        selectedAccount.CanPublish = false;
                        selectedAccount.SaveToServer();
                        new Infraction(selectedAccount.Username, InfractionType.PublishingBan, loggedInUser.Username, DateTime.Now, reason).SaveToServer();
                    }
                    else
                    {
                        userCheckedCheckboxes = false;
                        chkCanPublish.Checked = true;
                        userCheckedCheckboxes = true;
                    }
                }
                else
                {
                    if (Globals.ShowConfirmationMessage("Are you sure you wish to remove this usrr's publishing ban?", true))
                    {
                        selectedAccount.CanPublish = true;
                        selectedAccount.SaveToServer();
                    }
                }
            }
        }

        private void ChkCanChat_CheckedChanged(object sender, EventArgs e)
        {
            if (userCheckedCheckboxes)
            {
                if (!chkCanChat.Checked)
                {
                    string reason = new PromptDialog().ShowPrompt("Acadiverse Moderation Tools", "Why are you banning this user from chat?");
                    if (reason != "")
                    {
                        selectedAccount.CanChat = false;
                        selectedAccount.SaveToServer();
                        new Infraction(selectedAccount.Username, InfractionType.ChatBan, loggedInUser.Username, DateTime.Now, reason).SaveToServer();
                    }
                    else
                    {
                        userCheckedCheckboxes = false;
                        chkCanChat.Checked = true;
                        userCheckedCheckboxes = true;
                    }
                }
                else
                {
                    if (Globals.ShowConfirmationMessage("Are you sure you wish to remove this usrr's chat ban?", true))
                    {
                        selectedAccount.CanChat = true;
                        selectedAccount.SaveToServer();
                    }
                }
            }
        }

        private void BtnWarnUser_Click(object sender, EventArgs e)
        {
            string reason = new PromptDialog().ShowPrompt("Acadiverse Moderator Tools", "Why are you giving this user a warning?");
            if (reason != "")
            {
                Globals.WarnUser(loggedInUser, selectedAccount, reason);
            }
        }

        private void BtnSendPM_Click(object sender, EventArgs e)
        {
            new FrmSendPM
            {
                currentAccount = loggedInUser,
                recipient = selectedAccount.Username
            }.ShowDialog();
        }

        private void BtnViewInfractionHistory_Click(object sender, EventArgs e)
        {
            new frmInfractionHistory
            {
                selectedAccount = selectedAccount
            }.Show();
        }
    }
}