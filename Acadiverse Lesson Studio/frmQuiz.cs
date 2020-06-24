using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acadiverse_Lesson_Studio
{
    public partial class FrmQuiz : Form
    {
        public FrmQuiz()
        {
            InitializeComponent();
        }

        private void BtnAddFreeResponseKeyword_Click(object sender, EventArgs e)
        {
            flpFreeResponse.Controls.Add(new FreeResponseKeywordControl());
        }
    }
}
