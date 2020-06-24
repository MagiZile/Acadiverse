namespace MagiZile.CustomUI.TabForms
{
    partial class frmAddUnforseenEvent
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
            this.cboEvent = new System.Windows.Forms.ComboBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblExtraInfo = new System.Windows.Forms.Label();
            this.cboEventInfo = new System.Windows.Forms.ComboBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.rbtDefault = new System.Windows.Forms.RadioButton();
            this.rbtCustom = new System.Windows.Forms.RadioButton();
            this.txtCustom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(205, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(124, 216);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cboEvent
            // 
            this.cboEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEvent.FormattingEnabled = true;
            this.cboEvent.Items.AddRange(new object[] {
            "Broken Bone",
            "Burglary",
            "Business Fire",
            "Flood",
            "Gas Leak",
            "Hail",
            "House Fire",
            "Hurricane",
            "Illness",
            "Tornado"});
            this.cboEvent.Location = new System.Drawing.Point(64, 6);
            this.cboEvent.Name = "cboEvent";
            this.cboEvent.Size = new System.Drawing.Size(216, 21);
            this.cboEvent.Sorted = true;
            this.cboEvent.TabIndex = 1;
            this.cboEvent.SelectedIndexChanged += new System.EventHandler(this.cboEvent_SelectedIndexChanged);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Location = new System.Drawing.Point(0, 9);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(38, 13);
            this.lblEvent.TabIndex = 2;
            this.lblEvent.Text = "Event:";
            // 
            // lblExtraInfo
            // 
            this.lblExtraInfo.AutoSize = true;
            this.lblExtraInfo.Location = new System.Drawing.Point(0, 36);
            this.lblExtraInfo.Name = "lblExtraInfo";
            this.lblExtraInfo.Size = new System.Drawing.Size(58, 13);
            this.lblExtraInfo.TabIndex = 3;
            this.lblExtraInfo.Text = "Extra Info: ";
            // 
            // cboEventInfo
            // 
            this.cboEventInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEventInfo.FormattingEnabled = true;
            this.cboEventInfo.Location = new System.Drawing.Point(64, 33);
            this.cboEventInfo.Name = "cboEventInfo";
            this.cboEventInfo.Size = new System.Drawing.Size(216, 21);
            this.cboEventInfo.TabIndex = 4;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Location = new System.Drawing.Point(3, 62);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(45, 13);
            this.lblDetails.TabIndex = 5;
            this.lblDetails.Text = "Details: ";
            // 
            // rbtDefault
            // 
            this.rbtDefault.AutoSize = true;
            this.rbtDefault.Checked = true;
            this.rbtDefault.Location = new System.Drawing.Point(64, 58);
            this.rbtDefault.Name = "rbtDefault";
            this.rbtDefault.Size = new System.Drawing.Size(59, 17);
            this.rbtDefault.TabIndex = 6;
            this.rbtDefault.TabStop = true;
            this.rbtDefault.Text = "Default";
            this.rbtDefault.UseVisualStyleBackColor = true;
            // 
            // rbtCustom
            // 
            this.rbtCustom.AutoSize = true;
            this.rbtCustom.Location = new System.Drawing.Point(129, 58);
            this.rbtCustom.Name = "rbtCustom";
            this.rbtCustom.Size = new System.Drawing.Size(60, 17);
            this.rbtCustom.TabIndex = 6;
            this.rbtCustom.Text = "Custom";
            this.rbtCustom.UseVisualStyleBackColor = true;
            // 
            // txtCustom
            // 
            this.txtCustom.Location = new System.Drawing.Point(3, 78);
            this.txtCustom.Multiline = true;
            this.txtCustom.Name = "txtCustom";
            this.txtCustom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCustom.Size = new System.Drawing.Size(277, 132);
            this.txtCustom.TabIndex = 7;
            this.txtCustom.TextChanged += new System.EventHandler(this.txtCustom_TextChanged);
            // 
            // frmAddUnforseenEvent
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 239);
            this.Controls.Add(this.txtCustom);
            this.Controls.Add(this.rbtCustom);
            this.Controls.Add(this.rbtDefault);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.cboEventInfo);
            this.Controls.Add(this.lblExtraInfo);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.cboEvent);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddUnforseenEvent";
            this.Text = "Add Unforeseen Event";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cboEvent;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblExtraInfo;
        private System.Windows.Forms.ComboBox cboEventInfo;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.RadioButton rbtDefault;
        private System.Windows.Forms.RadioButton rbtCustom;
        private System.Windows.Forms.TextBox txtCustom;
    }
}