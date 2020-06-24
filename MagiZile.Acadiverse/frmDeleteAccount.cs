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
    public partial class frmDeleteAccount : Form
    {
        public frmDeleteAccount()
        {
            InitializeComponent();
        }

        public Account account;

        private void BtnDeleteAccount_Click(object sender, EventArgs e)
        {
            if(Globals.ShowConfirmationMessage("Are you really sure you wish to delete your account and all associated data?", true))
            {
                if (txtPassword.Text == Globals.DecryptString(account.Password))
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    Globals.ShowErrorMessage("You have entered an incorrect password.");
                }
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ChkConfirm_CheckedChanged(object sender, EventArgs e)
        {
            btnDeleteAccount.Enabled = chkConfirm.Checked;
        }
    }
}
