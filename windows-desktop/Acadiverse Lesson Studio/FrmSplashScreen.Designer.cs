namespace Acadiverse_Lesson_Studio
{
    partial class FrmSplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picSplashScreenImage = new System.Windows.Forms.PictureBox();
            this.pnlBottomPanel = new System.Windows.Forms.Panel();
            this.lblCurrentTask = new System.Windows.Forms.Label();
            this.prgLoadingProgress = new System.Windows.Forms.ProgressBar();
            this.bgwStartupTasks = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picSplashScreenImage)).BeginInit();
            this.pnlBottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSplashScreenImage
            // 
            this.picSplashScreenImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSplashScreenImage.Location = new System.Drawing.Point(0, 0);
            this.picSplashScreenImage.Name = "picSplashScreenImage";
            this.picSplashScreenImage.Size = new System.Drawing.Size(569, 338);
            this.picSplashScreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSplashScreenImage.TabIndex = 0;
            this.picSplashScreenImage.TabStop = false;
            // 
            // pnlBottomPanel
            // 
            this.pnlBottomPanel.Controls.Add(this.lblCurrentTask);
            this.pnlBottomPanel.Controls.Add(this.prgLoadingProgress);
            this.pnlBottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomPanel.Location = new System.Drawing.Point(0, 286);
            this.pnlBottomPanel.Name = "pnlBottomPanel";
            this.pnlBottomPanel.Size = new System.Drawing.Size(569, 52);
            this.pnlBottomPanel.TabIndex = 1;
            // 
            // lblCurrentTask
            // 
            this.lblCurrentTask.AutoSize = true;
            this.lblCurrentTask.Location = new System.Drawing.Point(12, 24);
            this.lblCurrentTask.Name = "lblCurrentTask";
            this.lblCurrentTask.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentTask.TabIndex = 1;
            this.lblCurrentTask.Text = "label1";
            // 
            // prgLoadingProgress
            // 
            this.prgLoadingProgress.Location = new System.Drawing.Point(3, 3);
            this.prgLoadingProgress.Name = "prgLoadingProgress";
            this.prgLoadingProgress.Size = new System.Drawing.Size(563, 18);
            this.prgLoadingProgress.TabIndex = 0;
            // 
            // bgwStartupTasks
            // 
            this.bgwStartupTasks.WorkerReportsProgress = true;
            this.bgwStartupTasks.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwStartupTasks_DoWork);
            this.bgwStartupTasks.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BgwStartupTasks_ProgressChanged);
            this.bgwStartupTasks.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgwStartupTasks_RunWorkerCompleted);
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 338);
            this.Controls.Add(this.pnlBottomPanel);
            this.Controls.Add(this.picSplashScreenImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acadiverse Lesson Studio";
            this.Load += new System.EventHandler(this.FrmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSplashScreenImage)).EndInit();
            this.pnlBottomPanel.ResumeLayout(false);
            this.pnlBottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSplashScreenImage;
        private System.Windows.Forms.Panel pnlBottomPanel;
        private System.Windows.Forms.Label lblCurrentTask;
        private System.Windows.Forms.ProgressBar prgLoadingProgress;
        private System.ComponentModel.BackgroundWorker bgwStartupTasks;
    }
}

