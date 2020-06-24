namespace MagiZile.CustomUI
{
    partial class ProgressDisplay
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
            this.lblTask = new System.Windows.Forms.Label();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Location = new System.Drawing.Point(20, 16);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(70, 13);
            this.lblTask.TabIndex = 0;
            this.lblTask.Text = "Please wait...";
            // 
            // prgProgress
            // 
            this.prgProgress.Location = new System.Drawing.Point(23, 32);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(392, 23);
            this.prgProgress.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(421, 32);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(35, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Location = new System.Drawing.Point(20, 58);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(35, 13);
            this.lblPercentage.TabIndex = 3;
            this.lblPercentage.Text = "label1";
            // 
            // ProgressDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 90);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.lblTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProgressDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressDisplay";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblTask;
        public System.Windows.Forms.ProgressBar prgProgress;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lblPercentage;
    }
}