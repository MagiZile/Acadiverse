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
    public partial class PromptDialog : Form
    {
        public PromptDialog()
        {
            InitializeComponent();
        }

        public string textEntered = "";

        /// <summary>
        /// Shows a prompt box with the specified title and prompt.
        /// </summary>
        /// <param name="title">The title in the title bar.</param>
        /// <param name="prompt">The prompt message.</param>
        /// <returns>The text that the user typed in.</returns>
        public string ShowPrompt(string title, string prompt)
        {
            Text = title;
            lblPrompt.Text = prompt;
            ShowDialog();
            return txtInput.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
