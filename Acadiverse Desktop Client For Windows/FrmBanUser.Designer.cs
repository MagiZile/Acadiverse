namespace AcadiverseDesktop
{
    partial class FrmBanUser
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.chkPermanentBan = new System.Windows.Forms.CheckBox();
            this.lblBanDuration = new System.Windows.Forms.Label();
            this.cboBanDuration = new System.Windows.Forms.ComboBox();
            this.lblBanReason = new System.Windows.Forms.Label();
            this.txtBanReason = new System.Windows.Forms.TextBox();
            this.benCancel = new System.Windows.Forms.Button();
            this.btnBanUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(11, 11);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(57, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "label1";
            // 
            // chkPermanentBan
            // 
            this.chkPermanentBan.AutoSize = true;
            this.chkPermanentBan.Location = new System.Drawing.Point(15, 45);
            this.chkPermanentBan.Name = "chkPermanentBan";
            this.chkPermanentBan.Size = new System.Drawing.Size(150, 17);
            this.chkPermanentBan.TabIndex = 1;
            this.chkPermanentBan.Text = "Permanently ban this user.";
            this.chkPermanentBan.UseVisualStyleBackColor = true;
            this.chkPermanentBan.CheckedChanged += new System.EventHandler(this.ChkPermanentBan_CheckedChanged);
            // 
            // lblBanDuration
            // 
            this.lblBanDuration.AutoSize = true;
            this.lblBanDuration.Location = new System.Drawing.Point(12, 77);
            this.lblBanDuration.Name = "lblBanDuration";
            this.lblBanDuration.Size = new System.Drawing.Size(72, 13);
            this.lblBanDuration.TabIndex = 2;
            this.lblBanDuration.Text = "Ban Duration:";
            // 
            // cboBanDuration
            // 
            this.cboBanDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanDuration.FormattingEnabled = true;
            this.cboBanDuration.Items.AddRange(new object[] {
            "30 minutes",
            "6 hours",
            "12 hours",
            "24 hours",
            "48 hours",
            "14 days",
            "1 month",
            "3 months",
            "6 monhs",
            "1 year"});
            this.cboBanDuration.Location = new System.Drawing.Point(90, 74);
            this.cboBanDuration.Name = "cboBanDuration";
            this.cboBanDuration.Size = new System.Drawing.Size(121, 21);
            this.cboBanDuration.TabIndex = 3;
            // 
            // lblBanReason
            // 
            this.lblBanReason.AutoSize = true;
            this.lblBanReason.Location = new System.Drawing.Point(15, 128);
            this.lblBanReason.Name = "lblBanReason";
            this.lblBanReason.Size = new System.Drawing.Size(69, 13);
            this.lblBanReason.TabIndex = 4;
            this.lblBanReason.Text = "Ban Reason:";
            // 
            // txtBanReason
            // 
            this.txtBanReason.Location = new System.Drawing.Point(90, 125);
            this.txtBanReason.Name = "txtBanReason";
            this.txtBanReason.Size = new System.Drawing.Size(260, 20);
            this.txtBanReason.TabIndex = 5;
            // 
            // benCancel
            // 
            this.benCancel.Location = new System.Drawing.Point(275, 167);
            this.benCancel.Name = "benCancel";
            this.benCancel.Size = new System.Drawing.Size(75, 23);
            this.benCancel.TabIndex = 6;
            this.benCancel.Text = "Cancel";
            this.benCancel.UseVisualStyleBackColor = true;
            // 
            // btnBanUser
            // 
            this.btnBanUser.Location = new System.Drawing.Point(194, 167);
            this.btnBanUser.Name = "btnBanUser";
            this.btnBanUser.Size = new System.Drawing.Size(75, 23);
            this.btnBanUser.TabIndex = 7;
            this.btnBanUser.Text = "Ban User";
            this.btnBanUser.UseVisualStyleBackColor = true;
            this.btnBanUser.Click += new System.EventHandler(this.BtnBanUser_Click);
            // 
            // FrmBanUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 202);
            this.Controls.Add(this.btnBanUser);
            this.Controls.Add(this.benCancel);
            this.Controls.Add(this.txtBanReason);
            this.Controls.Add(this.lblBanReason);
            this.Controls.Add(this.cboBanDuration);
            this.Controls.Add(this.lblBanDuration);
            this.Controls.Add(this.chkPermanentBan);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBanUser";
            this.Text = "Ban User";
            this.Load += new System.EventHandler(this.FrmBanUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.CheckBox chkPermanentBan;
        private System.Windows.Forms.Label lblBanDuration;
        private System.Windows.Forms.ComboBox cboBanDuration;
        private System.Windows.Forms.Label lblBanReason;
        private System.Windows.Forms.TextBox txtBanReason;
        private System.Windows.Forms.Button benCancel;
        private System.Windows.Forms.Button btnBanUser;
    }
}