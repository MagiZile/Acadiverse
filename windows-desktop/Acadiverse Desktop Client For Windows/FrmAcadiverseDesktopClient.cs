using Acadiverse_Lesson_Studio;
using MagiZile.Acadiverse;
using MagiZile.Acadiverse.Properties;
using MagiZile.UserInteractions.ParentalControls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcadiverseDesktop
{
    public partial class FrmAcadiverseDesktopClient : Form
    {
        bool accountDeleted = false;
        bool passwordChanged = false;
        public Account currentAccount;
        public AccountWatcher objAccountWatcher;

        public FrmAcadiverseDesktopClient()
        {
            InitializeComponent();
            objAccountWatcher = new AccountWatcher();
            objAccountWatcher.AccountInfoUpdated += new EventHandler<AccountEventArgs>(FrmAcadiverseLauncher_AccountInfoUpdated);
            objAccountWatcher.AccountDeleted += new EventHandler<AccountEventArgs>(FrmAcadiverseLauncher_AccountDeleted);
        }

        void UpdateAccountInfo()
        {
            Account updatedAccountInfo = Account.LoadFromServer(currentAccount.ID);
            if (updatedAccountInfo.AccountBanned) //If the user is banned while the client is open...
            {
                currentAccount = updatedAccountInfo;
                if (currentAccount.DateBanExpires.Year == 1970) //If the ban is permanent (permanent bans have their end dates set to 1/1/1970)...
                {
                    Logout(true, Resources.str_account_permabanned);
                }
                else //Otherwise...
                {
                    Logout(true, Resources.str_account_tempbanned);
                }
            }

            if (File.Exists(".logoutuser"))
            {
                Thread.Sleep(5000);
                File.Delete(".logoutuser");
                Logout(true, "You have logged out from another Acadiverse program and have therefore been logged out of the client as well.");
            }
            
            else //Otherwise...
            {
                if (passwordChanged || accountDeleted) //If the user's password is changed or their account is deleted while the client is open...
                {
                    Logout(true, Resources.str_problem_with_credentials);
                }
                else //Otherwise...
                {
                    lblLoggedInUser.Text = currentAccount.Username;
                    lblAccountInfo.Text = currentAccount.AccountType.ToString() + " | " + currentAccount.ReputationPoints.ToString() + " Reputation Points | " + currentAccount.Money.ToString() + " Acadicoins";
                    if (!currentAccount.AcknowledgedLastWarning)
                    {
                        tmrServerUpdatesTimer.Stop();
                        if (new frmWarningReceived
                        {
                            currentAccount = currentAccount
                        }.ShowDialog() == DialogResult.OK)
                        {
                            tmrServerUpdatesTimer.Start();
                        }
                        else
                        {
                            Logout();
                        }
                    }
                }
            }
            if (!bgwChatUpdates.IsBusy)
            {
                bgwChatUpdates.RunWorkerAsync();
            }
            btnModeratorTools.Visible = UserRole.UserHasRole(currentAccount, "moderators");
            currentAccount = updatedAccountInfo;
        }

        void Logout()
        {
            Logout(false, ""); //The "logoutMessage" argument is empty because there is no need to show any message.
        }

        void Logout(bool automaticLogout, string logoutMessage)
        {
            tmrServerUpdatesTimer.Stop();
            if (automaticLogout)
            {
                Hide();
                Globals.ShowErrorMessage(logoutMessage);
            }
            Registry.SetValue(Globals.REGISTRY_PATH + @"\Acadiverse Desktop Client for Windows", "SaveLoginDetails", false);
            Registry.SetValue(Globals.REGISTRY_PATH + @"\Acadiverse Desktop Client for Windows", "CurrentUsername", "");
            Registry.SetValue(Globals.REGISTRY_PATH + @"\Acadiverse Desktop Client for Windows", "CurrentPassword", "");
            Application.Restart();
        }

        private void FrmAcadiverseLauncher_AccountInfoUpdated(object sender, AccountEventArgs e)
        {
            passwordChanged = (currentAccount.Password != e.Data.Password);
            if (e.Data.ID == currentAccount.ID)
            {   
                passwordChanged = (currentAccount.Password != e.Data.Password);
                currentAccount = e.Data;
            }
        }

        private void FrmAcadiverseLauncher_AccountDeleted(object sender, AccountEventArgs e)
        {
            if (e.Data.ID == currentAccount.ID)
            {
                accountDeleted = true;
            }
        }

        private void FrmAcadiverseLauncher_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                this.MinimumSize = this.Size;
                currentAccount = frmLogin.currentAccount;
                currentAccount.LastLoginDate = DateTime.Now;
                currentAccount.SaveToServer();
                lblLoggedInUser.Text = currentAccount.DisplayName + " (@" + currentAccount.Username + ")";
                if (currentAccount.ProfileImage != null)
                {
                    picProfileImage.Image = currentAccount.ProfileImage;
                }
                else
                {
                    picProfileImage.Image = Resources.img_profile_default;

                    //The following two lines are for saving the default image to a user's profile in case their profile image is null for some reason.
                    currentAccount.ProfileImage = Resources.img_profile_default;
                    currentAccount.SaveToServer();
                }
                lblAccountInfo.Text = currentAccount.AccountType.ToString() + " | " + currentAccount.ReputationPoints.ToString() + " Reputation Points | " + currentAccount.Money.ToString() + " Acadicoins";              
                try
                {
                    WebClient objCheckForUpdates = new WebClient();
                    objCheckForUpdates.DownloadFile("http://acadiverse.magizile.com/acadiversedesktop/changelog.txt", "changelog_TEMP.txt");
                    FileInfo currentChangeLog = new FileInfo("changelog.txt");
                    FileInfo newChangeLog = new FileInfo("changelog_TEMP.txt");
                    StreamReader objChangelog = new StreamReader("changelog.txt");
                    StreamReader objTempFile = new StreamReader("changelog_TEMP.txt");
                    string changeLogContents = objChangelog.ReadToEnd();
                    string tempFileContents = objTempFile.ReadToEnd();
                    objChangelog.Close();
                    objTempFile.Close();
                    objChangelog.Dispose();
                    objTempFile.Dispose();
                    if (changeLogContents != tempFileContents)
                    {
                        new frmUpdatesAvailable
                        {
                            changeLog = tempFileContents,
                            applicationName = "Acadiverse Desktop Client"
                        }.ShowDialog();
                    }
                    File.Delete("changelog_TEMP.txt");
                    tmrServerUpdatesTimer.Start();
                }
                catch (WebException)
                {
                    //Do nothing.
                }
                catch (FileNotFoundException)
                {
                    Globals.ShowErrorMessage("Could not check for updates. The changelog.txt file could not be found. The file will now be redownloaded.");
                    try
                    {
                        new WebClient().DownloadFile("http://acadiverse.magizile.com/acadiversedesktop/changelog.txt", "changelog.txt");
                    }
                    catch (WebException)
                    {
                        //Do nothing.
                    }
                }
                tmrServerUpdatesTimer.Start();
            }
            else
            {
                Close();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void BtnLaunchAcadiverseLessonStudio_Click(object sender, EventArgs e)
        {
            if (currentAccount.AccountType == AcadiverseAccountType.Teacher)
            {
                System.Diagnostics.Process.Start("Acadiverse Lesson Studio.exe ", Globals.CorrectPassword("lnc_234322854942374932423", "KmkZMDPtDzT2whOKbaTFWAkHBQbzixRIEJ7LPJQC3ls=") + " " + currentAccount.Username + " " + currentAccount.Password);
            }
            else
            {
                Globals.ShowErrorMessage(Resources.str_wrong_account_type.Replace("$", "Teacher"));
            }
        }

        private void BtnLaunchAcadiverse_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Acadiverse.exe", currentAccount.Username + " " + currentAccount.Password + Globals.CorrectPassword("lnc_234322854942374932423", "KmkZMDPtDzT2whOKbaTFWAkHBQbzixRIEJ7LPJQC3ls=") + "_" + Application.ProductVersion.GetHashCode());
            }
            catch (Win32Exception)
            {
                Globals.ShowErrorMessage("Acadiverse could not be launched. Please try reinstalling it.");
            }
        }

        private void FrmAcadiverseLauncher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogOUtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLogout.PerformClick();
        }

        private void OpenAcadiverseDesktopClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void BtnModeratorTools_Click(object sender, EventArgs e)
        {
            if (UserRole.UserHasRole(currentAccount, "moderators"))
            {
                new FrmModeratorTools
                {
                    loggedInUser = currentAccount
                }.Show();
            }
            else
            {
                //Do nothing as the button should not even be visible...
            }
        }

        private void TxtChat_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (new frmDeleteAccount
            {
                account = currentAccount
            }.ShowDialog() == DialogResult.OK)
            {
                tmrServerUpdatesTimer.Stop();
                currentAccount.DeleteAccount();
                Logout();
            }
        }

        private void TmrServerUpdatesTimer_Tick(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void BtnClearAllData_Click(object sender, EventArgs e)
        {
            if (Globals.ShowConfirmationMessage("Are you sure? This will delete all of your in-game progress, Acadicoins, and Reputation Points and can NOT be undone! Your profile picture will also be reset to the default, and your profile will be cleared! You will also lose all of your achievements and your account settings will be reset!", true))
            {
                tmrServerUpdatesTimer.Stop();
                currentAccount.DisplayName = currentAccount.Username;
                currentAccount.ProfileBio = "";
                currentAccount.ReputationPoints = 0;
                currentAccount.Money = 0;
                currentAccount.ReceivesPMs = true;
                currentAccount.NotifyAchievementReceived = true;
                currentAccount.NotifyMentioned = true;
                currentAccount.NotifyPMReceived = true;
                currentAccount.NotifySubmissionComment = true;
                currentAccount.NotifySubmissionFeatured = true;
                currentAccount.NotifySubmissionUpvote = true;
                currentAccount.PerfectQuizScoreAchievementCount = 0;
                currentAccount.TopPublisherAchievementCount = 0;
                currentAccount.SaveToServer();
                tmrServerUpdatesTimer.Start();
            }
        }

        private void BgwChatUpdates_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void BtnRefreshChats_Click(object sender, EventArgs e)
        {
            foreach (Chat chat in Chat.GetPublicChats())
            {
                flpChats.Controls.Clear();
                flpChats.Controls.Add(new ChatDisplay
                {
                    currentAccount = currentAccount,
                    currentChat = chat
                });
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            new frmProfile
            {
                currentAccount = currentAccount,
                loggedInUser = currentAccount
            }.ShowDialog();
            UpdateAccountInfo();
        }

        private void chkNotifyPMReceived_CheckedChanged(object sender, EventArgs e)
        {
            currentAccount.NotifyPMReceived = chkNotifyPMReceived.Checked;
            UpdateAccountInfo();
        }

        private void chkNotifySubmissionComment_CheckedChanged(object sender, EventArgs e)
        {
            currentAccount.NotifySubmissionComment = chkNotifySubmissionComment.Checked;
            UpdateAccountInfo();
        }

        private void chkNotifySubmissionUpvote_CheckedChanged(object sender, EventArgs e)
        {
            currentAccount.NotifySubmissionUpvote = chkNotifySubmissionUpvote.Checked;
            UpdateAccountInfo();
        }

        private void chkNotifySumbissionFeatured_CheckedChanged(object sender, EventArgs e)
        {
            currentAccount.NotifySubmissionFeatured = chkNotifySumbissionFeatured.Checked;
            UpdateAccountInfo();
        }

        private void chkNotifyAcheivementReceived_CheckedChanged(object sender, EventArgs e)
        {
            currentAccount.NotifyAchievementReceived = chkNotifyAcheivementReceived.Checked;
            UpdateAccountInfo();
        }

        private void chkNotifyMentioned_CheckedChanged(object sender, EventArgs e)
        {
            currentAccount.NotifyMentioned = chkNotifyMentioned.Checked;
            UpdateAccountInfo();
        }

        private void FrmAcadiverseDesktopClient_Activated(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
    }
}