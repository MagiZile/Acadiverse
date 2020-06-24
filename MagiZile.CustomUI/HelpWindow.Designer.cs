namespace MagiZile.CustomUI
{
    partial class HelpWindow
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
            this.tabLeftPanel = new System.Windows.Forms.TabControl();
            this.tabContents = new System.Windows.Forms.TabPage();
            this.tabIndex = new System.Windows.Forms.TabPage();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tabLeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLeftPanel
            // 
            this.tabLeftPanel.Controls.Add(this.tabContents);
            this.tabLeftPanel.Controls.Add(this.tabIndex);
            this.tabLeftPanel.Controls.Add(this.tabSearch);
            this.tabLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.tabLeftPanel.Name = "tabLeftPanel";
            this.tabLeftPanel.SelectedIndex = 0;
            this.tabLeftPanel.Size = new System.Drawing.Size(200, 376);
            this.tabLeftPanel.TabIndex = 0;
            // 
            // tabContents
            // 
            this.tabContents.Location = new System.Drawing.Point(4, 22);
            this.tabContents.Name = "tabContents";
            this.tabContents.Padding = new System.Windows.Forms.Padding(3);
            this.tabContents.Size = new System.Drawing.Size(192, 350);
            this.tabContents.TabIndex = 0;
            this.tabContents.Text = "Contents";
            this.tabContents.UseVisualStyleBackColor = true;
            // 
            // tabIndex
            // 
            this.tabIndex.Location = new System.Drawing.Point(4, 22);
            this.tabIndex.Name = "tabIndex";
            this.tabIndex.Padding = new System.Windows.Forms.Padding(3);
            this.tabIndex.Size = new System.Drawing.Size(192, 350);
            this.tabIndex.TabIndex = 1;
            this.tabIndex.Text = "Index";
            this.tabIndex.UseVisualStyleBackColor = true;
            // 
            // tabSearch
            // 
            this.tabSearch.Location = new System.Drawing.Point(4, 22);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(192, 350);
            this.tabSearch.TabIndex = 2;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(200, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(369, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 376);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabLeftPanel);
            this.Name = "HelpWindow";
            this.Text = "HelpWindow";
            this.tabLeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabLeftPanel;
        private System.Windows.Forms.TabPage tabContents;
        private System.Windows.Forms.TabPage tabIndex;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}