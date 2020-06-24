namespace AcadiverseDesktop
{
    partial class frmProfile
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
            this.picProfileImage = new System.Windows.Forms.PictureBox();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblAccountCreationDate = new System.Windows.Forms.Label();
            this.lblLastLoginDate = new System.Windows.Forms.Label();
            this.lblProfileBio = new System.Windows.Forms.Label();
            this.txtProfileBio = new System.Windows.Forms.TextBox();
            this.btnAddBuddy = new System.Windows.Forms.Button();
            this.btnSendPM = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.pnlModeratorOptions = new System.Windows.Forms.Panel();
            this.lblModeratorOptions = new System.Windows.Forms.Label();
            this.chkCanPublish = new System.Windows.Forms.CheckBox();
            this.chkCanChat = new System.Windows.Forms.CheckBox();
            this.btnBanAccount = new System.Windows.Forms.Button();
            this.pnlProfileErrorOverlay = new System.Windows.Forms.Panel();
            this.lblProfileError = new System.Windows.Forms.Label();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).BeginInit();
            this.pnlModeratorOptions.SuspendLayout();
            this.pnlProfileErrorOverlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // picProfileImage
            // 
            this.picProfileImage.Location = new System.Drawing.Point(21, 20);
            this.picProfileImage.Name = "picProfileImage";
            this.picProfileImage.Size = new System.Drawing.Size(64, 64);
            this.picProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfileImage.TabIndex = 0;
            this.picProfileImage.TabStop = false;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.Location = new System.Drawing.Point(91, 20);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(96, 25);
            this.lblDisplayName.TabIndex = 1;
            this.lblDisplayName.Text = "johndoe";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(92, 55);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 18);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "johndoe";
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Location = new System.Drawing.Point(22, 96);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(377, 13);
            this.lblAccountInfo.TabIndex = 3;
            this.lblAccountInfo.Text = "Student | Level 100 | 2147483647 Reputation Points | 2147483647 Acadicoins";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(22, 119);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(109, 13);
            this.lblBirthday.TabIndex = 4;
            this.lblBirthday.Text = "Birthday: 01/01/2001";
            // 
            // lblAccountCreationDate
            // 
            this.lblAccountCreationDate.AutoSize = true;
            this.lblAccountCreationDate.Location = new System.Drawing.Point(22, 143);
            this.lblAccountCreationDate.Name = "lblAccountCreationDate";
            this.lblAccountCreationDate.Size = new System.Drawing.Size(135, 13);
            this.lblAccountCreationDate.TabIndex = 5;
            this.lblAccountCreationDate.Text = "Sign-Up Date: 04/30/2020";
            // 
            // lblLastLoginDate
            // 
            this.lblLastLoginDate.AutoSize = true;
            this.lblLastLoginDate.Location = new System.Drawing.Point(22, 166);
            this.lblLastLoginDate.Name = "lblLastLoginDate";
            this.lblLastLoginDate.Size = new System.Drawing.Size(142, 13);
            this.lblLastLoginDate.TabIndex = 6;
            this.lblLastLoginDate.Text = "Last Logged In: 04/30/2020";
            // 
            // lblProfileBio
            // 
            this.lblProfileBio.AutoSize = true;
            this.lblProfileBio.Location = new System.Drawing.Point(22, 191);
            this.lblProfileBio.Name = "lblProfileBio";
            this.lblProfileBio.Size = new System.Drawing.Size(57, 13);
            this.lblProfileBio.TabIndex = 7;
            this.lblProfileBio.Text = "Profile Bio:";
            // 
            // txtProfileBio
            // 
            this.txtProfileBio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfileBio.Location = new System.Drawing.Point(21, 207);
            this.txtProfileBio.Multiline = true;
            this.txtProfileBio.Name = "txtProfileBio";
            this.txtProfileBio.ReadOnly = true;
            this.txtProfileBio.Size = new System.Drawing.Size(285, 78);
            this.txtProfileBio.TabIndex = 8;
            // 
            // btnAddBuddy
            // 
            this.btnAddBuddy.Location = new System.Drawing.Point(324, 12);
            this.btnAddBuddy.Name = "btnAddBuddy";
            this.btnAddBuddy.Size = new System.Drawing.Size(75, 23);
            this.btnAddBuddy.TabIndex = 10;
            this.btnAddBuddy.Text = "Add Buddy";
            this.btnAddBuddy.UseVisualStyleBackColor = true;
            // 
            // btnSendPM
            // 
            this.btnSendPM.Location = new System.Drawing.Point(405, 12);
            this.btnSendPM.Name = "btnSendPM";
            this.btnSendPM.Size = new System.Drawing.Size(75, 23);
            this.btnSendPM.TabIndex = 11;
            this.btnSendPM.Text = "Send PM...";
            this.btnSendPM.UseVisualStyleBackColor = true;
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(486, 12);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 23);
            this.btnBlock.TabIndex = 12;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // pnlModeratorOptions
            // 
            this.pnlModeratorOptions.Controls.Add(this.lblModeratorOptions);
            this.pnlModeratorOptions.Controls.Add(this.chkCanPublish);
            this.pnlModeratorOptions.Controls.Add(this.chkCanChat);
            this.pnlModeratorOptions.Controls.Add(this.btnBanAccount);
            this.pnlModeratorOptions.Location = new System.Drawing.Point(312, 119);
            this.pnlModeratorOptions.Name = "pnlModeratorOptions";
            this.pnlModeratorOptions.Size = new System.Drawing.Size(245, 73);
            this.pnlModeratorOptions.TabIndex = 13;
            // 
            // lblModeratorOptions
            // 
            this.lblModeratorOptions.AutoSize = true;
            this.lblModeratorOptions.Location = new System.Drawing.Point(3, 8);
            this.lblModeratorOptions.Name = "lblModeratorOptions";
            this.lblModeratorOptions.Size = new System.Drawing.Size(97, 13);
            this.lblModeratorOptions.TabIndex = 3;
            this.lblModeratorOptions.Text = "Moderator Options:";
            // 
            // chkCanPublish
            // 
            this.chkCanPublish.AutoSize = true;
            this.chkCanPublish.Location = new System.Drawing.Point(0, 47);
            this.chkCanPublish.Name = "chkCanPublish";
            this.chkCanPublish.Size = new System.Drawing.Size(82, 17);
            this.chkCanPublish.TabIndex = 1;
            this.chkCanPublish.Text = "Can Publish";
            this.chkCanPublish.UseVisualStyleBackColor = true;
            this.chkCanPublish.CheckedChanged += new System.EventHandler(this.ChkCanPublish_CheckedChanged);
            // 
            // chkCanChat
            // 
            this.chkCanChat.AutoSize = true;
            this.chkCanChat.Location = new System.Drawing.Point(0, 24);
            this.chkCanChat.Name = "chkCanChat";
            this.chkCanChat.Size = new System.Drawing.Size(70, 17);
            this.chkCanChat.TabIndex = 1;
            this.chkCanChat.Text = "Can Chat";
            this.chkCanChat.UseVisualStyleBackColor = true;
            this.chkCanChat.CheckedChanged += new System.EventHandler(this.ChkCanChat_CheckedChanged);
            // 
            // btnBanAccount
            // 
            this.btnBanAccount.Location = new System.Drawing.Point(149, 37);
            this.btnBanAccount.Name = "btnBanAccount";
            this.btnBanAccount.Size = new System.Drawing.Size(91, 23);
            this.btnBanAccount.TabIndex = 0;
            this.btnBanAccount.Text = "Ban Account...";
            this.btnBanAccount.UseVisualStyleBackColor = true;
            this.btnBanAccount.Click += new System.EventHandler(this.BtnBanAccount_Click);
            // 
            // pnlProfileErrorOverlay
            // 
            this.pnlProfileErrorOverlay.Controls.Add(this.txtDisplayName);
            this.pnlProfileErrorOverlay.Controls.Add(this.btnSaveChanges);
            this.pnlProfileErrorOverlay.Controls.Add(this.btnEditProfile);
            this.pnlProfileErrorOverlay.Controls.Add(this.lblProfileError);
            this.pnlProfileErrorOverlay.Location = new System.Drawing.Point(3, 2);
            this.pnlProfileErrorOverlay.Name = "pnlProfileErrorOverlay";
            this.pnlProfileErrorOverlay.Size = new System.Drawing.Size(558, 288);
            this.pnlProfileErrorOverlay.TabIndex = 14;
            // 
            // lblProfileError
            // 
            this.lblProfileError.AutoSize = true;
            this.lblProfileError.Location = new System.Drawing.Point(90, 20);
            this.lblProfileError.Name = "lblProfileError";
            this.lblProfileError.Size = new System.Drawing.Size(165, 13);
            this.lblProfileError.TabIndex = 0;
            this.lblProfileError.Text = "No account with this name exists.";
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(463, 10);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(91, 23);
            this.btnEditProfile.TabIndex = 2;
            this.btnEditProfile.Text = "Edit Profile...";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(486, 296);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(448, 10);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(106, 23);
            this.btnSaveChanges.TabIndex = 3;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(93, 24);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(91, 20);
            this.txtDisplayName.TabIndex = 15;
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 324);
            this.Controls.Add(this.picProfileImage);
            this.Controls.Add(this.pnlModeratorOptions);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnSendPM);
            this.Controls.Add(this.btnAddBuddy);
            this.Controls.Add(this.txtProfileBio);
            this.Controls.Add(this.lblProfileBio);
            this.Controls.Add(this.lblLastLoginDate);
            this.Controls.Add(this.lblAccountCreationDate);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblAccountInfo);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.pnlProfileErrorOverlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProfile";
            this.Text = "frmProfile";
            this.Load += new System.EventHandler(this.FrmProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).EndInit();
            this.pnlModeratorOptions.ResumeLayout(false);
            this.pnlModeratorOptions.PerformLayout();
            this.pnlProfileErrorOverlay.ResumeLayout(false);
            this.pnlProfileErrorOverlay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picProfileImage;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblAccountCreationDate;
        private System.Windows.Forms.Label lblLastLoginDate;
        private System.Windows.Forms.Label lblProfileBio;
        private System.Windows.Forms.TextBox txtProfileBio;
        private System.Windows.Forms.Button btnAddBuddy;
        private System.Windows.Forms.Button btnSendPM;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Panel pnlModeratorOptions;
        private System.Windows.Forms.Label lblModeratorOptions;
        private System.Windows.Forms.CheckBox chkCanPublish;
        private System.Windows.Forms.CheckBox chkCanChat;
        private System.Windows.Forms.Button btnBanAccount;
        private System.Windows.Forms.Panel pnlProfileErrorOverlay;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Label lblProfileError;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.TextBox txtDisplayName;
    }
}