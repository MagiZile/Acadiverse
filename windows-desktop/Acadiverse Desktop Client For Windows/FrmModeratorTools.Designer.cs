namespace AcadiverseDesktop
{
    partial class FrmModeratorTools
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModeratorTools));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.btnViewInfractionHistory = new System.Windows.Forms.Button();
            this.btnSendPM = new System.Windows.Forms.Button();
            this.btnBanAccount = new System.Windows.Forms.Button();
            this.btnWarnUser = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.txtProfileBio = new System.Windows.Forms.TextBox();
            this.lblProfileBio = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.lblProfileNote = new System.Windows.Forms.Label();
            this.grpPrivileges = new System.Windows.Forms.GroupBox();
            this.chkCanPublish = new System.Windows.Forms.CheckBox();
            this.chkCanChat = new System.Windows.Forms.CheckBox();
            this.btnFilterUsers = new System.Windows.Forms.Button();
            this.txtFilterUsers = new System.Windows.Forms.TextBox();
            this.cboFilterUsers = new System.Windows.Forms.ComboBox();
            this.lblFilterUSers = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lvwUsers = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProfileBio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReputationPoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAccountBanned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBanReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tmrUpdateData = new System.Windows.Forms.Timer(this.components);
            this.bgwUpdateData = new System.ComponentModel.BackgroundWorker();
            this.tabMain.SuspendLayout();
            this.tabUsers.SuspendLayout();
            this.grpActions.SuspendLayout();
            this.grpProfile.SuspendLayout();
            this.grpPrivileges.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabUsers);
            this.tabMain.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabMain, "tabMain");
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.grpActions);
            this.tabUsers.Controls.Add(this.btnSaveChanges);
            this.tabUsers.Controls.Add(this.grpProfile);
            this.tabUsers.Controls.Add(this.grpPrivileges);
            this.tabUsers.Controls.Add(this.btnFilterUsers);
            this.tabUsers.Controls.Add(this.txtFilterUsers);
            this.tabUsers.Controls.Add(this.cboFilterUsers);
            this.tabUsers.Controls.Add(this.lblFilterUSers);
            this.tabUsers.Controls.Add(this.lblUsername);
            this.tabUsers.Controls.Add(this.lvwUsers);
            resources.ApplyResources(this.tabUsers, "tabUsers");
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // grpActions
            // 
            resources.ApplyResources(this.grpActions, "grpActions");
            this.grpActions.Controls.Add(this.btnViewInfractionHistory);
            this.grpActions.Controls.Add(this.btnSendPM);
            this.grpActions.Controls.Add(this.btnBanAccount);
            this.grpActions.Controls.Add(this.btnWarnUser);
            this.grpActions.Name = "grpActions";
            this.grpActions.TabStop = false;
            // 
            // btnViewInfractionHistory
            // 
            resources.ApplyResources(this.btnViewInfractionHistory, "btnViewInfractionHistory");
            this.btnViewInfractionHistory.Name = "btnViewInfractionHistory";
            this.btnViewInfractionHistory.UseVisualStyleBackColor = true;
            this.btnViewInfractionHistory.Click += new System.EventHandler(this.BtnViewInfractionHistory_Click);
            // 
            // btnSendPM
            // 
            resources.ApplyResources(this.btnSendPM, "btnSendPM");
            this.btnSendPM.Name = "btnSendPM";
            this.btnSendPM.UseVisualStyleBackColor = true;
            this.btnSendPM.Click += new System.EventHandler(this.BtnSendPM_Click);
            // 
            // btnBanAccount
            // 
            resources.ApplyResources(this.btnBanAccount, "btnBanAccount");
            this.btnBanAccount.Name = "btnBanAccount";
            this.btnBanAccount.UseVisualStyleBackColor = true;
            this.btnBanAccount.Click += new System.EventHandler(this.BtnBanAccount_Click);
            // 
            // btnWarnUser
            // 
            resources.ApplyResources(this.btnWarnUser, "btnWarnUser");
            this.btnWarnUser.Name = "btnWarnUser";
            this.btnWarnUser.UseVisualStyleBackColor = true;
            this.btnWarnUser.Click += new System.EventHandler(this.BtnWarnUser_Click);
            // 
            // btnSaveChanges
            // 
            resources.ApplyResources(this.btnSaveChanges, "btnSaveChanges");
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // grpProfile
            // 
            resources.ApplyResources(this.grpProfile, "grpProfile");
            this.grpProfile.Controls.Add(this.txtProfileBio);
            this.grpProfile.Controls.Add(this.lblProfileBio);
            this.grpProfile.Controls.Add(this.lblDisplayName);
            this.grpProfile.Controls.Add(this.txtDisplayName);
            this.grpProfile.Controls.Add(this.lblProfileNote);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.TabStop = false;
            // 
            // txtProfileBio
            // 
            resources.ApplyResources(this.txtProfileBio, "txtProfileBio");
            this.txtProfileBio.Name = "txtProfileBio";
            // 
            // lblProfileBio
            // 
            resources.ApplyResources(this.lblProfileBio, "lblProfileBio");
            this.lblProfileBio.Name = "lblProfileBio";
            // 
            // lblDisplayName
            // 
            resources.ApplyResources(this.lblDisplayName, "lblDisplayName");
            this.lblDisplayName.Name = "lblDisplayName";
            // 
            // txtDisplayName
            // 
            resources.ApplyResources(this.txtDisplayName, "txtDisplayName");
            this.txtDisplayName.Name = "txtDisplayName";
            // 
            // lblProfileNote
            // 
            resources.ApplyResources(this.lblProfileNote, "lblProfileNote");
            this.lblProfileNote.Name = "lblProfileNote";
            // 
            // grpPrivileges
            // 
            resources.ApplyResources(this.grpPrivileges, "grpPrivileges");
            this.grpPrivileges.Controls.Add(this.chkCanPublish);
            this.grpPrivileges.Controls.Add(this.chkCanChat);
            this.grpPrivileges.Name = "grpPrivileges";
            this.grpPrivileges.TabStop = false;
            // 
            // chkCanPublish
            // 
            resources.ApplyResources(this.chkCanPublish, "chkCanPublish");
            this.chkCanPublish.Name = "chkCanPublish";
            this.chkCanPublish.UseVisualStyleBackColor = true;
            this.chkCanPublish.CheckedChanged += new System.EventHandler(this.ChkCanPublish_CheckedChanged);
            // 
            // chkCanChat
            // 
            resources.ApplyResources(this.chkCanChat, "chkCanChat");
            this.chkCanChat.Name = "chkCanChat";
            this.chkCanChat.UseVisualStyleBackColor = true;
            this.chkCanChat.CheckedChanged += new System.EventHandler(this.ChkCanChat_CheckedChanged);
            // 
            // btnFilterUsers
            // 
            resources.ApplyResources(this.btnFilterUsers, "btnFilterUsers");
            this.btnFilterUsers.Name = "btnFilterUsers";
            this.btnFilterUsers.UseVisualStyleBackColor = true;
            // 
            // txtFilterUsers
            // 
            resources.ApplyResources(this.txtFilterUsers, "txtFilterUsers");
            this.txtFilterUsers.Name = "txtFilterUsers";
            // 
            // cboFilterUsers
            // 
            this.cboFilterUsers.FormattingEnabled = true;
            this.cboFilterUsers.Items.AddRange(new object[] {
            resources.GetString("cboFilterUsers.Items"),
            resources.GetString("cboFilterUsers.Items1"),
            resources.GetString("cboFilterUsers.Items2"),
            resources.GetString("cboFilterUsers.Items3"),
            resources.GetString("cboFilterUsers.Items4")});
            resources.ApplyResources(this.cboFilterUsers, "cboFilterUsers");
            this.cboFilterUsers.Name = "cboFilterUsers";
            // 
            // lblFilterUSers
            // 
            resources.ApplyResources(this.lblFilterUSers, "lblFilterUSers");
            this.lblFilterUSers.Name = "lblFilterUSers";
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.Name = "lblUsername";
            // 
            // lvwUsers
            // 
            resources.ApplyResources(this.lvwUsers, "lvwUsers");
            this.lvwUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colUsername,
            this.colProfileBio,
            this.colReputationPoints,
            this.colMoney,
            this.colAccountBanned,
            this.colBanReason});
            this.lvwUsers.HideSelection = false;
            this.lvwUsers.Name = "lvwUsers";
            this.lvwUsers.UseCompatibleStateImageBehavior = false;
            this.lvwUsers.View = System.Windows.Forms.View.Details;
            this.lvwUsers.SelectedIndexChanged += new System.EventHandler(this.LvwUsers_SelectedIndexChanged);
            // 
            // colID
            // 
            resources.ApplyResources(this.colID, "colID");
            // 
            // colUsername
            // 
            resources.ApplyResources(this.colUsername, "colUsername");
            // 
            // colProfileBio
            // 
            resources.ApplyResources(this.colProfileBio, "colProfileBio");
            // 
            // colReputationPoints
            // 
            resources.ApplyResources(this.colReputationPoints, "colReputationPoints");
            // 
            // colMoney
            // 
            resources.ApplyResources(this.colMoney, "colMoney");
            // 
            // colAccountBanned
            // 
            resources.ApplyResources(this.colAccountBanned, "colAccountBanned");
            // 
            // colBanReason
            // 
            resources.ApplyResources(this.colBanReason, "colBanReason");
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tmrUpdateData
            // 
            this.tmrUpdateData.Interval = 1000;
            // 
            // bgwUpdateData
            // 
            this.bgwUpdateData.WorkerReportsProgress = true;
            // 
            // FrmModeratorTools
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabMain);
            this.Name = "FrmModeratorTools";
            this.Load += new System.EventHandler(this.FrmModeratorTools_Load);
            this.tabMain.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            this.grpActions.ResumeLayout(false);
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            this.grpPrivileges.ResumeLayout(false);
            this.grpPrivileges.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnSendPM;
        private System.Windows.Forms.Button btnBanAccount;
        private System.Windows.Forms.Button btnWarnUser;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.TextBox txtProfileBio;
        private System.Windows.Forms.Label lblProfileBio;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label lblProfileNote;
        private System.Windows.Forms.GroupBox grpPrivileges;
        private System.Windows.Forms.CheckBox chkCanPublish;
        private System.Windows.Forms.CheckBox chkCanChat;
        private System.Windows.Forms.Button btnFilterUsers;
        private System.Windows.Forms.TextBox txtFilterUsers;
        private System.Windows.Forms.ComboBox cboFilterUsers;
        private System.Windows.Forms.Label lblFilterUSers;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ListView lvwUsers;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colProfileBio;
        private System.Windows.Forms.ColumnHeader colReputationPoints;
        private System.Windows.Forms.ColumnHeader colMoney;
        private System.Windows.Forms.ColumnHeader colAccountBanned;
        private System.Windows.Forms.ColumnHeader colBanReason;
        private System.Windows.Forms.Timer tmrUpdateData;
        private System.ComponentModel.BackgroundWorker bgwUpdateData;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.Button btnViewInfractionHistory;
    }
}