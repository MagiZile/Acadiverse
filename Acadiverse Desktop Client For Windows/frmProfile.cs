using MagiZile.Acadiverse;
using MagiZile.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcadiverseDesktop
{
    public partial class frmProfile : Form
    {
        
        public Account loggedInUser;
        public Account currentAccount;
        public string username;
        bool userCheckedCheckboxes = true;
        bool editingProfile = true;

        public frmProfile()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProfile_Load(object sender, EventArgs e)
        {
            if (Account.AccountExists(username))
            {
                currentAccount = Account.LoadFromServer(username);
                if (currentAccount.AccountBanned)
                {
                    pnlProfileErrorOverlay.Show();
                    lblProfileError.Text = "This account is banned.";
                    picProfileImage.Image = MagiZile.Acadiverse.Properties.Resources.img_profile_banned_user;
                }
                else
                {
                    pnlProfileErrorOverlay.Hide();
                    picProfileImage.Image = currentAccount.ProfileImage;
                    lblDisplayName.Text = currentAccount.DisplayName;
                    lblProfileBio.Text = currentAccount.ProfileBio;
                    lblBirthday.Text = currentAccount.Birthday.ToString();
                    lblAccountCreationDate.Text = currentAccount.AccountCreationDate.ToString();
                    lblLastLoginDate.Text = currentAccount.LastLoginDate.ToString();
                    pnlModeratorOptions.Visible = UserRole.UserHasRole(currentAccount, "moderators");
                }
            }
            else
            {
                    pnlProfileErrorOverlay.Show();
                    lblProfileError.Text = MagiZile.Acadiverse.Properties.Resources.str_incorrect_username;
            }
            if (editingProfile)
            {
                btnSaveChanges.Show();
                btnBlock.Hide();
                btnAddBuddy.Hide();
                btnSendPM.Hide();
                lblDisplayName.Hide();
                txtDisplayName.Show();
                txtProfileBio.BorderStyle = BorderStyle.FixedSingle;
                txtProfileBio.ReadOnly = false;
                pnlModeratorOptions.Hide();
            }
        }

        private void BtnBanAccount_Click(object sender, EventArgs e)
        {
            new FrmBanUser
            {
                selectedAccount = currentAccount,
                loggedInUser = loggedInUser
            }.ShowDialog();
        }

        private void ChkIsModerator_CheckedChanged(object sender, EventArgs e)
        {
            currentAccount.CanChat = chkCanChat.Checked;
            currentAccount.CanPublish = chkCanPublish.Checked;
            currentAccount.ProfileBio = txtProfileBio.Text;
            currentAccount.SaveToServer();
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
                        currentAccount.CanChat = false;
                        currentAccount.SaveToServer();
                        new Infraction(currentAccount.Username, InfractionType.ChatBan, loggedInUser.Username, DateTime.Now, reason).SaveToServer();
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
                        currentAccount.CanChat = true;
                        currentAccount.SaveToServer();
                    }
                }
            }
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
                        currentAccount.CanPublish = false;
                        currentAccount.SaveToServer();
                        new Infraction(currentAccount.Username, InfractionType.PublishingBan, loggedInUser.Username, DateTime.Now, reason).SaveToServer();
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
                        currentAccount.CanPublish = true;
                        currentAccount.SaveToServer();
                    }
                }
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            editingProfile = true;
            btnSaveChanges.Show();
            btnBlock.Hide();
            btnAddBuddy.Hide();
            btnSendPM.Hide();
            lblDisplayName.Hide();
            txtDisplayName.Show();
            txtProfileBio.BorderStyle = BorderStyle.FixedSingle;
            txtProfileBio.ReadOnly = false;
            pnlModeratorOptions.Hide();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            editingProfile = false;
            btnSaveChanges.Hide();
            txtProfileBio.BorderStyle = BorderStyle.None;
            txtProfileBio.ReadOnly = true;
            if (!loggedInUser.Equals(currentAccount))
            {
                btnAddBuddy.Show();
                btnSendPM.Show();
                btnBlock.Show();
            }
            currentAccount.ProfileBio = txtProfileBio.Text;
            currentAccount.DisplayName = txtDisplayName.Text;
            currentAccount.SaveToServer();
            lblDisplayName.Text = currentAccount.DisplayName;
            lblDisplayName.Show();
            txtDisplayName.Hide();
            if (UserRole.UserHasRole(loggedInUser, "moderators"))
            {
                pnlModeratorOptions.Show();
            }
        }
    }
}
