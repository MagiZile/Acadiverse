using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI.TabForms
{
    public partial class frmAddUnforseenEvent : Form
    {
        public frmAddUnforseenEvent()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCustom_TextChanged(object sender, EventArgs e)
        {
            rbtCustom.Checked = true;
        }

        private void cboEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboEvent.Items.Clear();
            switch (cboEvent.SelectedIndex)
            {
                case 0: //Broken Bone

                    break;
                case 1: //Burglary
                    
                    break;
                case 2: //Business Fire

                    break;
                case 3: //Flood

                    break;
                case 4: //Gas Leak

                    break;
                case 5: //Hail

                    break;
                case 6: //House Fire

                    break;
                case 7: //Hurricane

                    break;
                case 8: //Illness

                    break;
                case 9: //Tornado

                    break;
                default:
                    //Do nothing.
                    break;
            }
        }
    }
}
