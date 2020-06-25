using MagiZile.Acadiverse;
using MagiZile.UserInteractions.ParentalControls;
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

namespace AcadiverseDesktop
{
    public partial class FrmRegister : Form
    {
        public Account newAccount;

        public FrmRegister()
        {
            InitializeComponent();
        }

        int PasswordStrength()
        {
            int value = 0;
            if (txtPassword.Text.Length >= 8)
            {
                int numberOfCapitalLetters = 0;
                int numberOfLowercaseLetters = 0;
                int numberOfDigits = 0;
                int numberOfSymbols = 0;
                foreach (char c in txtPassword.Text)
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

        private void LinkViewTermsOfService_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://acadiverse.magizile.com/terms_of_service.html");
        }

        private void LnkViewPrivacyPolicy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://acadiverse.magizile.com/privacy_policy.html");
        }

        private void LnkViewCodeOfConduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://acadiverse.magizile.com/code_of_conduct.html");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (Account.AccountExists(txtUsername.Text))
            {
                Globals.ShowErrorMessage("This username is unavailable.");
            }
            else
            {
                if (new WordFilter(WordFilter.FilteringLevel.Strict).ContainsBadWords(txtUsername.Text, false))
                {
                    Globals.ShowErrorMessage("The username you have chosen is not allowed on Acadiverse because it contains swear words or racial slurs.");
                }
                else
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        if (PasswordStrength() == -1)
                        {
                            MessageBox.Show("Your password does not meet the requirements.");
                        }
                        else
                        {
                            if (mtxBirthday.Text == "")
                            {
                                Globals.ShowErrorMessage("Please enter a valid birthday.");
                            }
                            else
                            {
                                if (txtEmail.Text == "")
                                {
                                    Globals.ShowErrorMessage("The email must not be blank.");
                                }
                                else
                                {
                                    if (!rbtParent.Checked && !rbtStudent.Checked && !rbtTeacher.Checked)
                                    {
                                        Globals.ShowErrorMessage("Please select an account type.");
                                    }
                                    else
                                    {
                                        if (!chkAgreeToPolicies.Checked)
                                        {
                                            Globals.ShowErrorMessage("You must agree to the Terms of Secrive, Code of Conduct, and Privacy Policy.");
                                        }
                                        else
                                        {
                                            Account account = new Account
                                            {
                                                Username = txtUsername.Text,
                                                Password = Globals.SaltedPassword(txtPassword.Text)
                                            };
                                            if (rbtParent.Checked)
                                            {
                                                account.AccountType = AcadiverseAccountType.Parent;
                                            }
                                            else if (rbtStudent.Checked)
                                            {
                                                account.AccountType = AcadiverseAccountType.Student;
                                            }
                                            else if (rbtTeacher.Checked)
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
                                            account.Birthday = (DateTime)(mtxBirthday.ValidateText());
                                            account.ProfileBio = "";
                                            account.ReputationPoints = 0;
                                            account.Money = 0;
                                            account.LastLoginDate = DateTime.Now;
                                            account.AccountCreationDate = DateTime.Now;
                                            account.Buddies = new BsonArray();
                                            account.PrivateMessages = new BsonArray();
                                            account.Email = txtEmail.Text;
                                            account.SaveToServer();
                                            newAccount = account;
                                            DialogResult = DialogResult.OK;
                                            Close();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
