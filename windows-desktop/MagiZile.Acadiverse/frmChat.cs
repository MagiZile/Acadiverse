using MagiZile.UserInteractions.ParentalControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.Acadiverse
{
    public partial class FrmChat : Form
    {
        public FrmChat()
        {
            InitializeComponent();
        }

        public Account currentAccount;
        public Chat currentChat;

        private void TxtChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                WordFilter objWordFilter = new WordFilter(WordFilter.FilteringLevel.Strict);
                if (!objWordFilter.ContainsBadWords(txtChat.Text))
                {
                    if (currentAccount.CanChat)
                    {
                        ChatMessage chatMessage = new ChatMessage
                        {
                            SenderUsername = currentAccount.Username,
                            MessageContents = txtChat.Text,
                            ChatID = currentChat.ChatID,
                            DateSent = DateTime.Now
                        };
                        chatMessage.SaveToServer();
                        flpChat.Controls.Add(new ChatMessageDisplay
                        {
                            ChatMessage = chatMessage,
                            loggedInUser = currentAccount
                        });
                        txtChat.Clear();
                    }
                    else
                    {
                        Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_banned_from_chat);
                    }
                }
                else
                {
                    currentAccount.ChatStrikes++; //Increment the number of chat strikes on the current account by one.
                    UserRole.LoadFromServer("moderators").RemoveFromRole(currentAccount.ID); //Make the user not a moderator anymore because they have broken the rules.
                    
                    currentAccount.SaveToServer();
                    new Infraction(currentAccount.Username, InfractionType.Warning, "ACADIVERSE_SYSTEM", DateTime.Now, "attempted to send a chat message with a swear word or a racial/cultural slur in it.").SaveToServer(); //A chat strike still counts as a warning despite not having the usual consequences (automatic bans that get increasingly longer the more warnings a user has).
                    if (currentAccount.ChatStrikes < 3)
                    {
                        if (objWordFilter.FilteredWordIsSlur())
                        {
                            Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_slur_entered.Replace("$1", (3 - currentAccount.ChatStrikes).ToString()));
                        }
                        else
                        {
                            Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_swear_word_entered.Replace("$1", (3 - currentAccount.ChatStrikes).ToString()));
                        }
                    }
                    else
                    {
                        currentAccount.CanChat = false; //Ban the user from sending chat/PMs.
                        currentAccount.SaveToServer(); //Save the account information to the server.
                        new Infraction(currentAccount.Username, InfractionType.ChatBan, "ACADIVERSE_SYSTEM", DateTime.Now, "automatically banned from sending chat messages/PMs for repeated use of swear words or racial/cultural slurs.");
                        Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_too_many_chat_strikes); //Show the "too many chat strikes" error message.
                    }
                }
            }
        }
    }
}
