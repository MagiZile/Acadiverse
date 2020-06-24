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
    public partial class CustomTitleBar : UserControl
    {
        public CustomTitleBar()
        {
            InitializeComponent();
        }

        private void CustonTitleBar_Resize(object sender, EventArgs e)
        {
            if (Height != 16)
            {
                Height = 16;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (ParentForm.WindowState == FormWindowState.Normal)
            {
                ParentForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                ParentForm.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }
    }
}
