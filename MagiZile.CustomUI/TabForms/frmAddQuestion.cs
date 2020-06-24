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
    public partial class frmAddQuestion : Form
    {
        public frmAddQuestion()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cboQuestionType.SelectedItem.ToString() == "")
            {
                MessageBox.Show("The question type cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.None;
            }
            else
            {

            }
        }
    }
}
