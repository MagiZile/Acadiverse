namespace MagiZile.CustomUI
{
    partial class EnhancedFileSelector
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
            this.objFileSelector = new MagiZile.CustomUI.FileSelectorControl();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // objFileSelector
            // 
            this.objFileSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objFileSelector.FileFilter = new string[] {
        "*.*"};
            this.objFileSelector.Location = new System.Drawing.Point(0, 0);
            this.objFileSelector.Mode = MagiZile.CustomUI.FileSelectorControl.FileMode.Open;
            this.objFileSelector.Name = "objFileSelector";
            this.objFileSelector.Size = new System.Drawing.Size(875, 503);
            this.objFileSelector.StartingPath = "C:\\";
            this.objFileSelector.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(788, 514);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelect.Location = new System.Drawing.Point(707, 514);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // EnhancedFileSelector
            // 
            this.AcceptButton = this.btnSelect;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(875, 549);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.objFileSelector);
            this.Name = "EnhancedFileSelector";
            this.Text = "Select File";
            this.ResumeLayout(false);

        }

        #endregion

        private FileSelectorControl objFileSelector;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
    }
}