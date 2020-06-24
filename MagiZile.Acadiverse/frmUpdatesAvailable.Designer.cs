namespace AcadiverseDesktop
{
    partial class frmUpdatesAvailable
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
            this.lblNewVersionAvailable = new System.Windows.Forms.Label();
            this.txtChangeLog = new System.Windows.Forms.TextBox();
            this.btnDownloadUpdate = new System.Windows.Forms.Button();
            this.btnRemindMeLater = new System.Windows.Forms.Button();
            this.btnSkipNewVersion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNewVersionAvailable
            // 
            this.lblNewVersionAvailable.AutoSize = true;
            this.lblNewVersionAvailable.Location = new System.Drawing.Point(12, 9);
            this.lblNewVersionAvailable.Name = "lblNewVersionAvailable";
            this.lblNewVersionAvailable.Size = new System.Drawing.Size(200, 13);
            this.lblNewVersionAvailable.TabIndex = 0;
            this.lblNewVersionAvailable.Text = "A new version of Acadiverse is available.";
            // 
            // txtChangeLog
            // 
            this.txtChangeLog.Location = new System.Drawing.Point(12, 43);
            this.txtChangeLog.Multiline = true;
            this.txtChangeLog.Name = "txtChangeLog";
            this.txtChangeLog.Size = new System.Drawing.Size(406, 403);
            this.txtChangeLog.TabIndex = 1;
            // 
            // btnDownloadUpdate
            // 
            this.btnDownloadUpdate.Location = new System.Drawing.Point(10, 461);
            this.btnDownloadUpdate.Name = "btnDownloadUpdate";
            this.btnDownloadUpdate.Size = new System.Drawing.Size(132, 23);
            this.btnDownloadUpdate.TabIndex = 2;
            this.btnDownloadUpdate.Text = "Download Update";
            this.btnDownloadUpdate.UseVisualStyleBackColor = true;
            this.btnDownloadUpdate.Click += new System.EventHandler(this.btnDownloadUpdate_Click);
            // 
            // btnRemindMeLater
            // 
            this.btnRemindMeLater.Location = new System.Drawing.Point(148, 461);
            this.btnRemindMeLater.Name = "btnRemindMeLater";
            this.btnRemindMeLater.Size = new System.Drawing.Size(132, 23);
            this.btnRemindMeLater.TabIndex = 2;
            this.btnRemindMeLater.Text = "Remind Me Later";
            this.btnRemindMeLater.UseVisualStyleBackColor = true;
            this.btnRemindMeLater.Click += new System.EventHandler(this.btnRemindMeLater_Click);
            // 
            // btnSkipNewVersion
            // 
            this.btnSkipNewVersion.Location = new System.Drawing.Point(286, 461);
            this.btnSkipNewVersion.Name = "btnSkipNewVersion";
            this.btnSkipNewVersion.Size = new System.Drawing.Size(132, 23);
            this.btnSkipNewVersion.TabIndex = 2;
            this.btnSkipNewVersion.Text = "Skip New Version";
            this.btnSkipNewVersion.UseVisualStyleBackColor = true;
            this.btnSkipNewVersion.Click += new System.EventHandler(this.btnSkipNewVersion_Click);
            // 
            // frmUpdatesAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 496);
            this.Controls.Add(this.btnSkipNewVersion);
            this.Controls.Add(this.btnRemindMeLater);
            this.Controls.Add(this.btnDownloadUpdate);
            this.Controls.Add(this.txtChangeLog);
            this.Controls.Add(this.lblNewVersionAvailable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUpdatesAvailable";
            this.Text = "Update Available";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewVersionAvailable;
        private System.Windows.Forms.TextBox txtChangeLog;
        private System.Windows.Forms.Button btnDownloadUpdate;
        private System.Windows.Forms.Button btnRemindMeLater;
        private System.Windows.Forms.Button btnSkipNewVersion;
    }
}