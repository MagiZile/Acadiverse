namespace Acadiverse_Lesson_Studio
{
    partial class frmWorksheet
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
            this.rtbWorksheet = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbWorksheet
            // 
            this.rtbWorksheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbWorksheet.Location = new System.Drawing.Point(0, 0);
            this.rtbWorksheet.Name = "rtbWorksheet";
            this.rtbWorksheet.Size = new System.Drawing.Size(490, 400);
            this.rtbWorksheet.TabIndex = 0;
            this.rtbWorksheet.Text = "";
            // 
            // frmWorksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 400);
            this.Controls.Add(this.rtbWorksheet);
            this.Name = "frmWorksheet";
            this.Text = "frmWorksheet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbWorksheet;
    }
}