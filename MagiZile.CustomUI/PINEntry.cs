using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI
{
    public partial class PINEntry : UserControl
    {
        public PINEntry()
        {
            InitializeComponent();
        }

        public event EventHandler PINEnteredCorrectly;
        public string correctPIN = "1111";

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPIN.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPIN.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPIN.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPIN.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPIN.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPIN.Text += 6;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPIN.Text += 0;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPIN.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPIN.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPIN.Text += 9;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtPIN.Text == correctPIN)
            {
                PINEnteredCorrectly?.Invoke(this, e);
            }
            else
            {
                MessageBox.Show("The PIN was incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            txtPIN.Text = txtPIN.Text.Remove(txtPIN.Text.Length - 1, 1);
        }

        private void txtPIN_TextChanged(object sender, EventArgs e)
        {
            if (txtPIN.Text.Length == 0)
            {
                btnBackspace.Enabled = false;
            }
            else
            {
                btnBackspace.Enabled = true;
            }
        }

        private void txtPIN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEnter.PerformClick();
            }
        }
    }
}
