using MagiZile.UtilityComponents;
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
    public partial class frmFind : Form
    {
        public frmFind()
        {
            InitializeComponent();
        }

        public RichTextBox textBox = null;
        int position = -1;
        int index = -1;
        List<int> matches = new List<int>();

        void updateMatches(int increment)
        {
            matches = FindAndReplace.Find(textBox.Text, txtFindText.Text, chkMatchCase.Checked, chkWholeWordsOnly.Checked);
            if (increment != 1 && increment != 0 && increment != -1)
            {
                throw (new ArgumentException());
            }
            index += increment;
            position = matches[index];
            if (matches.Count == 0)
            {
                lblMatchesFound.Text = "No matches found.";
            }
            else if (matches.Count == 1)
            {
                lblMatchesFound.Text = "1 match found.";
            }
            else
            {
                lblMatchesFound.Text = matches.Count + " matches found.";
            }
        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            updateMatches(1);
        }

        private void btnFindPrevious_Click(object sender, EventArgs e)
        {
            updateMatches(-1);
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            updateMatches(0);
        }
    }
}
