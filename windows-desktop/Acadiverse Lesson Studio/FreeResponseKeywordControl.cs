using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnsClient.Protocol;

namespace Acadiverse_Lesson_Studio
{
    public partial class FreeResponseKeywordControl : UserControl
    {
        public FreeResponseKeywordControl()
        {
            InitializeComponent();
        }

        public override string Text { get => txtKeyword.Text; set => txtKeyword.Text = value; }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
