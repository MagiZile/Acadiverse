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
    public partial class frmInfractionHistory : Form
    {
        public Account selectedAccount;

        public frmInfractionHistory()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmInfractionHistory_Load(object sender, EventArgs e)
        {
            foreach (Infraction infraction in Infraction.GetAllInfractions(selectedAccount.Username))
            {
                ListViewItem objItem = new ListViewItem
                {
                    Text = infraction.InfractionDate.ToString()
                };
                objItem.SubItems.Add(infraction.Type.ToString());
                objItem.SubItems.Add(infraction.ModeratorName);
                objItem.SubItems.Add(infraction.Reason);
                lvwInfractionHistory.Items.Add(objItem);
            }
            lvwInfractionHistory.Sort();
        }
    }
}
