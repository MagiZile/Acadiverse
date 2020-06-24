using MagiZile.Acadiverse;
using MagiZile.CustomUI;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acadiverse_Admin_Panel
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        Account selectedAccount;
        public Account currentAccount;
        Chat selectedChat;
        UserRole selectedUserRole;

        void RefreshAccountsList()
        {
            lstAccounts.Items.Clear();
            foreach (Account account in Account.GetAccountList())
            {
                lstAccounts.Items.Add(account.Username);
            }
        }

        void RefreshChatsList()
        {
            lstChats.Items.Clear();
            foreach (Chat chat in Chat.GetAllChats())
            {
                lstChats.Items.Add(chat.ChatID);
            }
        }

        void RefreshUserRolesList()
        {
            lstUserRoles.Items.Clear();
            foreach (UserRole userRole in UserRole.GetAllUserRoles())
            {
                lstUserRoles.Items.Add(userRole.RoleName);
            }
        }

        private void BtnRefreshList_Click(object sender, EventArgs e)
        {
            RefreshAccountsList();
        }

        private void PrgSelectedAccountProperties_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            selectedAccount.SaveToServer();
        }

        private void LstAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAccounts.SelectedIndex > -1)
            {
                selectedAccount = Account.LoadFromServer(lstAccounts.Items[lstAccounts.SelectedIndex].ToString());
                prgSelectedAccountProperties.SelectedObject = selectedAccount;
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            RefreshAccountsList();
            RefreshChatsList();
            RefreshUserRolesList();
        }

        private void LstChats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstChats.SelectedIndex > -1)
            {
                selectedChat = Chat.LoadFromServer(lstChats.Items[lstChats.SelectedIndex].ToString());
                prgSelectedAccountProperties.SelectedObject = selectedChat;
            }
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            if (Globals.ShowConfirmationMessage("Admins should ONLY create a new account if a user has requested an account for a child under 13 (i.e. gave the child permission to sign up)! Are you sure you wish to create a new Acadiverse account?", true))
            {
                string username = new PromptDialog().ShowPrompt("Acadiverse Admin Panel", "What should the username of the new account be (a password will be automatically generated.");
                string password = new Random().Next(100000, 999999).ToString();
                if (username != "")
                {
                    string email = new PromptDialog().ShowPrompt("Acadiverse Admin Panel", "What is this user's email (it should be included in the message sent asking for a new account to be created.");
                    if (email != "")
                    {
                        new Account
                        {
                            Username = username,
                            Password = password,
                            Email = email
                        }.SaveToServer();
                        Account.SendEmail("Welcome to Acadiverse!", "A new account at Acadiverse has been created for you. Your temporary password is: " + password, Account.LoadFromServer(username));
                        RefreshAccountsList();
                    }
                }
            }
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (Globals.ShowConfirmationMessage("Are you sure? Accounts should ONLY be deleted by an admin if they were used for severe Terms of Service violations/serious violations of the law!", true))
            {
                selectedAccount.DeleteAccount();
                RefreshAccountsList();
            }
        }

        private void BtnCreateChat_Click(object sender, EventArgs e)
        {
            string chatName = new PromptDialog().ShowPrompt("Acadiverse Admin Panel", "What should the name of the new chat be?");
            if (chatName != "")
            {
                new Chat
                {
                    Name = chatName,
                    Description = "Feel free to change this description  as well as the \"IsPrivate\" property value!",
                    IsPrivate = false,
                    OwnerID = currentAccount.ID 
                }.SaveToServer();
                RefreshChatsList();
            }
        }

        private void BtnDeleteChat_Click(object sender, EventArgs e)
        {
            if (Globals.ShowConfirmationMessage("Are you sure you wish to delete the selected chat? This can NOT be undone, and admins should only delete chats that violate the Terms of Service or Code of Conduct!", true))
            {
                selectedChat.DeleteChat();
            }
            RefreshChatsList();
        }

        private void BtnAddUserRole_Click(object sender, EventArgs e)
        {
            string roleName = new PromptDialog().ShowPrompt("Acadiverse Admin Panel", "What should the new role be called (WARNING: This can NOT be changed once set as changing the name may break something!)?");
            if (roleName != "")
            {
                if (Globals.ShowConfirmationMessage("Are you sure you wish to add a role with the name \"" + roleName + "\"? Please note that roles should ONLY be added if the developers need it!", true))
                {
                    new UserRole
                    {
                        RoleName = roleName,
                        AssociatedUsers = new MongoDB.Bson.BsonArray()
                    }.SaveToServer();
                }
                RefreshUserRolesList();
            }
        }

        private void LstUserRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUserRoles.SelectedIndex > -1)
            {
                lstAssociatedUsers.Items.Clear();
                selectedUserRole = UserRole.LoadFromServer(lstUserRoles.Items[lstUserRoles.SelectedIndex].ToString());
                foreach (BsonObjectId id in selectedUserRole.AssociatedUsers)
                {
                    lstAssociatedUsers.Items.Add(Account.LoadFromServer(id).Username);
                }
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            string username = new PromptDialog().ShowPrompt("Acadiverse Admin Panel", "Which username are you adding?");
            if (Globals.ShowConfirmationMessage("Are you sure you wish to add the user \"" + username + "\" to the \"" + selectedUserRole.RoleName + "\" user role? This will give them some privileges exclusive to that role and also make some asthetic changes to their profile!", true))
            {
                if (Account.AccountExists(username))
                {
                    if (!selectedUserRole.AssociatedUsers.Contains(Account.LoadFromServer(username).ID))
                    {
                        selectedUserRole.AssociatedUsers.Add(Account.LoadFromServer(username).ID);
                        selectedUserRole.SaveToServer();
                        foreach (BsonObjectId id in selectedUserRole.AssociatedUsers)
                        {
                            lstAssociatedUsers.Items.Add(Account.LoadFromServer(id).Username);
                        }
                    }
                    else
                    {
                        Globals.ShowErrorMessage("This user is already in the selected user role.");
                    }
                }
                else
                {
                    Globals.ShowErrorMessage("This user does not exist.");
                }
            }
        }
    }
}