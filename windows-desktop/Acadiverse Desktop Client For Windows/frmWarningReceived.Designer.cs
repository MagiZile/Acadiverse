namespace AcadiverseDesktop
{
    partial class frmWarningReceived
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
            this.lblWarningMessageHeading = new System.Windows.Forms.Label();
            this.txtWarningDetails = new System.Windows.Forms.TextBox();
            this.lblPloicyReminder = new System.Windows.Forms.Label();
            this.lnkTermsOfService = new System.Windows.Forms.LinkLabel();
            this.lnkCodeOfConduct = new System.Windows.Forms.LinkLabel();
            this.btnAcknowledgeWarning = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWarningMessageHeading
            // 
            this.lblWarningMessageHeading.AutoSize = true;
            this.lblWarningMessageHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarningMessageHeading.Location = new System.Drawing.Point(12, 9);
            this.lblWarningMessageHeading.Name = "lblWarningMessageHeading";
            this.lblWarningMessageHeading.Size = new System.Drawing.Size(628, 31);
            this.lblWarningMessageHeading.TabIndex = 0;
            this.lblWarningMessageHeading.Text = "You have received a warning from a moderator!";
            // 
            // txtWarningDetails
            // 
            this.txtWarningDetails.AcceptsReturn = true;
            this.txtWarningDetails.BackColor = System.Drawing.SystemColors.Control;
            this.txtWarningDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWarningDetails.Location = new System.Drawing.Point(18, 57);
            this.txtWarningDetails.Multiline = true;
            this.txtWarningDetails.Name = "txtWarningDetails";
            this.txtWarningDetails.ReadOnly = true;
            this.txtWarningDetails.Size = new System.Drawing.Size(622, 284);
            this.txtWarningDetails.TabIndex = 1;
            // 
            // lblPloicyReminder
            // 
            this.lblPloicyReminder.AutoSize = true;
            this.lblPloicyReminder.Location = new System.Drawing.Point(19, 359);
            this.lblPloicyReminder.Name = "lblPloicyReminder";
            this.lblPloicyReminder.Size = new System.Drawing.Size(278, 13);
            this.lblPloicyReminder.TabIndex = 2;
            this.lblPloicyReminder.Text = "Please review our Terms of Service and Code of Conduct";
            // 
            // lnkTermsOfService
            // 
            this.lnkTermsOfService.AutoSize = true;
            this.lnkTermsOfService.Location = new System.Drawing.Point(318, 359);
            this.lnkTermsOfService.Name = "lnkTermsOfService";
            this.lnkTermsOfService.Size = new System.Drawing.Size(87, 13);
            this.lnkTermsOfService.TabIndex = 3;
            this.lnkTermsOfService.TabStop = true;
            this.lnkTermsOfService.Text = "Terms of Service";
            this.lnkTermsOfService.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTermsOfService_LinkClicked);
            // 
            // lnkCodeOfConduct
            // 
            this.lnkCodeOfConduct.AutoSize = true;
            this.lnkCodeOfConduct.Location = new System.Drawing.Point(411, 359);
            this.lnkCodeOfConduct.Name = "lnkCodeOfConduct";
            this.lnkCodeOfConduct.Size = new System.Drawing.Size(87, 13);
            this.lnkCodeOfConduct.TabIndex = 4;
            this.lnkCodeOfConduct.TabStop = true;
            this.lnkCodeOfConduct.Text = "Code of Conduct";
            this.lnkCodeOfConduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCodeOfConduct_LinkClicked);
            // 
            // btnAcknowledgeWarning
            // 
            this.btnAcknowledgeWarning.Enabled = false;
            this.btnAcknowledgeWarning.Location = new System.Drawing.Point(504, 385);
            this.btnAcknowledgeWarning.Name = "btnAcknowledgeWarning";
            this.btnAcknowledgeWarning.Size = new System.Drawing.Size(136, 23);
            this.btnAcknowledgeWarning.TabIndex = 5;
            this.btnAcknowledgeWarning.Text = "Acknowledge Warning";
            this.btnAcknowledgeWarning.UseVisualStyleBackColor = true;
            this.btnAcknowledgeWarning.Click += new System.EventHandler(this.btnAcknowledgeWarning_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(49, 385);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(449, 13);
            this.lblInstructions.TabIndex = 6;
            this.lblInstructions.Text = "Review our policies by clinking the links above to enable the \"Acknowledge Warnin" +
    "g\" button.";
            // 
            // frmWarningReceived
            // 
            this.AcceptButton = this.btnAcknowledgeWarning;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 420);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnAcknowledgeWarning);
            this.Controls.Add(this.lnkCodeOfConduct);
            this.Controls.Add(this.lnkTermsOfService);
            this.Controls.Add(this.lblPloicyReminder);
            this.Controls.Add(this.txtWarningDetails);
            this.Controls.Add(this.lblWarningMessageHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWarningReceived";
            this.Text = "Warning Received";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmWarnningReceived_FormClosed);
            this.Load += new System.EventHandler(this.frmWarnningReceived_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWarningMessageHeading;
        private System.Windows.Forms.TextBox txtWarningDetails;
        private System.Windows.Forms.Label lblPloicyReminder;
        private System.Windows.Forms.LinkLabel lnkTermsOfService;
        private System.Windows.Forms.LinkLabel lnkCodeOfConduct;
        private System.Windows.Forms.Button btnAcknowledgeWarning;
        private System.Windows.Forms.Label lblInstructions;
    }
}