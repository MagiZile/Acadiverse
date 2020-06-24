using MagiZile.Acadiverse;
using MagiZile.UtilityComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acadiverse_Lesson_Studio
{
    public partial class FrmMain : Form
    {
        public Account currentAccount;
        public LessonProject project;
        ProcessWatcher objProcessWatcher;
        readonly string currentFilename = "";

        public FrmMain()
        {
            InitializeComponent();
        }

        public void BackupProject()
        {

        }

        public void SaveProject()
        {
            project.Save(currentFilename);
        }

        public void LoadProject()
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            objProcessWatcher = new ProcessWatcher();
            objProcessWatcher.ProcessKilled += new ProcessWatcher.ProcessEventHandler(ObjProcessWatcher_ProcessKilled);
        }

        private void ObjProcessWatcher_ProcessKilled(object sender, ProcessEventArgs e)
        {
            foreach (Process process in e.RelatedProcesses)
            {
                if (process.ProcessName == "AcadiverseDesktop.exe")
                {
                    Application.Exit();
                }
            }
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BackupProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void PublishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentAccount.CanPublish)
            {
                new FrmPublish
                {
                    project = project
                }.ShowDialog();
            }
            else
            {
                Globals.ShowErrorMessage(MagiZile.Acadiverse.Properties.Resources.str_banned_from_publishing);
            }
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globals.ShowConfirmationMessage(MagiZile.Acadiverse.Properties.Resources.str_logout_confirmation, false))
            {
                File.Create(".logout");
                Application.Exit();
            }
        }
    }
}
