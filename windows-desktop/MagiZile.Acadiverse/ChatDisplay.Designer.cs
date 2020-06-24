namespace MagiZile.Acadiverse
{
    partial class ChatDisplay
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
            this.lblChatName = new System.Windows.Forms.Label();
            this.rtbChatDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblChatName
            // 
            this.lblChatName.AutoSize = true;
            this.lblChatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatName.Location = new System.Drawing.Point(3, 0);
            this.lblChatName.Name = "lblChatName";
            this.lblChatName.Size = new System.Drawing.Size(98, 20);
            this.lblChatName.TabIndex = 0;
            this.lblChatName.Text = "Chat Name";
            // 
            // rtbChatDescription
            // 
            this.rtbChatDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbChatDescription.BackColor = System.Drawing.SystemColors.Control;
            this.rtbChatDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbChatDescription.Location = new System.Drawing.Point(3, 23);
            this.rtbChatDescription.Name = "rtbChatDescription";
            this.rtbChatDescription.Size = new System.Drawing.Size(478, 92);
            this.rtbChatDescription.TabIndex = 1;
            this.rtbChatDescription.Text = "";
            // 
            // ChatDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbChatDescription);
            this.Controls.Add(this.lblChatName);
            this.Name = "ChatDisplay";
            this.Size = new System.Drawing.Size(481, 115);
            this.Load += new System.EventHandler(this.ChatDisplay_Load);
            this.Click += new System.EventHandler(this.ChatDisplay_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChatName;
        private System.Windows.Forms.RichTextBox rtbChatDescription;
    }
}
