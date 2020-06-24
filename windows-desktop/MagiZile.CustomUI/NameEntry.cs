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
    public partial class NameEntry : UserControl
    {
        public NameEntry()
        {
            InitializeComponent();
        }

        PersonName fullName = new PersonName("", "");

        /// <summary>
        /// The full name that the user entered.
        /// </summary>
        public PersonName FullName
        {
            get
            {
                return fullName;
            }
        }

        public string FirstName
        {
            get
            {
                return txtFirstName.Text;
            }
            set
            {
                txtFirstName.Text = value;
            }
        }

        public string MiddleInitial
        {
            get
            {
                return txtMiddleInitial.Text;
            }
            set
            {
                txtMiddleInitial.Text = value;
            }
        }

        public string LastName
        {
            get
            {
                return txtLastName.Text;
            }
            set
            {
                txtLastName.Text = value;
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            lblFullName.Text = txtFirstName.Text + " " + txtMiddleInitial.Text + " " + txtLastName.Text;
            fullName = new PersonName(txtFirstName.Text, txtMiddleInitial.Text, txtLastName.Text);
        }

        private void txtMiddleInitial_TextChanged(object sender, EventArgs e)
        {
            lblFullName.Text = txtFirstName.Text + " " + txtMiddleInitial.Text + " " + txtLastName.Text;
            fullName = new PersonName(txtFirstName.Text, txtMiddleInitial.Text, txtLastName.Text);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            lblFullName.Text = txtFirstName.Text + " " + txtMiddleInitial.Text + " " + txtLastName.Text;
            fullName = new PersonName(txtFirstName.Text, txtMiddleInitial.Text, txtLastName.Text);
        }

        private void NameEntry_BackColorChanged(object sender, EventArgs e)
        {
            txtFirstName.BackColor = BackColor;
            txtMiddleInitial.BackColor = BackColor;
            txtLastName.BackColor = BackColor;
        }
    }
}
