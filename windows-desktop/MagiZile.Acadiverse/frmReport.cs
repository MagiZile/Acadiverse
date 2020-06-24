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
    public partial class frmReport : Form
    {
        public string reportReason = "";
        public Account associatedAccount;

        public frmReport()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cboReportReason.SelectedIndex == -1)
            {
                Globals.ShowErrorMessage("Please specify a report reason.");
            }
            else
            {
                if (txtMoreDetails.Text == "")
                {
                    Globals.ShowErrorMessage("Please provide more details as to why you are reporting this content.");
                }
                else
                {
                    reportReason = cboReportReason.SelectedItem.ToString() + "- " + txtMoreDetails.Text;
                    if (Globals.ShowConfirmationMessage(Properties.Resources.str_report_confirmation.Replace("$1", associatedAccount.Username).Replace("$2", reportReason), true))
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
            }
        }
    }
}
