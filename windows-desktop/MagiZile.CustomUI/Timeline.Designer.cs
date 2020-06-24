namespace MagiZile.CustomUI
{
    partial class Timeline
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
            this.trkTimeSlider = new System.Windows.Forms.TrackBar();
            this.cboView = new System.Windows.Forms.ComboBox();
            this.lblView = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkTimeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // trkTimeSlider
            // 
            this.trkTimeSlider.Location = new System.Drawing.Point(0, 123);
            this.trkTimeSlider.Maximum = 100;
            this.trkTimeSlider.Name = "trkTimeSlider";
            this.trkTimeSlider.Size = new System.Drawing.Size(581, 45);
            this.trkTimeSlider.TabIndex = 0;
            this.trkTimeSlider.Scroll += new System.EventHandler(this.trkTimeSlider_Scroll);
            // 
            // cboView
            // 
            this.cboView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboView.FormattingEnabled = true;
            this.cboView.Items.AddRange(new object[] {
            "Years",
            "Months",
            "Days"});
            this.cboView.Location = new System.Drawing.Point(42, 0);
            this.cboView.Name = "cboView";
            this.cboView.Size = new System.Drawing.Size(121, 21);
            this.cboView.TabIndex = 1;
            this.cboView.SelectedIndexChanged += new System.EventHandler(this.cboView_SelectedIndexChanged);
            // 
            // lblView
            // 
            this.lblView.AutoSize = true;
            this.lblView.Location = new System.Drawing.Point(3, 3);
            this.lblView.Name = "lblView";
            this.lblView.Size = new System.Drawing.Size(33, 13);
            this.lblView.TabIndex = 2;
            this.lblView.Text = "View:";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(255, 11);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentTime.TabIndex = 3;
            // 
            // Timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.lblView);
            this.Controls.Add(this.cboView);
            this.Controls.Add(this.trkTimeSlider);
            this.Name = "Timeline";
            this.Size = new System.Drawing.Size(584, 168);
            this.Load += new System.EventHandler(this.Timeline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trkTimeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trkTimeSlider;
        private System.Windows.Forms.ComboBox cboView;
        private System.Windows.Forms.Label lblView;
        private System.Windows.Forms.Label lblCurrentTime;
    }
}
