namespace MagiZile.CustomUI
{
    partial class FrmGetMoreStyles
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblLoadingStyles = new System.Windows.Forms.Label();
            this.prgLoadingStyles = new System.Windows.Forms.ProgressBar();
            this.lvwStyles = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCreator = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnRefreshStyles = new System.Windows.Forms.Button();
            this.lblNoStyles = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUploadStyle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(274, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(193, 299);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblLoadingStyles
            // 
            this.lblLoadingStyles.AutoSize = true;
            this.lblLoadingStyles.Location = new System.Drawing.Point(5, 9);
            this.lblLoadingStyles.Name = "lblLoadingStyles";
            this.lblLoadingStyles.Size = new System.Drawing.Size(85, 13);
            this.lblLoadingStyles.TabIndex = 1;
            this.lblLoadingStyles.Text = "Loading Styles...";
            // 
            // prgLoadingStyles
            // 
            this.prgLoadingStyles.Location = new System.Drawing.Point(5, 25);
            this.prgLoadingStyles.Name = "prgLoadingStyles";
            this.prgLoadingStyles.Size = new System.Drawing.Size(344, 23);
            this.prgLoadingStyles.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.prgLoadingStyles.TabIndex = 2;
            // 
            // lvwStyles
            // 
            this.lvwStyles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCreator,
            this.colDescription});
            this.lvwStyles.Location = new System.Drawing.Point(5, 54);
            this.lvwStyles.Name = "lvwStyles";
            this.lvwStyles.Size = new System.Drawing.Size(344, 202);
            this.lvwStyles.TabIndex = 3;
            this.lvwStyles.UseCompatibleStateImageBehavior = false;
            this.lvwStyles.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 75;
            // 
            // colCreator
            // 
            this.colCreator.Text = "Creator";
            this.colCreator.Width = 90;
            // 
            // colDescription
            // 
            this.colDescription.Text = "Description";
            this.colDescription.Width = 173;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(259, 262);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(90, 23);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // btnRefreshStyles
            // 
            this.btnRefreshStyles.Location = new System.Drawing.Point(163, 262);
            this.btnRefreshStyles.Name = "btnRefreshStyles";
            this.btnRefreshStyles.Size = new System.Drawing.Size(90, 23);
            this.btnRefreshStyles.TabIndex = 4;
            this.btnRefreshStyles.Text = "Refresh Styles";
            this.btnRefreshStyles.UseVisualStyleBackColor = true;
            // 
            // lblNoStyles
            // 
            this.lblNoStyles.AutoSize = true;
            this.lblNoStyles.BackColor = System.Drawing.SystemColors.Window;
            this.lblNoStyles.Location = new System.Drawing.Point(67, 85);
            this.lblNoStyles.Name = "lblNoStyles";
            this.lblNoStyles.Size = new System.Drawing.Size(211, 13);
            this.lblNoStyles.TabIndex = 5;
            this.lblNoStyles.Text = "There are no styles that match your search.";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(139, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(129, 20);
            this.txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(274, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnUploadStyle
            // 
            this.btnUploadStyle.Location = new System.Drawing.Point(5, 262);
            this.btnUploadStyle.Name = "btnUploadStyle";
            this.btnUploadStyle.Size = new System.Drawing.Size(85, 23);
            this.btnUploadStyle.TabIndex = 8;
            this.btnUploadStyle.Text = "Upload Style...";
            this.btnUploadStyle.UseVisualStyleBackColor = true;
            this.btnUploadStyle.Click += new System.EventHandler(this.BtnUploadStyle_Click);
            // 
            // frmGetMoreStyles
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 322);
            this.Controls.Add(this.btnUploadStyle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblNoStyles);
            this.Controls.Add(this.btnRefreshStyles);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lvwStyles);
            this.Controls.Add(this.prgLoadingStyles);
            this.Controls.Add(this.lblLoadingStyles);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGetMoreStyles";
            this.Text = "Get More Styles";
            this.Load += new System.EventHandler(this.FrmGetMoreStyles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblLoadingStyles;
        private System.Windows.Forms.ProgressBar prgLoadingStyles;
        private System.Windows.Forms.ListView lvwStyles;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCreator;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.Button btnRefreshStyles;
        private System.Windows.Forms.Label lblNoStyles;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUploadStyle;
    }
}