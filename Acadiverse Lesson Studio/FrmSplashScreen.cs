using MagiZile.Acadiverse;
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
    public partial class FrmSplashScreen : Form
    {
        public Account currentAccount = new Account();
        readonly string currentTask = "";
        readonly FrmMain frmMain = new FrmMain();

        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            bgwStartupTasks.RunWorkerAsync();
        }

        private void BgwStartupTasks_DoWork(object sender, DoWorkEventArgs e)
        {
            frmMain.currentAccount = currentAccount;
        }

        private void BgwStartupTasks_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            frmMain.Show();
        }

        private void BgwStartupTasks_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            prgLoadingProgress.Value = e.ProgressPercentage;
            lblCurrentTask.Text = currentTask;
        }
    }
}