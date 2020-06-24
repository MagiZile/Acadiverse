using MagiZile.Acadiverse;
using MagiZile.Acadiverse.Properties;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Acadiverse_Desktop_Client
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        public Account currentAccount;

        void Login()
        {
            if (txtUsername.Text != "")
            {
                Account objAccount;
                if (Account.AccountExists(txtUsername.Text))
                {
                    objAccount = Account.LoadFromServer(txtUsername.Text);
                }
                else
                {
                    Show();
                    chkKeepUserLoggedIn.IsChecked = false;
                    Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_incorrect_username);
                    return;
                }
                if (txtPassword.Text == "")
                {
                    Show();
                    chkKeepUserLoggedIn.IsChecked = false;
                    Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_blank_password);
                }
                else
                {
                    if (txtPassword.Text != Globals.DecryptString(objAccount.Password))
                    {
                        Show();
                        chkKeepUserLoggedIn.IsChecked = false;
                        Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_incorrect_passwrod);
                    }
                    else
                    {
                        if (objAccount.AccountBanned)
                        {
                            Show();
                            chkKeepUserLoggedIn.IsChecked = false;
                            if (objAccount.DateBanExpires.Year == 1970)
                            {
                                Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_account_permabanned);
                            }
                            else
                            {
                                Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_account_tempbanned);
                            }
                        }
                        else
                        {
                            if (chkKeepUserLoggedIn.IsChecked == true)
                            {
                                Registry.SetValue(Globals.REGISTRY_PATH + @"\Acadiverse Desktop Client for Windows", "SaveLoginDetails", true);
                                Registry.SetValue(Globals.REGISTRY_PATH + @"\Acadiverse Desktop Client for Windows", "CurrentUsername", txtUsername.Text);
                                Registry.SetValue(Globals.REGISTRY_PATH + @"\Acadiverse Desktop Client for Windows", "CurrentPassword", Globals.EncryptString(txtPassword.Text));
                            }
                            currentAccount = objAccount;
                            this.DialogResult = true;
                        }
                    }
                }
            }
            else
            {
                Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_blank_username);
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Login();
        }
    }
}
