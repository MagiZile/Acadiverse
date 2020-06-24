namespace AcadiverseDesktop
{
    partial class FrmAcadiverseDesktopClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAcadiverseDesktopClient));
            this.webAcadiversNews = new System.Windows.Forms.WebBrowser();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.btnLaunchAcadiverse = new System.Windows.Forms.Button();
            this.btnLaunchAcadiverseLessonStudio = new System.Windows.Forms.Button();
            this.nocNotifications = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotifications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openAcadiverseDesktopClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.pMsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSumbissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageSubmissionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.logOUtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrServerUpdatesTimer = new System.Windows.Forms.Timer(this.components);
            this.bgwAccountSynchronization = new System.ComponentModel.BackgroundWorker();
            this.btnModeratorTools = new System.Windows.Forms.Button();
            this.tabAcadiverseStore = new System.Windows.Forms.TabPage();
            this.btnSearchAcadiverseStore = new System.Windows.Forms.Button();
            this.txtSearchAcadiverseStore = new System.Windows.Forms.TextBox();
            this.tabBuddies = new System.Windows.Forms.TabPage();
            this.tabChat = new System.Windows.Forms.TabPage();
            this.btnRefreshChats = new System.Windows.Forms.Button();
            this.flpChats = new System.Windows.Forms.FlowLayoutPanel();
            this.tabContent = new System.Windows.Forms.TabControl();
            this.babSubmissions = new System.Windows.Forms.TabPage();
            this.cboSortSubmissions = new System.Windows.Forms.ComboBox();
            this.lblSortSubmission = new System.Windows.Forms.Label();
            this.btnSearchSubmissions = new System.Windows.Forms.Button();
            this.flpSubmissionss = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchSubmissions = new System.Windows.Forms.TextBox();
            this.tabItems = new System.Windows.Forms.TabPage();
            this.tabAccountSettings = new System.Windows.Forms.TabPage();
            this.grpDangerousActions = new System.Windows.Forms.GroupBox();
            this.lblDangerousActionsWarning = new System.Windows.Forms.Label();
            this.btnClearAllData = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.grpPMsAndBlocking = new System.Windows.Forms.GroupBox();
            this.chkReceivesPMs = new System.Windows.Forms.CheckBox();
            this.btnManageBlockedUsers = new System.Windows.Forms.Button();
            this.grpNotifications = new System.Windows.Forms.GroupBox();
            this.lblNotifications = new System.Windows.Forms.Label();
            this.chkNotifyPMReceived = new System.Windows.Forms.CheckBox();
            this.chkNotifySubmissionComment = new System.Windows.Forms.CheckBox();
            this.chkNotifySumbissionFeatured = new System.Windows.Forms.CheckBox();
            this.chkNotifySubmissionUpvote = new System.Windows.Forms.CheckBox();
            this.chkNotifyMentioned = new System.Windows.Forms.CheckBox();
            this.chkNotifyAcheivementReceived = new System.Windows.Forms.CheckBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiaplayName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bgwChatUpdates = new System.ComponentModel.BackgroundWorker();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.picProfileImage = new System.Windows.Forms.PictureBox();
            this.cmsNotifications.SuspendLayout();
            this.tabAcadiverseStore.SuspendLayout();
            this.tabChat.SuspendLayout();
            this.tabContent.SuspendLayout();
            this.babSubmissions.SuspendLayout();
            this.tabAccountSettings.SuspendLayout();
            this.grpDangerousActions.SuspendLayout();
            this.grpPMsAndBlocking.SuspendLayout();
            this.grpNotifications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // webAcadiversNews
            // 
            resources.ApplyResources(this.webAcadiversNews, "webAcadiversNews");
            this.webAcadiversNews.Name = "webAcadiversNews";
            this.webAcadiversNews.Url = new System.Uri("http://acadiverse.magizile.com/acadiversedesktop/news.html", System.UriKind.Absolute);
            // 
            // btnLogout
            // 
            resources.ApplyResources(this.btnLogout, "btnLogout");
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // lblLoggedInUser
            // 
            resources.ApplyResources(this.lblLoggedInUser, "lblLoggedInUser");
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            // 
            // lblAccountInfo
            // 
            resources.ApplyResources(this.lblAccountInfo, "lblAccountInfo");
            this.lblAccountInfo.Name = "lblAccountInfo";
            // 
            // btnLaunchAcadiverse
            // 
            resources.ApplyResources(this.btnLaunchAcadiverse, "btnLaunchAcadiverse");
            this.btnLaunchAcadiverse.Name = "btnLaunchAcadiverse";
            this.btnLaunchAcadiverse.UseVisualStyleBackColor = true;
            this.btnLaunchAcadiverse.Click += new System.EventHandler(this.BtnLaunchAcadiverse_Click);
            // 
            // btnLaunchAcadiverseLessonStudio
            // 
            resources.ApplyResources(this.btnLaunchAcadiverseLessonStudio, "btnLaunchAcadiverseLessonStudio");
            this.btnLaunchAcadiverseLessonStudio.Name = "btnLaunchAcadiverseLessonStudio";
            this.btnLaunchAcadiverseLessonStudio.UseVisualStyleBackColor = true;
            this.btnLaunchAcadiverseLessonStudio.Click += new System.EventHandler(this.BtnLaunchAcadiverseLessonStudio_Click);
            // 
            // nocNotifications
            // 
            this.nocNotifications.ContextMenuStrip = this.cmsNotifications;
            resources.ApplyResources(this.nocNotifications, "nocNotifications");
            // 
            // cmsNotifications
            // 
            this.cmsNotifications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAcadiverseDesktopClientToolStripMenuItem,
            this.toolStripMenuItem1,
            this.pMsToolStripMenuItem,
            this.viewSumbissionsToolStripMenuItem,
            this.manageSubmissionsToolStripMenuItem,
            this.browseContentToolStripMenuItem,
            this.toolStripMenuItem2,
            this.logOUtToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cmsNotifications.Name = "cmsNotifications";
            resources.ApplyResources(this.cmsNotifications, "cmsNotifications");
            // 
            // openAcadiverseDesktopClientToolStripMenuItem
            // 
            this.openAcadiverseDesktopClientToolStripMenuItem.Name = "openAcadiverseDesktopClientToolStripMenuItem";
            resources.ApplyResources(this.openAcadiverseDesktopClientToolStripMenuItem, "openAcadiverseDesktopClientToolStripMenuItem");
            this.openAcadiverseDesktopClientToolStripMenuItem.Click += new System.EventHandler(this.OpenAcadiverseDesktopClientToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // pMsToolStripMenuItem
            // 
            this.pMsToolStripMenuItem.Name = "pMsToolStripMenuItem";
            resources.ApplyResources(this.pMsToolStripMenuItem, "pMsToolStripMenuItem");
            // 
            // viewSumbissionsToolStripMenuItem
            // 
            this.viewSumbissionsToolStripMenuItem.Name = "viewSumbissionsToolStripMenuItem";
            resources.ApplyResources(this.viewSumbissionsToolStripMenuItem, "viewSumbissionsToolStripMenuItem");
            // 
            // manageSubmissionsToolStripMenuItem
            // 
            this.manageSubmissionsToolStripMenuItem.Name = "manageSubmissionsToolStripMenuItem";
            resources.ApplyResources(this.manageSubmissionsToolStripMenuItem, "manageSubmissionsToolStripMenuItem");
            // 
            // browseContentToolStripMenuItem
            // 
            this.browseContentToolStripMenuItem.Name = "browseContentToolStripMenuItem";
            resources.ApplyResources(this.browseContentToolStripMenuItem, "browseContentToolStripMenuItem");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // logOUtToolStripMenuItem
            // 
            this.logOUtToolStripMenuItem.Name = "logOUtToolStripMenuItem";
            resources.ApplyResources(this.logOUtToolStripMenuItem, "logOUtToolStripMenuItem");
            this.logOUtToolStripMenuItem.Click += new System.EventHandler(this.LogOUtToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // tmrServerUpdatesTimer
            // 
            this.tmrServerUpdatesTimer.Interval = 250;
            this.tmrServerUpdatesTimer.Tick += new System.EventHandler(this.TmrServerUpdatesTimer_Tick);
            // 
            // btnModeratorTools
            // 
            resources.ApplyResources(this.btnModeratorTools, "btnModeratorTools");
            this.btnModeratorTools.Name = "btnModeratorTools";
            this.btnModeratorTools.UseVisualStyleBackColor = true;
            this.btnModeratorTools.Click += new System.EventHandler(this.BtnModeratorTools_Click);
            // 
            // tabAcadiverseStore
            // 
            this.tabAcadiverseStore.Controls.Add(this.btnSearchAcadiverseStore);
            this.tabAcadiverseStore.Controls.Add(this.txtSearchAcadiverseStore);
            resources.ApplyResources(this.tabAcadiverseStore, "tabAcadiverseStore");
            this.tabAcadiverseStore.Name = "tabAcadiverseStore";
            this.tabAcadiverseStore.UseVisualStyleBackColor = true;
            // 
            // btnSearchAcadiverseStore
            // 
            resources.ApplyResources(this.btnSearchAcadiverseStore, "btnSearchAcadiverseStore");
            this.btnSearchAcadiverseStore.Name = "btnSearchAcadiverseStore";
            this.btnSearchAcadiverseStore.UseVisualStyleBackColor = true;
            // 
            // txtSearchAcadiverseStore
            // 
            resources.ApplyResources(this.txtSearchAcadiverseStore, "txtSearchAcadiverseStore");
            this.txtSearchAcadiverseStore.Name = "txtSearchAcadiverseStore";
            // 
            // tabBuddies
            // 
            resources.ApplyResources(this.tabBuddies, "tabBuddies");
            this.tabBuddies.Name = "tabBuddies";
            this.tabBuddies.UseVisualStyleBackColor = true;
            // 
            // tabChat
            // 
            this.tabChat.Controls.Add(this.btnRefreshChats);
            this.tabChat.Controls.Add(this.flpChats);
            resources.ApplyResources(this.tabChat, "tabChat");
            this.tabChat.Name = "tabChat";
            this.tabChat.UseVisualStyleBackColor = true;
            // 
            // btnRefreshChats
            // 
            resources.ApplyResources(this.btnRefreshChats, "btnRefreshChats");
            this.btnRefreshChats.Name = "btnRefreshChats";
            this.btnRefreshChats.UseVisualStyleBackColor = true;
            this.btnRefreshChats.Click += new System.EventHandler(this.BtnRefreshChats_Click);
            // 
            // flpChats
            // 
            resources.ApplyResources(this.flpChats, "flpChats");
            this.flpChats.Name = "flpChats";
            // 
            // tabContent
            // 
            this.tabContent.Controls.Add(this.tabChat);
            this.tabContent.Controls.Add(this.tabBuddies);
            this.tabContent.Controls.Add(this.babSubmissions);
            this.tabContent.Controls.Add(this.tabAcadiverseStore);
            this.tabContent.Controls.Add(this.tabItems);
            this.tabContent.Controls.Add(this.tabAccountSettings);
            resources.ApplyResources(this.tabContent, "tabContent");
            this.tabContent.Name = "tabContent";
            this.tabContent.SelectedIndex = 0;
            // 
            // babSubmissions
            // 
            this.babSubmissions.Controls.Add(this.cboSortSubmissions);
            this.babSubmissions.Controls.Add(this.lblSortSubmission);
            this.babSubmissions.Controls.Add(this.btnSearchSubmissions);
            this.babSubmissions.Controls.Add(this.flpSubmissionss);
            this.babSubmissions.Controls.Add(this.txtSearchSubmissions);
            resources.ApplyResources(this.babSubmissions, "babSubmissions");
            this.babSubmissions.Name = "babSubmissions";
            this.babSubmissions.UseVisualStyleBackColor = true;
            // 
            // cboSortSubmissions
            // 
            this.cboSortSubmissions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortSubmissions.FormattingEnabled = true;
            this.cboSortSubmissions.Items.AddRange(new object[] {
            resources.GetString("cboSortSubmissions.Items"),
            resources.GetString("cboSortSubmissions.Items1"),
            resources.GetString("cboSortSubmissions.Items2"),
            resources.GetString("cboSortSubmissions.Items3")});
            resources.ApplyResources(this.cboSortSubmissions, "cboSortSubmissions");
            this.cboSortSubmissions.Name = "cboSortSubmissions";
            // 
            // lblSortSubmission
            // 
            resources.ApplyResources(this.lblSortSubmission, "lblSortSubmission");
            this.lblSortSubmission.Name = "lblSortSubmission";
            // 
            // btnSearchSubmissions
            // 
            resources.ApplyResources(this.btnSearchSubmissions, "btnSearchSubmissions");
            this.btnSearchSubmissions.Name = "btnSearchSubmissions";
            this.btnSearchSubmissions.UseVisualStyleBackColor = true;
            // 
            // flpSubmissionss
            // 
            resources.ApplyResources(this.flpSubmissionss, "flpSubmissionss");
            this.flpSubmissionss.Name = "flpSubmissionss";
            // 
            // txtSearchSubmissions
            // 
            resources.ApplyResources(this.txtSearchSubmissions, "txtSearchSubmissions");
            this.txtSearchSubmissions.Name = "txtSearchSubmissions";
            // 
            // tabItems
            // 
            resources.ApplyResources(this.tabItems, "tabItems");
            this.tabItems.Name = "tabItems";
            this.tabItems.UseVisualStyleBackColor = true;
            // 
            // tabAccountSettings
            // 
            resources.ApplyResources(this.tabAccountSettings, "tabAccountSettings");
            this.tabAccountSettings.Controls.Add(this.btnEditProfile);
            this.tabAccountSettings.Controls.Add(this.grpDangerousActions);
            this.tabAccountSettings.Controls.Add(this.grpPMsAndBlocking);
            this.tabAccountSettings.Controls.Add(this.grpNotifications);
            this.tabAccountSettings.Controls.Add(this.btnChangePassword);
            this.tabAccountSettings.Controls.Add(this.lblEmail);
            this.tabAccountSettings.Controls.Add(this.lblDiaplayName);
            this.tabAccountSettings.Controls.Add(this.lblUsername);
            this.tabAccountSettings.Controls.Add(this.textBox1);
            this.tabAccountSettings.Controls.Add(this.txtDisplayName);
            this.tabAccountSettings.Controls.Add(this.txtPassword);
            this.tabAccountSettings.Name = "tabAccountSettings";
            this.tabAccountSettings.UseVisualStyleBackColor = true;
            // 
            // grpDangerousActions
            // 
            this.grpDangerousActions.Controls.Add(this.lblDangerousActionsWarning);
            this.grpDangerousActions.Controls.Add(this.btnClearAllData);
            this.grpDangerousActions.Controls.Add(this.btnDeleteAccount);
            resources.ApplyResources(this.grpDangerousActions, "grpDangerousActions");
            this.grpDangerousActions.Name = "grpDangerousActions";
            this.grpDangerousActions.TabStop = false;
            // 
            // lblDangerousActionsWarning
            // 
            resources.ApplyResources(this.lblDangerousActionsWarning, "lblDangerousActionsWarning");
            this.lblDangerousActionsWarning.ForeColor = System.Drawing.Color.Red;
            this.lblDangerousActionsWarning.Name = "lblDangerousActionsWarning";
            // 
            // btnClearAllData
            // 
            resources.ApplyResources(this.btnClearAllData, "btnClearAllData");
            this.btnClearAllData.Name = "btnClearAllData";
            this.btnClearAllData.UseVisualStyleBackColor = true;
            this.btnClearAllData.Click += new System.EventHandler(this.BtnClearAllData_Click);
            // 
            // btnDeleteAccount
            // 
            resources.ApplyResources(this.btnDeleteAccount, "btnDeleteAccount");
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // grpPMsAndBlocking
            // 
            this.grpPMsAndBlocking.Controls.Add(this.chkReceivesPMs);
            this.grpPMsAndBlocking.Controls.Add(this.btnManageBlockedUsers);
            resources.ApplyResources(this.grpPMsAndBlocking, "grpPMsAndBlocking");
            this.grpPMsAndBlocking.Name = "grpPMsAndBlocking";
            this.grpPMsAndBlocking.TabStop = false;
            // 
            // chkReceivesPMs
            // 
            resources.ApplyResources(this.chkReceivesPMs, "chkReceivesPMs");
            this.chkReceivesPMs.Checked = true;
            this.chkReceivesPMs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReceivesPMs.Name = "chkReceivesPMs";
            this.chkReceivesPMs.UseVisualStyleBackColor = true;
            // 
            // btnManageBlockedUsers
            // 
            resources.ApplyResources(this.btnManageBlockedUsers, "btnManageBlockedUsers");
            this.btnManageBlockedUsers.Name = "btnManageBlockedUsers";
            this.btnManageBlockedUsers.UseVisualStyleBackColor = true;
            // 
            // grpNotifications
            // 
            this.grpNotifications.Controls.Add(this.lblNotifications);
            this.grpNotifications.Controls.Add(this.chkNotifyPMReceived);
            this.grpNotifications.Controls.Add(this.chkNotifySubmissionComment);
            this.grpNotifications.Controls.Add(this.chkNotifySumbissionFeatured);
            this.grpNotifications.Controls.Add(this.chkNotifySubmissionUpvote);
            this.grpNotifications.Controls.Add(this.chkNotifyMentioned);
            this.grpNotifications.Controls.Add(this.chkNotifyAcheivementReceived);
            resources.ApplyResources(this.grpNotifications, "grpNotifications");
            this.grpNotifications.Name = "grpNotifications";
            this.grpNotifications.TabStop = false;
            // 
            // lblNotifications
            // 
            resources.ApplyResources(this.lblNotifications, "lblNotifications");
            this.lblNotifications.Name = "lblNotifications";
            // 
            // chkNotifyPMReceived
            // 
            resources.ApplyResources(this.chkNotifyPMReceived, "chkNotifyPMReceived");
            this.chkNotifyPMReceived.Checked = true;
            this.chkNotifyPMReceived.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotifyPMReceived.Name = "chkNotifyPMReceived";
            this.chkNotifyPMReceived.UseVisualStyleBackColor = true;
            this.chkNotifyPMReceived.CheckedChanged += new System.EventHandler(this.chkNotifyPMReceived_CheckedChanged);
            // 
            // chkNotifySubmissionComment
            // 
            resources.ApplyResources(this.chkNotifySubmissionComment, "chkNotifySubmissionComment");
            this.chkNotifySubmissionComment.Checked = true;
            this.chkNotifySubmissionComment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotifySubmissionComment.Name = "chkNotifySubmissionComment";
            this.chkNotifySubmissionComment.UseVisualStyleBackColor = true;
            this.chkNotifySubmissionComment.CheckedChanged += new System.EventHandler(this.chkNotifySubmissionComment_CheckedChanged);
            // 
            // chkNotifySumbissionFeatured
            // 
            resources.ApplyResources(this.chkNotifySumbissionFeatured, "chkNotifySumbissionFeatured");
            this.chkNotifySumbissionFeatured.Checked = true;
            this.chkNotifySumbissionFeatured.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotifySumbissionFeatured.Name = "chkNotifySumbissionFeatured";
            this.chkNotifySumbissionFeatured.UseVisualStyleBackColor = true;
            this.chkNotifySumbissionFeatured.CheckedChanged += new System.EventHandler(this.chkNotifySumbissionFeatured_CheckedChanged);
            // 
            // chkNotifySubmissionUpvote
            // 
            resources.ApplyResources(this.chkNotifySubmissionUpvote, "chkNotifySubmissionUpvote");
            this.chkNotifySubmissionUpvote.Checked = true;
            this.chkNotifySubmissionUpvote.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotifySubmissionUpvote.Name = "chkNotifySubmissionUpvote";
            this.chkNotifySubmissionUpvote.UseVisualStyleBackColor = true;
            this.chkNotifySubmissionUpvote.CheckedChanged += new System.EventHandler(this.chkNotifySubmissionUpvote_CheckedChanged);
            // 
            // chkNotifyMentioned
            // 
            resources.ApplyResources(this.chkNotifyMentioned, "chkNotifyMentioned");
            this.chkNotifyMentioned.Checked = true;
            this.chkNotifyMentioned.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotifyMentioned.Name = "chkNotifyMentioned";
            this.chkNotifyMentioned.UseVisualStyleBackColor = true;
            this.chkNotifyMentioned.CheckedChanged += new System.EventHandler(this.chkNotifyMentioned_CheckedChanged);
            // 
            // chkNotifyAcheivementReceived
            // 
            resources.ApplyResources(this.chkNotifyAcheivementReceived, "chkNotifyAcheivementReceived");
            this.chkNotifyAcheivementReceived.Checked = true;
            this.chkNotifyAcheivementReceived.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotifyAcheivementReceived.Name = "chkNotifyAcheivementReceived";
            this.chkNotifyAcheivementReceived.UseVisualStyleBackColor = true;
            this.chkNotifyAcheivementReceived.CheckedChanged += new System.EventHandler(this.chkNotifyAcheivementReceived_CheckedChanged);
            // 
            // btnChangePassword
            // 
            resources.ApplyResources(this.btnChangePassword, "btnChangePassword");
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // lblDiaplayName
            // 
            resources.ApplyResources(this.lblDiaplayName, "lblDiaplayName");
            this.lblDiaplayName.Name = "lblDiaplayName";
            // 
            // lblUsername
            // 
            resources.ApplyResources(this.lblUsername, "lblUsername");
            this.lblUsername.Name = "lblUsername";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // txtDisplayName
            // 
            resources.ApplyResources(this.txtDisplayName, "txtDisplayName");
            this.txtDisplayName.Name = "txtDisplayName";
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            // 
            // bgwChatUpdates
            // 
            this.bgwChatUpdates.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwChatUpdates_DoWork);
            // 
            // btnEditProfile
            // 
            resources.ApplyResources(this.btnEditProfile, "btnEditProfile");
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // picProfileImage
            // 
            resources.ApplyResources(this.picProfileImage, "picProfileImage");
            this.picProfileImage.Name = "picProfileImage";
            this.picProfileImage.TabStop = false;
            // 
            // FrmAcadiverseDesktopClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picProfileImage);
            this.Controls.Add(this.tabContent);
            this.Controls.Add(this.btnLaunchAcadiverseLessonStudio);
            this.Controls.Add(this.btnLaunchAcadiverse);
            this.Controls.Add(this.lblAccountInfo);
            this.Controls.Add(this.lblLoggedInUser);
            this.Controls.Add(this.btnModeratorTools);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.webAcadiversNews);
            this.Name = "FrmAcadiverseDesktopClient";
            this.Activated += new System.EventHandler(this.FrmAcadiverseDesktopClient_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAcadiverseLauncher_FormClosing);
            this.Load += new System.EventHandler(this.FrmAcadiverseLauncher_Load);
            this.cmsNotifications.ResumeLayout(false);
            this.tabAcadiverseStore.ResumeLayout(false);
            this.tabAcadiverseStore.PerformLayout();
            this.tabChat.ResumeLayout(false);
            this.tabContent.ResumeLayout(false);
            this.babSubmissions.ResumeLayout(false);
            this.babSubmissions.PerformLayout();
            this.tabAccountSettings.ResumeLayout(false);
            this.tabAccountSettings.PerformLayout();
            this.grpDangerousActions.ResumeLayout(false);
            this.grpDangerousActions.PerformLayout();
            this.grpPMsAndBlocking.ResumeLayout(false);
            this.grpPMsAndBlocking.PerformLayout();
            this.grpNotifications.ResumeLayout(false);
            this.grpNotifications.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webAcadiversNews;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Button btnLaunchAcadiverse;
        private System.Windows.Forms.Button btnLaunchAcadiverseLessonStudio;
        private System.Windows.Forms.NotifyIcon nocNotifications;
        private System.Windows.Forms.Timer tmrServerUpdatesTimer;
        private System.Windows.Forms.ContextMenuStrip cmsNotifications;
        private System.Windows.Forms.ToolStripMenuItem openAcadiverseDesktopClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pMsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSumbissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageSubmissionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem logOUtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker bgwAccountSynchronization;
        private System.Windows.Forms.Button btnModeratorTools;
        private System.Windows.Forms.TabPage tabAcadiverseStore;
        private System.Windows.Forms.TabPage tabBuddies;
        private System.Windows.Forms.TabPage tabChat;
        private System.Windows.Forms.TabControl tabContent;
        private System.Windows.Forms.Button btnSearchAcadiverseStore;
        private System.Windows.Forms.TextBox txtSearchAcadiverseStore;
        private System.Windows.Forms.TabPage babSubmissions;
        private System.Windows.Forms.ComboBox cboSortSubmissions;
        private System.Windows.Forms.Label lblSortSubmission;
        private System.Windows.Forms.Button btnSearchSubmissions;
        private System.Windows.Forms.FlowLayoutPanel flpSubmissionss;
        private System.Windows.Forms.TextBox txtSearchSubmissions;
        private System.Windows.Forms.TabPage tabItems;
        private System.Windows.Forms.TabPage tabAccountSettings;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiaplayName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.CheckBox chkReceivesPMs;
        private System.Windows.Forms.CheckBox chkNotifySumbissionFeatured;
        private System.Windows.Forms.CheckBox chkNotifyMentioned;
        private System.Windows.Forms.CheckBox chkNotifyAcheivementReceived;
        private System.Windows.Forms.CheckBox chkNotifySubmissionUpvote;
        private System.Windows.Forms.CheckBox chkNotifySubmissionComment;
        private System.Windows.Forms.CheckBox chkNotifyPMReceived;
        private System.Windows.Forms.Label lblNotifications;
        private System.Windows.Forms.GroupBox grpNotifications;
        private System.Windows.Forms.Button btnManageBlockedUsers;
        private System.Windows.Forms.GroupBox grpDangerousActions;
        private System.Windows.Forms.Label lblDangerousActionsWarning;
        private System.Windows.Forms.GroupBox grpPMsAndBlocking;
        private System.Windows.Forms.Button btnClearAllData;
        private System.ComponentModel.BackgroundWorker bgwChatUpdates;
        private System.Windows.Forms.FlowLayoutPanel flpChats;
        private System.Windows.Forms.Button btnRefreshChats;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.PictureBox picProfileImage;
    }
}