namespace Acadiverse_Admin_Panel
{
    partial class FrmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabAccounts = new System.Windows.Forms.TabPage();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.lblAccounts = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchAccounts = new System.Windows.Forms.TextBox();
            this.lstAccounts = new System.Windows.Forms.ListBox();
            this.prgSelectedAccountProperties = new System.Windows.Forms.PropertyGrid();
            this.tabChats = new System.Windows.Forms.TabPage();
            this.btnDeleteChat = new System.Windows.Forms.Button();
            this.btnCreateChat = new System.Windows.Forms.Button();
            this.prgSelectedChat = new System.Windows.Forms.PropertyGrid();
            this.btnSearchChats = new System.Windows.Forms.Button();
            this.txtSearchChats = new System.Windows.Forms.TextBox();
            this.lstChats = new System.Windows.Forms.ListBox();
            this.tabUserRoles = new System.Windows.Forms.TabPage();
            this.lstUserRoles = new System.Windows.Forms.ListBox();
            this.btnAddUserRole = new System.Windows.Forms.Button();
            this.lblAssociatedUsers = new System.Windows.Forms.Label();
            this.lstAssociatedUsers = new System.Windows.Forms.ListBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabAccounts.SuspendLayout();
            this.tabChats.SuspendLayout();
            this.tabUserRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabAccounts);
            this.tabMain.Controls.Add(this.tabChats);
            this.tabMain.Controls.Add(this.tabUserRoles);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(864, 508);
            this.tabMain.TabIndex = 0;
            // 
            // tabAccounts
            // 
            this.tabAccounts.Controls.Add(this.btnDeleteAccount);
            this.tabAccounts.Controls.Add(this.btnCreateAccount);
            this.tabAccounts.Controls.Add(this.btnRefreshList);
            this.tabAccounts.Controls.Add(this.lblAccounts);
            this.tabAccounts.Controls.Add(this.btnSearch);
            this.tabAccounts.Controls.Add(this.txtSearchAccounts);
            this.tabAccounts.Controls.Add(this.lstAccounts);
            this.tabAccounts.Controls.Add(this.prgSelectedAccountProperties);
            this.tabAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabAccounts.Name = "tabAccounts";
            this.tabAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccounts.Size = new System.Drawing.Size(856, 482);
            this.tabAccounts.TabIndex = 0;
            this.tabAccounts.Text = "Accounts";
            this.tabAccounts.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAccount.Location = new System.Drawing.Point(234, 451);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(158, 23);
            this.btnDeleteAccount.TabIndex = 7;
            this.btnDeleteAccount.Text = "Delete Account...";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.BtnDeleteAccount_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateAccount.Location = new System.Drawing.Point(234, 416);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(158, 23);
            this.btnCreateAccount.TabIndex = 6;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = true;
            this.btnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(0, 453);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(217, 23);
            this.btnRefreshList.TabIndex = 5;
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.BtnRefreshList_Click);
            // 
            // lblAccounts
            // 
            this.lblAccounts.AutoSize = true;
            this.lblAccounts.Location = new System.Drawing.Point(3, 3);
            this.lblAccounts.Name = "lblAccounts";
            this.lblAccounts.Size = new System.Drawing.Size(55, 13);
            this.lblAccounts.TabIndex = 4;
            this.lblAccounts.Text = "Accounts:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(142, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchAccounts
            // 
            this.txtSearchAccounts.Location = new System.Drawing.Point(3, 19);
            this.txtSearchAccounts.Name = "txtSearchAccounts";
            this.txtSearchAccounts.Size = new System.Drawing.Size(133, 20);
            this.txtSearchAccounts.TabIndex = 2;
            // 
            // lstAccounts
            // 
            this.lstAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstAccounts.FormattingEnabled = true;
            this.lstAccounts.Location = new System.Drawing.Point(3, 45);
            this.lstAccounts.Name = "lstAccounts";
            this.lstAccounts.Size = new System.Drawing.Size(214, 394);
            this.lstAccounts.TabIndex = 1;
            this.lstAccounts.SelectedIndexChanged += new System.EventHandler(this.LstAccounts_SelectedIndexChanged);
            // 
            // prgSelectedAccountProperties
            // 
            this.prgSelectedAccountProperties.Dock = System.Windows.Forms.DockStyle.Right;
            this.prgSelectedAccountProperties.Location = new System.Drawing.Point(600, 3);
            this.prgSelectedAccountProperties.Name = "prgSelectedAccountProperties";
            this.prgSelectedAccountProperties.Size = new System.Drawing.Size(253, 476);
            this.prgSelectedAccountProperties.TabIndex = 0;
            this.prgSelectedAccountProperties.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PrgSelectedAccountProperties_PropertyValueChanged);
            // 
            // tabChats
            // 
            this.tabChats.Controls.Add(this.btnDeleteChat);
            this.tabChats.Controls.Add(this.btnCreateChat);
            this.tabChats.Controls.Add(this.prgSelectedChat);
            this.tabChats.Controls.Add(this.btnSearchChats);
            this.tabChats.Controls.Add(this.txtSearchChats);
            this.tabChats.Controls.Add(this.lstChats);
            this.tabChats.Location = new System.Drawing.Point(4, 22);
            this.tabChats.Name = "tabChats";
            this.tabChats.Padding = new System.Windows.Forms.Padding(3);
            this.tabChats.Size = new System.Drawing.Size(856, 482);
            this.tabChats.TabIndex = 1;
            this.tabChats.Text = "Chats";
            this.tabChats.UseVisualStyleBackColor = true;
            // 
            // btnDeleteChat
            // 
            this.btnDeleteChat.Location = new System.Drawing.Point(229, 448);
            this.btnDeleteChat.Name = "btnDeleteChat";
            this.btnDeleteChat.Size = new System.Drawing.Size(124, 23);
            this.btnDeleteChat.TabIndex = 5;
            this.btnDeleteChat.Text = "Delete Chat...";
            this.btnDeleteChat.UseVisualStyleBackColor = true;
            this.btnDeleteChat.Click += new System.EventHandler(this.BtnDeleteChat_Click);
            // 
            // btnCreateChat
            // 
            this.btnCreateChat.Location = new System.Drawing.Point(229, 419);
            this.btnCreateChat.Name = "btnCreateChat";
            this.btnCreateChat.Size = new System.Drawing.Size(124, 23);
            this.btnCreateChat.TabIndex = 4;
            this.btnCreateChat.Text = "Create Chat";
            this.btnCreateChat.UseVisualStyleBackColor = true;
            this.btnCreateChat.Click += new System.EventHandler(this.BtnCreateChat_Click);
            // 
            // prgSelectedChat
            // 
            this.prgSelectedChat.Dock = System.Windows.Forms.DockStyle.Right;
            this.prgSelectedChat.Location = new System.Drawing.Point(573, 3);
            this.prgSelectedChat.Name = "prgSelectedChat";
            this.prgSelectedChat.Size = new System.Drawing.Size(280, 476);
            this.prgSelectedChat.TabIndex = 3;
            // 
            // btnSearchChats
            // 
            this.btnSearchChats.Location = new System.Drawing.Point(148, 3);
            this.btnSearchChats.Name = "btnSearchChats";
            this.btnSearchChats.Size = new System.Drawing.Size(75, 23);
            this.btnSearchChats.TabIndex = 2;
            this.btnSearchChats.Text = "Search";
            this.btnSearchChats.UseVisualStyleBackColor = true;
            // 
            // txtSearchChats
            // 
            this.txtSearchChats.Location = new System.Drawing.Point(3, 6);
            this.txtSearchChats.Name = "txtSearchChats";
            this.txtSearchChats.Size = new System.Drawing.Size(137, 20);
            this.txtSearchChats.TabIndex = 1;
            // 
            // lstChats
            // 
            this.lstChats.FormattingEnabled = true;
            this.lstChats.Location = new System.Drawing.Point(3, 29);
            this.lstChats.Name = "lstChats";
            this.lstChats.Size = new System.Drawing.Size(220, 446);
            this.lstChats.TabIndex = 0;
            this.lstChats.SelectedIndexChanged += new System.EventHandler(this.LstChats_SelectedIndexChanged);
            // 
            // tabUserRoles
            // 
            this.tabUserRoles.Controls.Add(this.btnAddUser);
            this.tabUserRoles.Controls.Add(this.lstAssociatedUsers);
            this.tabUserRoles.Controls.Add(this.lblAssociatedUsers);
            this.tabUserRoles.Controls.Add(this.btnAddUserRole);
            this.tabUserRoles.Controls.Add(this.lstUserRoles);
            this.tabUserRoles.Location = new System.Drawing.Point(4, 22);
            this.tabUserRoles.Name = "tabUserRoles";
            this.tabUserRoles.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserRoles.Size = new System.Drawing.Size(856, 482);
            this.tabUserRoles.TabIndex = 2;
            this.tabUserRoles.Text = "User Roles";
            this.tabUserRoles.UseVisualStyleBackColor = true;
            // 
            // lstUserRoles
            // 
            this.lstUserRoles.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstUserRoles.FormattingEnabled = true;
            this.lstUserRoles.Location = new System.Drawing.Point(3, 3);
            this.lstUserRoles.Name = "lstUserRoles";
            this.lstUserRoles.Size = new System.Drawing.Size(161, 476);
            this.lstUserRoles.TabIndex = 0;
            this.lstUserRoles.SelectedIndexChanged += new System.EventHandler(this.LstUserRoles_SelectedIndexChanged);
            // 
            // btnAddUserRole
            // 
            this.btnAddUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddUserRole.Location = new System.Drawing.Point(170, 451);
            this.btnAddUserRole.Name = "btnAddUserRole";
            this.btnAddUserRole.Size = new System.Drawing.Size(146, 23);
            this.btnAddUserRole.TabIndex = 1;
            this.btnAddUserRole.Text = "Add User Role...";
            this.btnAddUserRole.UseVisualStyleBackColor = true;
            this.btnAddUserRole.Click += new System.EventHandler(this.BtnAddUserRole_Click);
            // 
            // lblAssociatedUsers
            // 
            this.lblAssociatedUsers.AutoSize = true;
            this.lblAssociatedUsers.Location = new System.Drawing.Point(167, 3);
            this.lblAssociatedUsers.Name = "lblAssociatedUsers";
            this.lblAssociatedUsers.Size = new System.Drawing.Size(95, 13);
            this.lblAssociatedUsers.TabIndex = 2;
            this.lblAssociatedUsers.Text = "Associated Users::";
            // 
            // lstAssociatedUsers
            // 
            this.lstAssociatedUsers.FormattingEnabled = true;
            this.lstAssociatedUsers.Location = new System.Drawing.Point(169, 19);
            this.lstAssociatedUsers.Name = "lstAssociatedUsers";
            this.lstAssociatedUsers.Size = new System.Drawing.Size(147, 420);
            this.lstAssociatedUsers.TabIndex = 3;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(322, 19);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(108, 23);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User...";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 508);
            this.Controls.Add(this.tabMain);
            this.Name = "frmMain";
            this.Text = "Acadiverse Admin Panel";
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.tabMain.ResumeLayout(false);
            this.tabAccounts.ResumeLayout(false);
            this.tabAccounts.PerformLayout();
            this.tabChats.ResumeLayout(false);
            this.tabChats.PerformLayout();
            this.tabUserRoles.ResumeLayout(false);
            this.tabUserRoles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabAccounts;
        private System.Windows.Forms.TabPage tabChats;
        private System.Windows.Forms.ListBox lstAccounts;
        private System.Windows.Forms.PropertyGrid prgSelectedAccountProperties;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchAccounts;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Label lblAccounts;
        private System.Windows.Forms.PropertyGrid prgSelectedChat;
        private System.Windows.Forms.Button btnSearchChats;
        private System.Windows.Forms.TextBox txtSearchChats;
        private System.Windows.Forms.ListBox lstChats;
        private System.Windows.Forms.Button btnCreateAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnCreateChat;
        private System.Windows.Forms.Button btnDeleteChat;
        private System.Windows.Forms.TabPage tabUserRoles;
        private System.Windows.Forms.Button btnAddUserRole;
        private System.Windows.Forms.ListBox lstUserRoles;
        private System.Windows.Forms.ListBox lstAssociatedUsers;
        private System.Windows.Forms.Label lblAssociatedUsers;
        private System.Windows.Forms.Button btnAddUser;
    }
}

