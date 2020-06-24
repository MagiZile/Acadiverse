namespace MagiZile.Acadiverse
{
    partial class FrmConnectingToServer
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
            this.lblConnecting = new System.Windows.Forms.Label();
            this.prgConnecting = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblConnecting
            // 
            this.lblConnecting.AutoSize = true;
            this.lblConnecting.Location = new System.Drawing.Point(12, 9);
            this.lblConnecting.Name = "lblConnecting";
            this.lblConnecting.Size = new System.Drawing.Size(175, 13);
            this.lblConnecting.TabIndex = 0;
            this.lblConnecting.Text = "Connecting to Acadiverse servers...";
            // 
            // prgConnecting
            // 
            this.prgConnecting.Location = new System.Drawing.Point(12, 25);
            this.prgConnecting.Name = "prgConnecting";
            this.prgConnecting.Size = new System.Drawing.Size(435, 23);
            this.prgConnecting.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgConnecting.TabIndex = 1;
            // 
            // FrmConnectingToServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 56);
            this.ControlBox = false;
            this.Controls.Add(this.prgConnecting);
            this.Controls.Add(this.lblConnecting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConnectingToServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connecting to Acadiverse servers...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnecting;
        private System.Windows.Forms.ProgressBar prgConnecting;
    }
}