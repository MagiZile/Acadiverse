namespace MagiZile.Acadiverse
{
    partial class frmReport
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
            this.lblReportReason = new System.Windows.Forms.Label();
            this.cboReportReason = new System.Windows.Forms.ComboBox();
            this.lblMoreDetails = new System.Windows.Forms.Label();
            this.txtMoreDetails = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReportReason
            // 
            this.lblReportReason.AutoSize = true;
            this.lblReportReason.Location = new System.Drawing.Point(12, 9);
            this.lblReportReason.Name = "lblReportReason";
            this.lblReportReason.Size = new System.Drawing.Size(312, 39);
            this.lblReportReason.TabIndex = 0;
            this.lblReportReason.Text = "We are so sorry that something on Acadiverse iss bothering you! \r\n\r\nPlease tell u" +
    "s more about why you are reporting this:";
            // 
            // cboReportReason
            // 
            this.cboReportReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReportReason.FormattingEnabled = true;
            this.cboReportReason.Items.AddRange(new object[] {
            "Disrespect towards other players.",
            "Spam.",
            "Foul language or racial/cultural slurs.",
            "Sexually-explicit content.",
            "Violent content.",
            "Solicitation of illegal/controlled goods.",
            "Linkung to adult sites or sites with illegal content.",
            "Teaching people how to commit cybercrimes.",
            "Insensitive content.",
            "Sharing or requesting personal/private/sensitive information.",
            "Impersonation or deception of another player."});
            this.cboReportReason.Location = new System.Drawing.Point(15, 63);
            this.cboReportReason.Name = "cboReportReason";
            this.cboReportReason.Size = new System.Drawing.Size(322, 21);
            this.cboReportReason.TabIndex = 1;
            // 
            // lblMoreDetails
            // 
            this.lblMoreDetails.AutoSize = true;
            this.lblMoreDetails.Location = new System.Drawing.Point(12, 98);
            this.lblMoreDetails.Name = "lblMoreDetails";
            this.lblMoreDetails.Size = new System.Drawing.Size(190, 13);
            this.lblMoreDetails.TabIndex = 2;
            this.lblMoreDetails.Text = "Please specify additional details below:";
            // 
            // txtMoreDetails
            // 
            this.txtMoreDetails.Location = new System.Drawing.Point(15, 117);
            this.txtMoreDetails.Name = "txtMoreDetails";
            this.txtMoreDetails.Size = new System.Drawing.Size(322, 20);
            this.txtMoreDetails.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(179, 150);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(262, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmReport
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(349, 179);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMoreDetails);
            this.Controls.Add(this.lblMoreDetails);
            this.Controls.Add(this.cboReportReason);
            this.Controls.Add(this.lblReportReason);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReport";
            this.Text = "Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportReason;
        private System.Windows.Forms.ComboBox cboReportReason;
        private System.Windows.Forms.Label lblMoreDetails;
        private System.Windows.Forms.TextBox txtMoreDetails;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}