namespace MagiZile.CustomUI
{
    partial class TaskProgressEntryList
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
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.taskProgressEntry1 = new MagiZile.CustomUI.TaskProgressEntry();
            this.flpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.Controls.Add(this.taskProgressEntry1);
            this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMain.Location = new System.Drawing.Point(0, 0);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(266, 503);
            this.flpMain.TabIndex = 0;
            this.flpMain.Paint += new System.Windows.Forms.PaintEventHandler(this.flpMain_Paint);
            // 
            // taskProgressEntry1
            // 
            this.taskProgressEntry1.Location = new System.Drawing.Point(3, 3);
            this.taskProgressEntry1.Name = "taskProgressEntry1";
            this.taskProgressEntry1.Size = new System.Drawing.Size(250, 62);
            this.taskProgressEntry1.TabIndex = 0;
            // 
            // TaskProgressEntryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpMain);
            this.Name = "TaskProgressEntryList";
            this.Size = new System.Drawing.Size(266, 503);
            this.flpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private TaskProgressEntry taskProgressEntry1;
    }
}
