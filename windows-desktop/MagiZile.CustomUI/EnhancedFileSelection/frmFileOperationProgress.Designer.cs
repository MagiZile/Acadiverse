namespace MagiZile.CustomUI.EnhancedFileSelection
{
    partial class frmFileOperationProgress
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
            this.lblPercentage = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.lblTitle = new System.Windows.Forms.Label();
            this.bgwTask = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPercentage
            // 
            this.lblPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(418, 4);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(33, 13);
            this.lblPercentage.TabIndex = 8;
            this.lblPercentage.Text = "100%";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNotes.Location = new System.Drawing.Point(0, 32);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(52, 13);
            this.lblNotes.TabIndex = 7;
            this.lblNotes.Text = "Extra Info";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgProgress
            // 
            this.prgProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgProgress.Location = new System.Drawing.Point(40, 4);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(372, 21);
            this.prgProgress.TabIndex = 6;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(3, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(31, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Task";
            // 
            // bgwTask
            // 
            this.bgwTask.WorkerReportsProgress = true;
            this.bgwTask.WorkerSupportsCancellation = true;
            this.bgwTask.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwTask_DoWork);
            this.bgwTask.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwTask_ProgressChanged);
            this.bgwTask.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwTask_RunWorkerCompleted);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(457, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmFileOperationProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 45);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFileOperationProgress";
            this.Text = "File Operation";
            this.Load += new System.EventHandler(this.frmFileOperationProgress_Load);
            this.Shown += new System.EventHandler(this.frmFileOperationProgress_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.ProgressBar prgProgress;
        private System.Windows.Forms.Label lblTitle;
        public System.ComponentModel.BackgroundWorker bgwTask;
        private System.Windows.Forms.Button button1;
    }
}