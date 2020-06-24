using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI.EnhancedFileSelection
{
    public partial class frmNewFolder : Form
    {
        public frmNewFolder()
        {
            InitializeComponent();
        }

        public string FolderName = "";

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNewFolderName.Text == "")
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("You must tyoe a folder name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FolderName = txtNewFolderName.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
