namespace MagiZile.CustomUI
{
    partial class EnhancedMessageBox
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(50, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message";
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(12, 12);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(32, 32);
            this.picIcon.TabIndex = 1;
            this.picIcon.TabStop = false;
            // 
            // btn3
            // 
            this.btn3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn3.AutoSize = true;
            this.btn3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn3.Location = new System.Drawing.Point(191, 81);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Button 1";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn2.AutoSize = true;
            this.btn2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn2.Location = new System.Drawing.Point(110, 81);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "Button 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Visible = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(29, 81);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Button 3";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Visible = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // EnhancedMessageBox
            // 
            this.AcceptButton = this.btn3;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn3;
            this.ClientSize = new System.Drawing.Size(278, 116);
            this.ControlBox = false;
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(284, 122);
            this.Name = "EnhancedMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Box Title";
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox picIcon;
        public System.Windows.Forms.Button btn3;
        public System.Windows.Forms.Button btn2;
        public System.Windows.Forms.Button btn1;
    }
}