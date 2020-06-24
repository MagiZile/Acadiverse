using MagiZile.Acadiverse;
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
    public partial class FrmBanUser : Form
    {
        public FrmBanUser()
        {
            InitializeComponent();
        }

        public Account loggedInUser;
        public Account selectedAccount;

        private void ChkPermanentBan_CheckedChanged(object sender, EventArgs e)
        {
            lblBanDuration.Enabled = !chkPermanentBan.Checked;
            cboBanDuration.Enabled = !chkPermanentBan.Checked;
        }

        private void BtnBanUser_Click(object sender, EventArgs e)
        {
            if (cboBanDuration.SelectedIndex == -1 && chkPermanentBan.Checked == false)
            {
                Globals.ShowErrorMessage("Ban duration cannot be blank");
            }
            else
            {
                if (txtBanReason.Text == "")
                {
                    Globals.ShowErrorMessage("Ban reason cannot be blank.");
                }
                else
                {
                    if (chkPermanentBan.Checked == true)
                    {
                        if (Globals.ShowConfirmationMessage("Are you sure you wish to permanently ban the user " + selectedAccount.Username + "? This user will not be able to log in to Acadiverse until they are manually unbanned!", false))
                        {
                            Globals.BanUser(loggedInUser, selectedAccount, txtBanReason.Text, new TimeSpan(0));
                            Close();
                        }

                    }
                    else
                    {
                        if (Globals.ShowConfirmationMessage("Are you sure you wish to ban the user " + selectedAccount.Username + " for " + cboBanDuration.SelectedItem + "? This iser will not be able to log in to Acadiverse until the selected duration has elapsed!", false))
                        {
                            switch (cboBanDuration.SelectedIndex)
                            {
                                case 0: //6 hours
                                    Globals.BanUser(loggedInUser, selectedAccount, txtBanReason.Text, new TimeSpan(0, 6, 0));
                                    break;
                                case 1: //12 hours
                                    Globals.BanUser(loggedInUser, selectedAccount, txtBanReason.Text, new TimeSpan(12, 0, 0));
                                    break;
                                case 2: //24 hours
                                    Globals.BanUser(loggedInUser, selectedAccount, txtBanReason.Text, new TimeSpan(24, 0, 0));
                                    break;
                                case 3: //48 hours
                                    Globals.BanUser(loggedInUser, selectedAccount, txtBanReason.Text, new TimeSpan(48, 0, 0));
                                    break;
                                case 4: //14 days
                                    Globals.BanUser(loggedInUser, selectedAccount, txtBanReason.Text, new TimeSpan(14, 0, 0, 0));
                                    break;
                                case 5: //1 month
                                    Globals.BanUser(loggedInUser, selectedAccount, txtBanReason.Text, new TimeSpan(30, 0, 0, 0));
                                    break;
                                case 6: //3 months
                                    Globals.BanUser(loggedInUser, selectedAccount, txtBanReason.Text, new TimeSpan(90, 0, 0, 0));
                                    break;
                                case 7: //6 months
                                    Globals.BanUser(loggedInUser, selectedAccount, txtBanReason.Text, new TimeSpan(180, 0, 0, 0));
                                    break;
                                case 8: //1 year
                                    Globals.BanUser(loggedInUser, selectedAccount, txtBanReason.Text, new TimeSpan(365, 0, 0, 0));
                                    break;
                                default:
                                    throw (new ArgumentException());
                            }
                            Close();
                        }
                    }
                }
            }
        }

        private void FrmBanUser_Load(object sender, EventArgs e)
        {
            lblUsername.Text = selectedAccount.Username + "(ID: " + selectedAccount.ID + ")";
        }
    }
}
