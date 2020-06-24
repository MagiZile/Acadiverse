using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagiZile.Acadiverse;
using MagiZile.CustomUI;

namespace MagiZile.Acadiverse
{ 
    public partial class ChatMessageDisplay : UserControl
    {
        public ChatMessageDisplay()
        {
            InitializeComponent();
        }

        ChatMessage chatMessage;
        public Account loggedInUser; //This is used for reporting, replying, and determining whether or not to show the Delete button.

        public ChatMessage ChatMessage { get => chatMessage; set => chatMessage = value; }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (Globals.ShowConfirmationMessage(MagiZile.Acadiverse.Properties.Resources.str_delete_message_confirmation, false))
            {
                if (UserRole.UserHasRole(loggedInUser, "moderators"))
                {
                    if (new PromptDialog().ShowPrompt("Delete Chat Message", "Why are you removing this message?") == "")
                    {
                        new Infraction(ChatMessage.SenderUsername, InfractionType.ChatMessageDeletion, loggedInUser.Username, DateTime.Now, "chat message removed by moderator.").SaveToServer();
                    }
                    else
                    {
                        return;
                    }
                }
                ChatMessage.DeleteMessage(UserRole.UserHasRole(loggedInUser, "moderators"));
            }
        }

        private void BtnReport_Click(object sender, EventArgs e)
        {
            frmReport frmReport = new frmReport
            {
                associatedAccount = Account.LoadFromServer(ChatMessage.SenderUsername)
            };
            if (frmReport.ShowDialog() == DialogResult.OK)
            {
                Globals.Report(ChatMessage, loggedInUser, frmReport.reportReason);
            }
        }

        private void ChatMessageDisplay_Load(object sender, EventArgs e)
        {
            Account chatSender = Account.LoadFromServer(ChatMessage.SenderUsername);
            lblSender.Text = chatSender.DisplayName + "(@" + chatSender.Username + ")";
            lblDate.Text = DateTime.Now.Subtract(ChatMessage.DateSent).ToString() + " ago";
            lblDate.Visible = (ChatMessage.DateSent.Equals(new DateTime(0)));
            rtbMessageContents.Text = ChatMessage.MessageContents;
            if (loggedInUser.Username == chatSender.Username || UserRole.UserHasRole(loggedInUser, "moderators"))
            {
                btnDelete.Show();
            }
            else
            {
                btnDelete.Hide();
            }
        }
    }
}