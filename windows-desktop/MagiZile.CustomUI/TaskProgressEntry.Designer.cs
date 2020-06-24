namespace MagiZile.CustomUI
{
    partial class TaskProgressEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.prgProgress = new System.Windows.Forms.ProgressBar();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.lblTaskProgress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(178, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 62);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // prgProgress
            // 
            this.prgProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgProgress.Location = new System.Drawing.Point(3, 16);
            this.prgProgress.Name = "prgProgress";
            this.prgProgress.Size = new System.Drawing.Size(169, 23);
            this.prgProgress.TabIndex = 1;
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTaskDescription.Location = new System.Drawing.Point(0, 0);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(96, 13);
            this.lblTaskDescription.TabIndex = 2;
            this.lblTaskDescription.Text = "Task Description...";
            // 
            // lblTaskProgress
            // 
            this.lblTaskProgress.AutoSize = true;
            this.lblTaskProgress.Location = new System.Drawing.Point(3, 42);
            this.lblTaskProgress.Name = "lblTaskProgress";
            this.lblTaskProgress.Size = new System.Drawing.Size(21, 13);
            this.lblTaskProgress.TabIndex = 3;
            this.lblTaskProgress.Text = "0%";
            // 
            // TaskProgressEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTaskProgress);
            this.Controls.Add(this.lblTaskDescription);
            this.Controls.Add(this.prgProgress);
            this.Controls.Add(this.btnCancel);
            this.Name = "TaskProgressEntry";
            this.Size = new System.Drawing.Size(238, 62);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar prgProgress;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.Label lblTaskProgress;
    }
}
