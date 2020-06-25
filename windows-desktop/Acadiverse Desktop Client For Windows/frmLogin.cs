using MagiZile.Acadiverse;
using MagiZile.Acadiverse.Properties;
using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Controls.WindowsForms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcadiverseDesktop
{
    public partial class FrmLogin : Form
    {

        public Account currentAccount;

        public FrmLogin()
        {
            InitializeComponent();
        }

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
                    Globals.ShowErrorMessage(Resources.str_incorrect_username);
                    return;
                }
                if (txtPassword.Text == "")
                {
                    Show();
                    Globals.ShowErrorMessage(Resources.str_blank_password);
                }
                else
                {
                    if (Globals.CorrectPassword(txtPassword.Text, objAccount.Password))
                    {
                        Show();
                        Globals.ShowErrorMessage(Resources.str_incorrect_passwrod);
                    }
                    else
                    {
                        if (objAccount.AccountBanned)
                        {
                            Show();
                            if (objAccount.DateBanExpires.Year == 1970)
                            {
                                new TaskDialog
                                {
                                    Caption = "Account Banned",
                                    InstructionText = "Your account has been banned.",
                                    Text = Resources.str_account_permabanned.Replace("$1", objAccount.BanReason),
                                    HyperlinksEnabled = true
                                }.Show();
                            }
                            else
                            {
                                new TaskDialog
                                {
                                    Caption = "Account Banned",
                                    InstructionText = "Your account has been banned.",
                                    Text = Resources.str_account_tempbanned.Replace("$1", objAccount.DateBanExpires.ToLongDateString()).Replace("$2", objAccount.BanReason),
                                    HyperlinksEnabled = true
                                }.Show();
                            }
                        }
                        else
                        {
                            currentAccount = objAccount;
                            this.DialogResult = DialogResult.OK;
                        }
                    }
                }
            }
            else
            {
                Globals.ShowErrorMessage(Resources.str_blank_username);
            }
        }

        private void LnkForgotPAssword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://acadiverse.magizile.com/account/forgot-password.php");
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            if (frmRegister.ShowDialog() == DialogResult.OK)
            {
                Hide();
                FrmAcadiverseDesktopClient frmAcadiverseLauncher = new FrmAcadiverseDesktopClient
                {
                    currentAccount = frmRegister.newAccount
                };
                frmAcadiverseLauncher.Show();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (currentAccount == null)
            {
                Application.Exit();
            }
        }
    }
}
