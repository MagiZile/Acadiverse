using MagiZile.Acadiverse;
using MagiZile.Acadiverse.Properties;
using MagiZile.UserInteractions.ParentalControls;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Acadiverse_Desktop_Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            stkLogin.Visibility = Visibility.Visible;
            tabChats.Visibility = Visibility.Hidden;
            tabSubmissions.Visibility = Visibility.Hidden;
            tabAcadiverseStore.Visibility = Visibility.Hidden;
            grdTop.Visibility = Visibility.Hidden;
            grdMain.Visibility = Visibility.Hidden;
            grdBottom.Visibility = Visibility.Hidden;
            rctOverlayBackground.Visibility = Visibility.Hidden;
            grdOverlay.Visibility = Visibility.Hidden;
            dataUpdateThread = new Thread(new ThreadStart(DataUpdateThread));
        }

        Thread dataUpdateThread;

        private async void OverlayAwait()
        {
            await btnOverlayButton2;
            if (overlayValue == 0)
            {
                return;
            }
            await btnOverlayButton1;
        }

        int overlayValue = -1;

        int ShowOverlay(string header, string text, string button1Text, string button2Text)
        {
            rctOverlayBackground.Visibility = Visibility.Visible;
            grdOverlay.Visibility = Visibility.Visible;
            lblOverlayHeader.Content = header;
            lblOverlayText.Text = text;
            btnOverlayButton1.Content = button1Text;
            btnOverlayButton2.Content = button2Text;
            if (button2Text == "")
            {
                btnOverlayButton2.Visibility = Visibility.Hidden;
            }
            else
            {
                btnOverlayButton2.Visibility = Visibility.Visible;
            }
            OverlayAwait();
            int v = overlayValue;
            overlayValue = -1;
            return v;
        }

        public void RefreshChats()
        {

        }

        public void RefreshSubmissions()
        {

        }

        public void RefreshStore()
        {

        }

        public void RefreshNotifications()
        {

        }

        public void RefreshPMs()
        {

        }

        public void InitDataUpdateThread()
        {
            if (!(dataUpdateThread.ThreadState == System.Threading.ThreadState.Aborted) && !(dataUpdateThread.ThreadState == System.Threading.ThreadState.Running))
            {
                dataUpdateThread.Start();
            }
            else
            {
                dataUpdateThread = new Thread(new ThreadStart(DataUpdateThread));
            }
        }

        public void StopDataUpdateThread()
        {
            dataUpdateThread.Abort();
        }

        public void DataUpdateThread()
        {
            while (true)
            {
                currentAccount = Account.LoadFromServer(currentAccount.ID);
                Dispatcher.Invoke(new Action(UpdateData));
                Thread.Sleep(5000);
            }
        }

        void UpdateData()
        {
            try
            {
                lblUsername.Content = currentAccount.DisplayName + " (@" + currentAccount.Username + ")";
                lblReputationPoints.Content = currentAccount.ReputationPoints.ToString() + " Reputation Points";
                lblMoney.Content = currentAccount.Money + " Acadicions";
                if (lvwUsers.Visibility == Visibility.Visible)
                {
                    List<Account> accountsList = Account.GetAccountList();
                    foreach (Account account in accountsList)
                    {
                        
                    }
                }
                if (currentAccount.AccountBanned)
                {
                    StopDataUpdateThread();
                    string banMessage = "";
                    if (currentAccount.DateBanExpires.Year == 1970)
                    {
                        banMessage = MagiZile.Acadiverse.Properties.Resources.str_account_permabanned.Replace("$1", currentAccount.BanReason);
                    }
                    else
                    {
                        banMessage = MagiZile.Acadiverse.Properties.Resources.str_account_tempbanned.Replace("$1", currentAccount.DateBanExpires.ToLongDateString()).Replace("$2", currentAccount.BanReason);
                    }
                    ShowOverlay("Account Banned", banMessage, "OK", "");
                    Logout();
                    return;
                }
                if (currentAccount.AcknowledgedLastWarning == false)
                {
                    StopDataUpdateThread();
                    string warningMessage = "Moderator Name:" + currentAccount.LastWarnedByModeratorName
                        + "\nDate Recieved: " + currentAccount.DateLastWarningReceived.ToLongDateString()
                        + "\nWarning Reason: " + currentAccount.LastWarningReason
                        + "\n\nThis is your " + Globals.NumberWithOrdinalSuffix(currentAccount.Warnings) + " warning. Please be aware that more severe consequences will be given out if you continue to break the rules."
                        + "\n\nBy clicking \"Acknowledge Warning\" below, you agree that you have read the Terms of Service and Code of Conduct.";
                    ShowOverlay("You have recieved a warning!", warningMessage, "Acknowledge Warning", "");
                    InitDataUpdateThread();
                }
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (DnsClient.DnsResponseException)
            {
                StopDataUpdateThread();
                ShowOverlay("Connection Error", MagiZile.Acadiverse.Properties.Resources.str_connection_error, "OK", "");
                InitDataUpdateThread();
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (ArgumentOutOfRangeException)
            {
                StopDataUpdateThread();
                ShowOverlay("Connection Error", MagiZile.Acadiverse.Properties.Resources.str_connection_error, "OK", "");
                InitDataUpdateThread();
            }
#pragma warning restore CA1031 // Do not catch general exception types
            catch (TimeoutException)
            {
                StopDataUpdateThread();
                ShowOverlay("Connection Error", "The connection timed out. Please check your firewall settings to see if Acadiverse Desktop Client for Windows is blocked. Don't worry; all Acadiverse programs are safe!", "OK", "");
                InitDataUpdateThread();
            }
        }

        void Logout()
        {
            if (dataUpdateThread.IsAlive)
            {
                StopDataUpdateThread();
            }
            currentAccount = null;
            txtRegisterDisplayName.Text = "";
            txtRegisterEmail.Text = "";
            txtRegisterUsername.Text = "";
            txtUsername.Text = "";
            pwdConfirmPassword.Password = "";
            pwdPassword.Password = "";
            pwdRegisterPassword.Password = "";
            chkAgreeToPolicies.IsChecked = false;
            radParent.IsChecked = false;
            radStudent.IsChecked = false;
            radTeacher.IsChecked = false;
            grdTop.Visibility = Visibility.Hidden;
            grdMain.Visibility = Visibility.Hidden;
            grdBottom.Visibility = Visibility.Hidden;
            stkLogin.Visibility = Visibility.Visible;
        }

        int PasswordStrength()
        {
            int value = 0;
            if (pwdRegisterPassword.Password.Length >= 8)
            {
                int numberOfCapitalLetters = 0;
                int numberOfLowercaseLetters = 0;
                int numberOfDigits = 0;
                int numberOfSymbols = 0;
                foreach (char c in pwdRegisterPassword.Password)
                {
                    if (Char.IsLetter(c))
                    {
                        if (Char.IsLower(c))
                        {
                            numberOfLowercaseLetters++;
                        }
                        else
                        {
                            numberOfCapitalLetters++;
                        }
                    }
                    if (Char.IsDigit(c))
                    {
                        numberOfDigits++;
                    }
                    if (Char.IsSymbol(c))
                    {
                        numberOfSymbols++;
                    }
                }
                if (numberOfDigits == 0 || numberOfCapitalLetters == 0 || numberOfLowercaseLetters == 0 || numberOfSymbols == 0)
                {
                    value = -1;
                }
                else
                {

                }
            }
            else
            {
                value = 0;
            }
            return value;
        }

        void ShowErrorText(TextBlock textBlock, string message)
        {
            textBlock.Visibility = Visibility.Visible;
            textBlock.Text = message;
        }
        Account currentAccount;
        WordFilter wordFilter = new WordFilter(WordFilter.FilteringLevel.Strict, true);

        void Login(bool newAccount)
        {
            Account objAccount = null;
            try
            {             
                if (newAccount)
                {
                    objAccount = Account.LoadFromServer(currentAccount.Username);
                    goto FinishLogin;
                }
                else
                {
                    if (txtUsername.Text != "")
                    {
                        if (Account.AccountExists(txtUsername.Text))
                        {
                            objAccount = Account.LoadFromServer(txtUsername.Text);
                        }
                        else
                        {
                            ShowErrorText(lblLoginError, MagiZile.Acadiverse.Properties.Resources.str_incorrect_username);
                            return;
                        }
                        if (pwdPassword.Password == "")
                        {
                            ShowErrorText(lblLoginError, MagiZile.Acadiverse.Properties.Resources.str_blank_password);
                            return;
                        }
                        else
                        {
                            if (Globals.CorrectPassword(pwdPassword.Password, objAccount.Password) == false)
                            {
                                ShowErrorText(lblLoginError, MagiZile.Acadiverse.Properties.Resources.str_incorrect_password);
                                return;
                            }
                            else
                            {
                                if (objAccount.AccountBanned)
                                {
                                    if (objAccount.DateBanExpires.Year == 1970)
                                    {
                                        ShowErrorText(lblLoginError, MagiZile.Acadiverse.Properties.Resources.str_account_permabanned.Replace("$1", objAccount.BanReason));
                                        return;
                                    }
                                    else
                                    {
                                        ShowErrorText(lblLoginError, MagiZile.Acadiverse.Properties.Resources.str_account_tempbanned.Replace("$1", objAccount.DateBanExpires.ToLongDateString()).Replace("$2", objAccount.BanReason));
                                        return;
                                    }
                                }
                                else
                                {
                                    goto FinishLogin;
                                }
                            }
                        }
                    }
                    else
                    {
                        ShowErrorText(lblLoginError, MagiZile.Acadiverse.Properties.Resources.str_blank_username);
                        return;
                    }
                }
            }
            catch (DnsClient.DnsResponseException)
            {
                StopDataUpdateThread();
                ShowOverlay("Connection Error", MagiZile.Acadiverse.Properties.Resources.str_connection_error, "OK", "");
                InitDataUpdateThread();
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (ArgumentOutOfRangeException)
            {
                ShowOverlay("Connection Error", MagiZile.Acadiverse.Properties.Resources.str_connection_error, "OK", "");
                return;
            }
#pragma warning restore CA1031 // Do not catch general exception types
            catch (TimeoutException)
            {
                ShowOverlay("Connection Error", "The connection timed out. Please check your firewall settings to see if Acadiverse Desktop Client for Windows is blocked. Don't worry; all Acadiverse programs are safe!", "OK", "");
                return;
            }
        FinishLogin:
            currentAccount = objAccount;
            stkLogin.Visibility = Visibility.Collapsed;
            tabChats.Visibility = Visibility.Visible;
            tabSubmissions.Visibility = Visibility.Visible;
            tabAcadiverseStore.Visibility = Visibility.Visible;
            grdTop.Visibility = Visibility.Visible;
            grdMain.Visibility = Visibility.Visible;
            grdBottom.Visibility = Visibility.Visible;
            lblUsername.Content = currentAccount.DisplayName + " (@" + currentAccount.Username + ")";
            lblReputationPoints.Content = currentAccount.ReputationPoints.ToString() + " Reputation Points";
            lblMoney.Content = currentAccount.Money + " Acadicions";
            if (currentAccount.ProfileImage == null)
            {
                picProfileImage.Source = new BitmapImage(new Uri("http://acadiverse.magizile.com/images/img_profile_default.bmp"));
            }
            else
            {
                currentAccount.ProfileImage.Save("profile.bmp");
                picProfileImage.Source = new BitmapImage(new Uri("profile.bmp"));
                File.Delete("profile.bmp");
            }
            currentAccount.LastLoginDate = DateTime.Now;
            currentAccount.SaveToServer();
            InitDataUpdateThread();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login(false);
        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            if (Account.AccountExists(txtRegisterUsername.Text))
            {
                ShowErrorText(lblRegistrationError, "This username is unavailable.");
                return;
            }
            else
            {
                bool disallowedUsername = wordFilter.ContainsBadWords(txtRegisterUsername.Text, false);
                if (disallowedUsername)
                {
                    ShowErrorText(lblRegistrationError, "The username you have chosen is not allowed on Acadiverse because it contains swear words or racial slurs.");
                    return;
                }
                else
                {
                    if (pwdRegisterPassword.Password == pwdConfirmPassword.Password)
                    {
                        if (PasswordStrength() == -1)
                        {
                            MessageBox.Show("Your password does not meet the requirements.");
                            return;
                        }
                        else
                        {
                            if (dtpBirthday.SelectedDate == null)
                            {
                                ShowErrorText(lblRegistrationError, "Please enter a valid birthday.");
                                return;
                            }
                            else
                            {
                                if (txtRegisterEmail.Text == "")
                                {
                                    ShowErrorText(lblRegistrationError, "The email must not be blank.");
                                    return;
                                }
                                else
                                {
                                    if (!radParent.IsChecked.Value == true && !radStudent.IsChecked.Value == true && !radTeacher.IsChecked.Value == true)
                                    {
                                        ShowErrorText(lblRegistrationError, "Please select an account type.");
                                        return;
                                    }
                                    else
                                    {
                                        if (!chkAgreeToPolicies.IsChecked.Value == true)
                                        {
                                            ShowErrorText(lblRegistrationError, "You must agree to the Terms of Secrive, Code of Conduct, and Privacy Policy.");
                                            return;
                                        }
                                        else
                                        {
                                            Account account = new Account
                                            {
                                                Username = txtRegisterUsername.Text,
                                                Password = Globals.SaltedPassword(pwdRegisterPassword.Password)
                                            };
                                            if (radParent.IsChecked.Value == true)
                                            {
                                                account.AccountType = AcadiverseAccountType.Parent;
                                            }
                                            else if (radStudent.IsChecked.Value == true)
                                            {
                                                account.AccountType = AcadiverseAccountType.Student;
                                            }
                                            else if (radTeacher.IsChecked.Value == true)
                                            {
                                                account.AccountType = AcadiverseAccountType.Teacher;
                                            }
                                            else
                                            {
                                                throw (new InvalidOperationException());
                                            }
                                            account.AccountBanned = false;
                                            account.DateBanExpires = new DateTime(1970, 1, 1);
                                            account.BanReason = "";
                                            account.CanPublish = true;
                                            account.CanChat = true;
                                            account.Birthday = dtpBirthday.SelectedDate.Value;
                                            account.ProfileBio = "";
                                            account.ReputationPoints = 0;
                                            account.Money = 0;
                                            account.LastLoginDate = DateTime.Now;
                                            account.AccountCreationDate = DateTime.Now;
                                            account.Buddies = new BsonArray();
                                            account.PrivateMessages = new BsonArray();
                                            account.Email = txtRegisterEmail.Text;
                                            account.SaveToServer();
                                            currentAccount = account;
                                            stkRegister.Visibility = Visibility.Hidden;
                                            Login(true);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        ShowErrorText(lblRegistrationError, "The passwords do not match.");
                        return;
                    }
                }
            }
        }

        private void btnShowLoginForm_Click(object sender, RoutedEventArgs e)
        {
            stkRegister.Visibility = Visibility.Hidden;
            stkLogin.Visibility = Visibility.Visible;
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            stkLogin.Visibility = Visibility.Hidden;
            stkRegister.Visibility = Visibility.Visible;
        }

        private void btnOverlayButton1_Click(object sender, RoutedEventArgs e)
        {
            overlayValue = 1;
            rctOverlayBackground.Visibility = Visibility.Hidden;
            grdOverlay.Visibility = Visibility.Hidden;
        }

        private void btnOverlayButton2_Click(object sender, RoutedEventArgs e)
        {
            overlayValue = 0;
            rctOverlayBackground.Visibility = Visibility.Hidden;
            grdOverlay.Visibility = Visibility.Hidden;

        }

        private void btnClosePrivateMessagesOverlay_Click(object sender, RoutedEventArgs e)
        {
            grdPMs.Visibility = Visibility.Hidden;
            rctOverlayBackground.Visibility = Visibility.Hidden;
        }

        private void btnProfileImage_Click(object sender, RoutedEventArgs e)
        {
            btnProfileImage.ContextMenu.IsOpen = true;
        }


        private void mnuProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuBuddies_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuMyItems_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuAccountSettings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuLogOut_Click(object sender, RoutedEventArgs e)
        {
            if (ShowOverlay("Confirmation", "Are you sure you wish to log out?", "Yes", "No") == 1)
            {
                Logout();
            }
        }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
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
                    new UpdatesAvailableWindow
                    {
                        changeLog = tempFileContents,
                        applicationName = "Acadiverse Desktop Client"
                    }.ShowDialog();
                }
                File.Delete("changelog_TEMP.txt");
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
        }
    }
}
