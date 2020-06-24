namespace MagiZile.CustomUI
{
    partial class FileSelectorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileSelectorControl));
            this.lblImageSize = new System.Windows.Forms.Label();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.sep3 = new System.Windows.Forms.ToolStripSeparator();
            this.tbrMain = new System.Windows.Forms.ToolStrip();
            this.tsbBack = new System.Windows.Forms.ToolStripButton();
            this.tsbForward = new System.Windows.Forms.ToolStripButton();
            this.tsbGoUp = new System.Windows.Forms.ToolStripButton();
            this.tsbCut = new System.Windows.Forms.ToolStripButton();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tslTypePath = new System.Windows.Forms.ToolStripLabel();
            this.tstTypePath = new System.Windows.Forms.ToolStripTextBox();
            this.sep4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tstSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tslSearch = new System.Windows.Forms.ToolStripLabel();
            this.tspLoading = new System.Windows.Forms.ToolStripProgressBar();
            this.pnlBottomPane = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.cboFileType = new System.Windows.Forms.ComboBox();
            this.lblFileType = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.cmuFileListOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.lblPreviewFileType = new System.Windows.Forms.Label();
            this.lblPreview = new System.Windows.Forms.Label();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.imgIcons = new System.Windows.Forms.ImageList(this.components);
            this.imgTreeNodeImages = new System.Windows.Forms.ImageList(this.components);
            this.fswFileUpdater = new System.IO.FileSystemWatcher();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvwFolders = new System.Windows.Forms.TreeView();
            this.spcFileList = new System.Windows.Forms.SplitContainer();
            this.pnlFiles = new System.Windows.Forms.Panel();
            this.lblFolderEmpty = new System.Windows.Forms.Label();
            this.tbrMain.SuspendLayout();
            this.pnlBottomPane.SuspendLayout();
            this.cmuFileListOptions.SuspendLayout();
            this.pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswFileUpdater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spcFileList)).BeginInit();
            this.spcFileList.Panel1.SuspendLayout();
            this.spcFileList.Panel2.SuspendLayout();
            this.spcFileList.SuspendLayout();
            this.pnlFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImageSize
            // 
            this.lblImageSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblImageSize.AutoSize = true;
            this.lblImageSize.Location = new System.Drawing.Point(12, 397);
            this.lblImageSize.Name = "lblImageSize";
            this.lblImageSize.Size = new System.Drawing.Size(62, 13);
            this.lblImageSize.TabIndex = 2;
            this.lblImageSize.Text = "Image Size:";
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 25);
            // 
            // sep3
            // 
            this.sep3.Name = "sep3";
            this.sep3.Size = new System.Drawing.Size(6, 25);
            // 
            // tbrMain
            // 
            this.tbrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBack,
            this.tsbForward,
            this.sep1,
            this.tsbGoUp,
            this.sep2,
            this.tsbCut,
            this.tsbCopy,
            this.tsbPaste,
            this.tsbDelete,
            this.sep3,
            this.tslTypePath,
            this.tstTypePath,
            this.sep4,
            this.tsbSearch,
            this.tstSearch,
            this.tslSearch,
            this.tspLoading});
            this.tbrMain.Location = new System.Drawing.Point(0, 0);
            this.tbrMain.Name = "tbrMain";
            this.tbrMain.Size = new System.Drawing.Size(866, 25);
            this.tbrMain.TabIndex = 6;
            this.tbrMain.Text = "toolStrip1";
            // 
            // tsbBack
            // 
            this.tsbBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBack.Enabled = false;
            this.tsbBack.Image = ((System.Drawing.Image)(resources.GetObject("tsbBack.Image")));
            this.tsbBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBack.Name = "tsbBack";
            this.tsbBack.Size = new System.Drawing.Size(52, 22);
            this.tsbBack.Text = "<- Back";
            this.tsbBack.Click += new System.EventHandler(this.tsbBack_Click);
            // 
            // tsbForward
            // 
            this.tsbForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbForward.Enabled = false;
            this.tsbForward.Image = ((System.Drawing.Image)(resources.GetObject("tsbForward.Image")));
            this.tsbForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbForward.Name = "tsbForward";
            this.tsbForward.Size = new System.Drawing.Size(70, 22);
            this.tsbForward.Text = "Forward ->";
            this.tsbForward.Click += new System.EventHandler(this.tsbForward_Click);
            // 
            // tsbGoUp
            // 
            this.tsbGoUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGoUp.Image = global::MagiZile.CustomUI.Properties.Resources.ico_go_up;
            this.tsbGoUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGoUp.Name = "tsbGoUp";
            this.tsbGoUp.Size = new System.Drawing.Size(23, 22);
            this.tsbGoUp.Text = "Up one level";
            this.tsbGoUp.Click += new System.EventHandler(this.tsbGoUp_Click);
            // 
            // tsbCut
            // 
            this.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbCut.Image")));
            this.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCut.Name = "tsbCut";
            this.tsbCut.Size = new System.Drawing.Size(23, 22);
            this.tsbCut.Text = "C&ut";
            // 
            // tsbCopy
            // 
            this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(23, 22);
            this.tsbCopy.Text = "&Copy";
            // 
            // tsbPaste
            // 
            this.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaste.Image")));
            this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaste.Name = "tsbPaste";
            this.tsbPaste.Size = new System.Drawing.Size(23, 22);
            this.tsbPaste.Text = "&Paste";
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::MagiZile.CustomUI.Properties.Resources.ico_delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "&Delete";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tslTypePath
            // 
            this.tslTypePath.Name = "tslTypePath";
            this.tslTypePath.Size = new System.Drawing.Size(34, 22);
            this.tslTypePath.Text = "Path:";
            // 
            // tstTypePath
            // 
            this.tstTypePath.Name = "tstTypePath";
            this.tstTypePath.Size = new System.Drawing.Size(250, 25);
            // 
            // sep4
            // 
            this.sep4.Name = "sep4";
            this.sep4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSearch
            // 
            this.tsbSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = global::MagiZile.CustomUI.Properties.Resources.ico_search;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(23, 22);
            this.tsbSearch.Text = "Search";
            // 
            // tstSearch
            // 
            this.tstSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstSearch.Name = "tstSearch";
            this.tstSearch.Size = new System.Drawing.Size(70, 25);
            // 
            // tslSearch
            // 
            this.tslSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslSearch.Name = "tslSearch";
            this.tslSearch.Size = new System.Drawing.Size(45, 22);
            this.tslSearch.Text = "Search:";
            // 
            // tspLoading
            // 
            this.tspLoading.Name = "tspLoading";
            this.tspLoading.Size = new System.Drawing.Size(150, 22);
            this.tspLoading.Visible = false;
            // 
            // pnlBottomPane
            // 
            this.pnlBottomPane.Controls.Add(this.lblFileName);
            this.pnlBottomPane.Controls.Add(this.txtFileName);
            this.pnlBottomPane.Controls.Add(this.cboFileType);
            this.pnlBottomPane.Controls.Add(this.lblFileType);
            this.pnlBottomPane.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomPane.Location = new System.Drawing.Point(0, 446);
            this.pnlBottomPane.Name = "pnlBottomPane";
            this.pnlBottomPane.Size = new System.Drawing.Size(866, 49);
            this.pnlBottomPane.TabIndex = 4;
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(342, 19);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(57, 13);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "File Name:";
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.Location = new System.Drawing.Point(405, 16);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(274, 20);
            this.txtFileName.TabIndex = 3;
            // 
            // cboFileType
            // 
            this.cboFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFileType.FormattingEnabled = true;
            this.cboFileType.Items.AddRange(new object[] {
            "All Files (*.*)"});
            this.cboFileType.Location = new System.Drawing.Point(744, 15);
            this.cboFileType.Name = "cboFileType";
            this.cboFileType.Size = new System.Drawing.Size(119, 21);
            this.cboFileType.TabIndex = 2;
            // 
            // lblFileType
            // 
            this.lblFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileType.AutoSize = true;
            this.lblFileType.Location = new System.Drawing.Point(685, 18);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(53, 13);
            this.lblFileType.TabIndex = 1;
            this.lblFileType.Text = "File Type:";
            // 
            // lblFileSize
            // 
            this.lblFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(12, 372);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(49, 13);
            this.lblFileSize.TabIndex = 2;
            this.lblFileSize.Text = "File Size:";
            // 
            // cmuFileListOptions
            // 
            this.cmuFileListOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem2,
            this.newFolderToolStripMenuItem,
            this.toolStripMenuItem3,
            this.viewToolStripMenuItem});
            this.cmuFileListOptions.Name = "cmuFileOptions";
            this.cmuFileListOptions.Size = new System.Drawing.Size(175, 170);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cutToolStripMenuItem.Text = "&Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.copyToolStripMenuItem.Text = "C&opy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.renameToolStripMenuItem.Text = "R&ename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 6);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newFolderToolStripMenuItem.Text = "&New Folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(171, 6);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.smallIconsToolStripMenuItem,
            this.tilesToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.listToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.largeIconToolStripMenuItem.Text = "&Large Icons";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // smallIconsToolStripMenuItem
            // 
            this.smallIconsToolStripMenuItem.Name = "smallIconsToolStripMenuItem";
            this.smallIconsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.smallIconsToolStripMenuItem.Text = "Small Icons";
            this.smallIconsToolStripMenuItem.Click += new System.EventHandler(this.smallIconsToolStripMenuItem_Click);
            // 
            // tilesToolStripMenuItem
            // 
            this.tilesToolStripMenuItem.Name = "tilesToolStripMenuItem";
            this.tilesToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.tilesToolStripMenuItem.Text = "&Tiles";
            this.tilesToolStripMenuItem.Click += new System.EventHandler(this.tilesToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.detailsToolStripMenuItem.Text = "&Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.listToolStripMenuItem.Text = "L&ist";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // pnlPreview
            // 
            this.pnlPreview.Controls.Add(this.lblImageSize);
            this.pnlPreview.Controls.Add(this.lblFileSize);
            this.pnlPreview.Controls.Add(this.lblPreviewFileType);
            this.pnlPreview.Controls.Add(this.lblPreview);
            this.pnlPreview.Controls.Add(this.picPreview);
            this.pnlPreview.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPreview.Location = new System.Drawing.Point(494, 0);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(226, 412);
            this.pnlPreview.TabIndex = 2;
            // 
            // lblPreviewFileType
            // 
            this.lblPreviewFileType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPreviewFileType.AutoSize = true;
            this.lblPreviewFileType.Location = new System.Drawing.Point(12, 349);
            this.lblPreviewFileType.Name = "lblPreviewFileType";
            this.lblPreviewFileType.Size = new System.Drawing.Size(61, 13);
            this.lblPreviewFileType.TabIndex = 2;
            this.lblPreviewFileType.Text = "File Format:";
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(12, 18);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(48, 13);
            this.lblPreview.TabIndex = 1;
            this.lblPreview.Text = "Preview:";
            // 
            // picPreview
            // 
            this.picPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picPreview.Location = new System.Drawing.Point(15, 34);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(208, 312);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 0;
            this.picPreview.TabStop = false;
            // 
            // imgIcons
            // 
            this.imgIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgIcons.ImageStream")));
            this.imgIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgIcons.Images.SetKeyName(0, "ico_application.bmp");
            this.imgIcons.Images.SetKeyName(1, "ico_audio.bmp");
            this.imgIcons.Images.SetKeyName(2, "ico_delete.bmp");
            this.imgIcons.Images.SetKeyName(3, "ico_document.bmp");
            this.imgIcons.Images.SetKeyName(4, "ico_folder.bmp");
            this.imgIcons.Images.SetKeyName(5, "ico_go_up.bmp");
            this.imgIcons.Images.SetKeyName(6, "ico_image.bmp");
            this.imgIcons.Images.SetKeyName(7, "ico_music.bmp");
            this.imgIcons.Images.SetKeyName(8, "ico_other_file.bmp");
            this.imgIcons.Images.SetKeyName(9, "ico_video.bmp");
            this.imgIcons.Images.SetKeyName(10, "ico_markup_file.bmp");
            this.imgIcons.Images.SetKeyName(11, "ico_code_file.bmp");
            // 
            // imgTreeNodeImages
            // 
            this.imgTreeNodeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTreeNodeImages.ImageStream")));
            this.imgTreeNodeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.imgTreeNodeImages.Images.SetKeyName(0, "ico_folder_open.bmp");
            this.imgTreeNodeImages.Images.SetKeyName(1, "ico_folder.bmp");
            this.imgTreeNodeImages.Images.SetKeyName(2, "ico_disk_drive.bmp");
            // 
            // fswFileUpdater
            // 
            this.fswFileUpdater.EnableRaisingEvents = true;
            this.fswFileUpdater.IncludeSubdirectories = true;
            this.fswFileUpdater.Path = "C:\\";
            this.fswFileUpdater.SynchronizingObject = this;
            // 
            // lvwFiles
            // 
            this.lvwFiles.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvwFiles.AllowColumnReorder = true;
            this.lvwFiles.AllowDrop = true;
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colType,
            this.colSize,
            this.colDateCreated,
            this.colDateModified});
            this.lvwFiles.ContextMenuStrip = this.cmuFileListOptions;
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles.LabelEdit = true;
            this.lvwFiles.LargeImageList = this.imgIcons;
            this.lvwFiles.Location = new System.Drawing.Point(0, 0);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.ShowItemToolTips = true;
            this.lvwFiles.Size = new System.Drawing.Size(483, 412);
            this.lvwFiles.SmallImageList = this.imgIcons;
            this.lvwFiles.StateImageList = this.imgIcons;
            this.lvwFiles.TabIndex = 0;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            this.lvwFiles.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.lvwFiles_AfterLabelEdit);
            this.lvwFiles.ItemActivate += new System.EventHandler(this.lvwFiles_ItemActivate);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            // 
            // colType
            // 
            this.colType.Text = "Type";
            // 
            // colSize
            // 
            this.colSize.Text = "Size";
            // 
            // colDateCreated
            // 
            this.colDateCreated.Text = "Date Created";
            this.colDateCreated.Width = 80;
            // 
            // colDateModified
            // 
            this.colDateModified.Text = "Date Modified";
            this.colDateModified.Width = 86;
            // 
            // tvwFolders
            // 
            this.tvwFolders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwFolders.ImageIndex = 0;
            this.tvwFolders.ImageList = this.imgTreeNodeImages;
            this.tvwFolders.Location = new System.Drawing.Point(0, 0);
            this.tvwFolders.Name = "tvwFolders";
            this.tvwFolders.SelectedImageIndex = 0;
            this.tvwFolders.Size = new System.Drawing.Size(142, 412);
            this.tvwFolders.TabIndex = 0;
            this.tvwFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwFolders_AfterSelect);
            // 
            // spcFileList
            // 
            this.spcFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spcFileList.Location = new System.Drawing.Point(0, 28);
            this.spcFileList.Name = "spcFileList";
            // 
            // spcFileList.Panel1
            // 
            this.spcFileList.Panel1.Controls.Add(this.tvwFolders);
            // 
            // spcFileList.Panel2
            // 
            this.spcFileList.Panel2.Controls.Add(this.pnlFiles);
            this.spcFileList.Panel2.Controls.Add(this.pnlPreview);
            this.spcFileList.Size = new System.Drawing.Size(866, 412);
            this.spcFileList.SplitterDistance = 142;
            this.spcFileList.TabIndex = 5;
            // 
            // pnlFiles
            // 
            this.pnlFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiles.Controls.Add(this.lblFolderEmpty);
            this.pnlFiles.Controls.Add(this.lvwFiles);
            this.pnlFiles.Location = new System.Drawing.Point(5, 0);
            this.pnlFiles.Name = "pnlFiles";
            this.pnlFiles.Size = new System.Drawing.Size(483, 412);
            this.pnlFiles.TabIndex = 3;
            // 
            // lblFolderEmpty
            // 
            this.lblFolderEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFolderEmpty.AutoSize = true;
            this.lblFolderEmpty.BackColor = System.Drawing.SystemColors.Window;
            this.lblFolderEmpty.Location = new System.Drawing.Point(41, 18);
            this.lblFolderEmpty.Name = "lblFolderEmpty";
            this.lblFolderEmpty.Size = new System.Drawing.Size(382, 13);
            this.lblFolderEmpty.TabIndex = 1;
            this.lblFolderEmpty.Text = "The folder is empty or does not contain anything that matches your search/filter." +
    "";
            // 
            // FileSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spcFileList);
            this.Controls.Add(this.tbrMain);
            this.Controls.Add(this.pnlBottomPane);
            this.Name = "FileSelectorControl";
            this.Size = new System.Drawing.Size(866, 495);
            this.Load += new System.EventHandler(this.EnhancedFileSelector_Load);
            this.tbrMain.ResumeLayout(false);
            this.tbrMain.PerformLayout();
            this.pnlBottomPane.ResumeLayout(false);
            this.pnlBottomPane.PerformLayout();
            this.cmuFileListOptions.ResumeLayout(false);
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fswFileUpdater)).EndInit();
            this.spcFileList.Panel1.ResumeLayout(false);
            this.spcFileList.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcFileList)).EndInit();
            this.spcFileList.ResumeLayout(false);
            this.pnlFiles.ResumeLayout(false);
            this.pnlFiles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImageSize;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripSeparator sep3;
        private System.Windows.Forms.ToolStrip tbrMain;
        private System.Windows.Forms.ToolStripButton tsbBack;
        private System.Windows.Forms.ToolStripButton tsbForward;
        private System.Windows.Forms.ToolStripButton tsbGoUp;
        private System.Windows.Forms.ToolStripButton tsbCut;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripButton tsbPaste;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripLabel tslTypePath;
        private System.Windows.Forms.ToolStripTextBox tstTypePath;
        private System.Windows.Forms.ToolStripSeparator sep4;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripTextBox tstSearch;
        private System.Windows.Forms.ToolStripLabel tslSearch;
        private System.Windows.Forms.ToolStripProgressBar tspLoading;
        private System.Windows.Forms.Panel pnlBottomPane;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.ComboBox cboFileType;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.ContextMenuStrip cmuFileListOptions;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.Panel pnlPreview;
        private System.Windows.Forms.Label lblPreviewFileType;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.ImageList imgIcons;
        private System.Windows.Forms.ImageList imgTreeNodeImages;
        private System.IO.FileSystemWatcher fswFileUpdater;
        private System.Windows.Forms.SplitContainer spcFileList;
        private System.Windows.Forms.TreeView tvwFolders;
        private System.Windows.Forms.Panel pnlFiles;
        private System.Windows.Forms.Label lblFolderEmpty;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colSize;
        private System.Windows.Forms.ColumnHeader colDateCreated;
        private System.Windows.Forms.ColumnHeader colDateModified;
    }
}
