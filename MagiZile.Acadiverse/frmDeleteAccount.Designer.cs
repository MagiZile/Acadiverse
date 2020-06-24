namespace MagiZile.Acadiverse
{
    partial class frmDeleteAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteAccount));
            this.lblDeleteAccountMessage = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkConfirm = new System.Windows.Forms.CheckBox();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeleteAccountMessage
            // 
            this.lblDeleteAccountMessage.AutoSize = true;
            this.lblDeleteAccountMessage.Location = new System.Drawing.Point(3, 9);
            this.lblDeleteAccountMessage.Name = "lblDeleteAccountMessage";
            this.lblDeleteAccountMessage.Size = new System.Drawing.Size(343, 52);
            this.lblDeleteAccountMessage.TabIndex = 0;
            this.lblDeleteAccountMessage.Text = resources.GetString("lblDeleteAccountMessage.Text");
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(6, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(340, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // chkConfirm
            // 
            this.chkConfirm.AutoSize = true;
            this.chkConfirm.Location = new System.Drawing.Point(6, 102);
            this.chkConfirm.Name = "chkConfirm";
            this.chkConfirm.Size = new System.Drawing.Size(296, 17);
            this.chkConfirm.TabIndex = 2;
            this.chkConfirm.Text = "I understand that I will not be able to restore this account.";
            this.chkConfirm.UseVisualStyleBackColor = true;
            this.chkConfirm.CheckedChanged += new System.EventHandler(this.ChkConfirm_CheckedChanged);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Enabled = false;
            this.btnDeleteAccount.Location = new System.Drawing.Point(156, 125);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(92, 23);
            this.btnDeleteAccount.TabIndex = 3;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(254, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmDeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 154);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.chkConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblDeleteAccountMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDeleteAccount";
            this.Text = "Delete Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteAccountMessage;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkConfirm;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnCancel;
    }
}