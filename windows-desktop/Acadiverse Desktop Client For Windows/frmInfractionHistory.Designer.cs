namespace AcadiverseDesktop
{
    partial class frmInfractionHistory
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
            this.lblInfractionHistory = new System.Windows.Forms.Label();
            this.lvwInfractionHistory = new System.Windows.Forms.ListView();
            this.colInfractionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClose = new System.Windows.Forms.Button();
            this.colModeratorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblInfractionHistory
            // 
            this.lblInfractionHistory.AutoSize = true;
            this.lblInfractionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfractionHistory.Location = new System.Drawing.Point(-3, -1);
            this.lblInfractionHistory.Name = "lblInfractionHistory";
            this.lblInfractionHistory.Size = new System.Drawing.Size(360, 20);
            this.lblInfractionHistory.TabIndex = 0;
            this.lblInfractionHistory.Text = "Infraction History for AcadiverseUser12345:";
            // 
            // lvwInfractionHistory
            // 
            this.lvwInfractionHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwInfractionHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDate,
            this.colInfractionType,
            this.colModeratorName,
            this.colReason});
            this.lvwInfractionHistory.HideSelection = false;
            this.lvwInfractionHistory.Location = new System.Drawing.Point(1, 22);
            this.lvwInfractionHistory.Name = "lvwInfractionHistory";
            this.lvwInfractionHistory.Size = new System.Drawing.Size(622, 441);
            this.lvwInfractionHistory.TabIndex = 1;
            this.lvwInfractionHistory.UseCompatibleStateImageBehavior = false;
            this.lvwInfractionHistory.View = System.Windows.Forms.View.Details;
            // 
            // colInfractionType
            // 
            this.colInfractionType.Text = "Infraction Type";
            this.colInfractionType.Width = 144;
            // 
            // colDate
            // 
            this.colDate.Text = "Date";
            this.colDate.Width = 84;
            // 
            // colReason
            // 
            this.colReason.Text = "Reason";
            this.colReason.Width = 250;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(548, 469);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // colModeratorName
            // 
            this.colModeratorName.Text = "Moderator Name";
            this.colModeratorName.Width = 134;
            // 
            // frmInfractionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 496);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lvwInfractionHistory);
            this.Controls.Add(this.lblInfractionHistory);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInfractionHistory";
            this.Text = "Infraction History";
            this.Load += new System.EventHandler(this.frmInfractionHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfractionHistory;
        private System.Windows.Forms.ListView lvwInfractionHistory;
        private System.Windows.Forms.ColumnHeader colDate;
        private System.Windows.Forms.ColumnHeader colInfractionType;
        private System.Windows.Forms.ColumnHeader colReason;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ColumnHeader colModeratorName;
    }
}