using MagiZile.Acadiverse;
using MagiZile.UserInteractions.ParentalControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcadiverseDesktop
{
    public partial class FrmSendPM : Form
    {
        public Account currentAccount;
        public string recipient = "";

        public FrmSendPM()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (new WordFilter(WordFilter.FilteringLevel.Strict).ContainsBadWords(txtSubject.Text) || new WordFilter(WordFilter.FilteringLevel.Strict).ContainsBadWords(txtMessage.Text))
            {
                currentAccount.ChatStrikes++; //Increment the number of chat strikes on the current account by one.
                UserRole.LoadFromServer("moderators").RemoveFromRole(currentAccount.ID); //Make the user not a moderator anymore because they have broken the rules.
                currentAccount.SaveToServer();
                new Infraction(currentAccount.Username, InfractionType.Warning, "ACADIVERSE_SYSTEM", DateTime.Now, "attempted to send a PM with a swear word or a racial/cultural slur in it.").SaveToServer(); //A chat strike still counts as a warning despite not having the usual consequences (automatic bans that get increasingly longer the more warnings a user has).
                if (currentAccount.ChatStrikes < 3)
                {
                    Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_swear_word_entered.Replace("$1", (3 - currentAccount.ChatStrikes).ToString()));
                }
                else
                {
                    currentAccount.CanChat = false; //Ban the user from sending chat/PMs.
                    currentAccount.SaveToServer(); //Save the account information to the server.
                    new Infraction(currentAccount.Username, InfractionType.ChatBan, "ACADIVERSE_SYSTEM", DateTime.Now, "automatically banned from sending chat messages/PMs for repeated use of swear words or racial/cultural slurs.");
                    Close(); //Close the form because the user is no longer allowed to send any PMs.
                    Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_too_many_chat_strikes); //Show the "too many chat strikes" error message.
                }
                
            }
            else
            {
                Account.SendPM(currentAccount, Account.LoadFromServer(txtRecipient.Text), txtSubject.Text, txtMessage.Text);
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmSendPM_Load(object sender, EventArgs e)
        {
            txtRecipient.Text = recipient;
        }
    }
}
