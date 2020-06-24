using MagiZile.Acadiverse;
using MagiZile.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcadiverseDesktop
{
    public partial class frmWarningReceived : Form
    {
        public frmWarningReceived()
        {
            InitializeComponent();
        }

        public Account currentAccount;

        private void frmWarnningReceived_Load(object sender, EventArgs e)
        {
            txtWarningDetails.Text = "This is your " + Globals.NumberWithOrdinalSuffix(currentAccount.Warnings) + " warning!"
                + "\n" + "Moderator Name: " + currentAccount.LastWarnedByModeratorName
                + "\n" + "Date Received: " + currentAccount.DateLastWarningReceived.ToLongDateString()
                + "\n" +"Warning Reason: " + currentAccount.LastWarningReason;
        }

        private void frmWarnningReceived_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void lnkTermsOfService_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://acadiverse.magizile.com/terms_of_service.html");
            lnkTermsOfService.LinkVisited = true;
            if (lnkTermsOfService.LinkVisited && lnkCodeOfConduct.LinkVisited)
            {
                btnAcknowledgeWarning.Enabled = true;
            }
        }

        private void lnkCodeOfConduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://acadiverse.magizile.com/code_of_conduct.html");
            lnkCodeOfConduct.LinkVisited = true;
            if (lnkTermsOfService.LinkVisited && lnkCodeOfConduct.LinkVisited)
            {
                btnAcknowledgeWarning.Enabled = true;
            }
        }

        private void btnAcknowledgeWarning_Click(object sender, EventArgs e)
        {
            currentAccount.AcknowledgedLastWarning = true;
            currentAccount.LastWarnedByModeratorName = "";
            currentAccount.DateLastWarningReceived = new DateTime(0);
            currentAccount.LastWarningReason = "";
            currentAccount.SaveToServer();
            DialogResult = DialogResult.OK;
        }
    }
}
