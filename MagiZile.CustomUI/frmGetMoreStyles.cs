using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI
{
    public partial class FrmGetMoreStyles : Form
    {
        public FrmGetMoreStyles()
        {
            InitializeComponent();
        }

        readonly int stylesFound = 0;

        /// <summary>
        /// Loads styles from the MagiZile website.
        /// </summary>\
        void LoadStyles()
        {
            lvwStyles.Clear();
            if (txtSearch.Text == "")
            {

            }
            else
            {

            }
            if (stylesFound == 0)
            {
                lblNoStyles.Visible = true;
            }
            else
            {
                lblNoStyles.Visible = false;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmGetMoreStyles_Load(object sender, EventArgs e)
        {
            LoadStyles();
        }

        private void BtnUploadStyle_Click(object sender, EventArgs e)
        {
            frmStyleInfo frmStyleInfo = new frmStyleInfo();
            frmStyleInfo.ShowDialog();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            LoadStyles();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            
        }
    }
}
