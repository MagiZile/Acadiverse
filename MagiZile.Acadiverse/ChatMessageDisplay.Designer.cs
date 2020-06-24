namespace MagiZile.Acadiverse
{
    partial class ChatMessageDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatMessageDisplay));
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnReply = new System.Windows.Forms.Button();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.rtbMessageContents = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(504, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.Black;
            this.btnReport.Location = new System.Drawing.Point(441, 3);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(57, 23);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // btnReply
            // 
            this.btnReply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReply.ForeColor = System.Drawing.Color.Black;
            this.btnReply.Location = new System.Drawing.Point(378, 3);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(57, 23);
            this.btnReply.TabIndex = 0;
            this.btnReply.Text = "Reply";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSender.ForeColor = System.Drawing.Color.Black;
            this.lblSender.Location = new System.Drawing.Point(3, 6);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(187, 20);
            this.lblSender.TabIndex = 1;
            this.lblSender.Text = "John H. Doe (@jhdoe)";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(295, 8);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(77, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "XXX days ago.";
            // 
            // rtbMessageContents
            // 
            this.rtbMessageContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMessageContents.BackColor = System.Drawing.Color.White;
            this.rtbMessageContents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMessageContents.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMessageContents.Location = new System.Drawing.Point(7, 29);
            this.rtbMessageContents.Name = "rtbMessageContents";
            this.rtbMessageContents.Size = new System.Drawing.Size(554, 139);
            this.rtbMessageContents.TabIndex = 3;
            this.rtbMessageContents.Text = resources.GetString("rtbMessageContents.Text");
            // 
            // ChatMessageDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rtbMessageContents);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnDelete);
            this.Name = "ChatMessageDisplay";
            this.Size = new System.Drawing.Size(564, 168);
            this.Load += new System.EventHandler(this.ChatMessageDisplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.RichTextBox rtbMessageContents;
    }
}
