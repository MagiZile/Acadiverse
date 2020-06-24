namespace MagiZile.CustomUI.TabForms
{
    partial class frmFind
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
            this.lblFindText = new System.Windows.Forms.Label();
            this.txtFindText = new System.Windows.Forms.TextBox();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnFindPrevious = new System.Windows.Forms.Button();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.chkWholeWordsOnly = new System.Windows.Forms.CheckBox();
            this.lblMatchesFound = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFindText
            // 
            this.lblFindText.AutoSize = true;
            this.lblFindText.Location = new System.Drawing.Point(12, 9);
            this.lblFindText.Name = "lblFindText";
            this.lblFindText.Size = new System.Drawing.Size(54, 13);
            this.lblFindText.TabIndex = 0;
            this.lblFindText.Text = "Find Text:";
            // 
            // txtFindText
            // 
            this.txtFindText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFindText.Location = new System.Drawing.Point(72, 6);
            this.txtFindText.Name = "txtFindText";
            this.txtFindText.Size = new System.Drawing.Size(332, 20);
            this.txtFindText.TabIndex = 1;
            // 
            // btnFindAll
            // 
            this.btnFindAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindAll.Location = new System.Drawing.Point(309, 34);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(95, 23);
            this.btnFindAll.TabIndex = 2;
            this.btnFindAll.Text = "Find All";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // btnFindNext
            // 
            this.btnFindNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindNext.Location = new System.Drawing.Point(208, 34);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(95, 23);
            this.btnFindNext.TabIndex = 2;
            this.btnFindNext.Text = "Find Next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnFindPrevious
            // 
            this.btnFindPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindPrevious.Location = new System.Drawing.Point(107, 34);
            this.btnFindPrevious.Name = "btnFindPrevious";
            this.btnFindPrevious.Size = new System.Drawing.Size(95, 23);
            this.btnFindPrevious.TabIndex = 2;
            this.btnFindPrevious.Text = "Find Previous";
            this.btnFindPrevious.UseVisualStyleBackColor = true;
            this.btnFindPrevious.Click += new System.EventHandler(this.btnFindPrevious_Click);
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(203, 62);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(83, 17);
            this.chkMatchCase.TabIndex = 3;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // chkWholeWordsOnly
            // 
            this.chkWholeWordsOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkWholeWordsOnly.AutoSize = true;
            this.chkWholeWordsOnly.Location = new System.Drawing.Point(289, 62);
            this.chkWholeWordsOnly.Name = "chkWholeWordsOnly";
            this.chkWholeWordsOnly.Size = new System.Drawing.Size(115, 17);
            this.chkWholeWordsOnly.TabIndex = 3;
            this.chkWholeWordsOnly.Text = "Whole Words Only";
            this.chkWholeWordsOnly.UseVisualStyleBackColor = true;
            // 
            // lblMatchesFound
            // 
            this.lblMatchesFound.AutoSize = true;
            this.lblMatchesFound.Location = new System.Drawing.Point(12, 66);
            this.lblMatchesFound.Name = "lblMatchesFound";
            this.lblMatchesFound.Size = new System.Drawing.Size(97, 13);
            this.lblMatchesFound.TabIndex = 4;
            this.lblMatchesFound.Text = "No matches found.";
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 85);
            this.Controls.Add(this.lblMatchesFound);
            this.Controls.Add(this.chkWholeWordsOnly);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.btnFindPrevious);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.btnFindAll);
            this.Controls.Add(this.txtFindText);
            this.Controls.Add(this.lblFindText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFind";
            this.Text = "Find";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFindText;
        private System.Windows.Forms.TextBox txtFindText;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnFindPrevious;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.CheckBox chkWholeWordsOnly;
        private System.Windows.Forms.Label lblMatchesFound;
    }
}