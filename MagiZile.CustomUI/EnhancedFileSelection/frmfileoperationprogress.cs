using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI.EnhancedFileSelection
{
    public partial class frmFileOperationProgress : Form
    {
        public frmFileOperationProgress()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            EnhancedMessageBox objConfirmation = new EnhancedMessageBox();
            if (objConfirmation.Confirmation("Cancel Active Operations", "Are you sure you wish to cancel all active operations?", SystemIcons.Question.ToBitmap(), "Yes", "No") == DialogResult.Yes)
            {
                bgwTask.CancelAsync();
                Close();
            }
        }

        private void frmFileOperationProgress_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// A version of the System.IO.Directory.Delete() method that reports progress.
        /// </summary>
        /// <param name="path">The folder to delete.</param>
        public void DeleteFolder(string path)
        {
            foreach (string file in Directory.GetFiles(path))
            {
                File.Delete(file);
            }
            foreach (string dir in Directory.GetDirectories(path))
            {
                DeleteFolder(dir);
            }
            Directory.Delete(path);
        }

        public void StartFileOperation(FileOperation operation, string[] filePaths, string destinationDirectory = "")
        {
            switch (operation.Type)
            {
                case FileOperationType.CopyFile:

                    break;
                case FileOperationType.CopyFolder:

                    break;
                case FileOperationType.CopyMultipleFilesOrFolders:
                    foreach (string path in filePaths)
                    {

                    }
                    break;
                case FileOperationType.DeleteFile:

                    break;
                case FileOperationType.DeleteFolder:

                    break;
                case FileOperationType.DeleteMultipleFilesOrFolders:
                    foreach (string path in filePaths)
                    {
                        
                    }
                    break;
                case FileOperationType.MoveFile:

                    break;
                case FileOperationType.MoveFolder:

                    break;

                case FileOperationType.MoveMultpleFilesOrFolders:
                    foreach (string path in filePaths)
                    {

                    }
                    break;
            }
        }

        private void bgwTask_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblPercentage.Text = e.ProgressPercentage.ToString();
            prgProgress.Value = e.ProgressPercentage;
        }

        private void bgwTask_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Dispose();
        }

        private void frmFileOperationProgress_Shown(object sender, EventArgs e)
        {
            bgwTask.RunWorkerAsync();
        }

        private void bgwTask_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
