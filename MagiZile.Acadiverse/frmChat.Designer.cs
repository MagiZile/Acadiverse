namespace MagiZile.Acadiverse
{
    partial class FrmChat
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
            this.txtChat = new System.Windows.Forms.TextBox();
            this.flpChat = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtChat.Location = new System.Drawing.Point(0, 430);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(800, 20);
            this.txtChat.TabIndex = 6;
            this.txtChat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtChat_KeyPress);
            // 
            // flpChat
            // 
            this.flpChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpChat.AutoScroll = true;
            this.flpChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpChat.Location = new System.Drawing.Point(2, 3);
            this.flpChat.Name = "flpChat";
            this.flpChat.Size = new System.Drawing.Size(796, 421);
            this.flpChat.TabIndex = 5;
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.flpChat);
            this.Name = "frmChat";
            this.Text = "frmChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.FlowLayoutPanel flpChat;
    }
}