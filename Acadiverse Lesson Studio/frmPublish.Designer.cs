namespace Acadiverse_Lesson_Studio
{
    partial class FrmPublish
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
            this.pnlStep1 = new System.Windows.Forms.Panel();
            this.lblTagInstructions = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboGradeLevel = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGradeLevel = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pnlStep2 = new System.Windows.Forms.Panel();
            this.lblCurrentTask = new System.Windows.Forms.Label();
            this.prgReviewingSubmission = new System.Windows.Forms.ProgressBar();
            this.lblReviewingSubmission = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.bgwBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.pnlStep1.SuspendLayout();
            this.pnlStep2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStep1
            // 
            this.pnlStep1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStep1.Controls.Add(this.lblTagInstructions);
            this.pnlStep1.Controls.Add(this.txtTags);
            this.pnlStep1.Controls.Add(this.txtDescription);
            this.pnlStep1.Controls.Add(this.cboGradeLevel);
            this.pnlStep1.Controls.Add(this.txtTitle);
            this.pnlStep1.Controls.Add(this.lblTags);
            this.pnlStep1.Controls.Add(this.lblDescription);
            this.pnlStep1.Controls.Add(this.lblGradeLevel);
            this.pnlStep1.Controls.Add(this.lblTitle);
            this.pnlStep1.Location = new System.Drawing.Point(5, -1);
            this.pnlStep1.Name = "pnlStep1";
            this.pnlStep1.Size = new System.Drawing.Size(449, 212);
            this.pnlStep1.TabIndex = 0;
            // 
            // lblTagInstructions
            // 
            this.lblTagInstructions.AutoSize = true;
            this.lblTagInstructions.Location = new System.Drawing.Point(83, 177);
            this.lblTagInstructions.Name = "lblTagInstructions";
            this.lblTagInstructions.Size = new System.Drawing.Size(189, 13);
            this.lblTagInstructions.TabIndex = 8;
            this.lblTagInstructions.Text = "5 tags maximum, seperated by spaces.";
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(86, 154);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(186, 20);
            this.txtTags.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(86, 73);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(186, 75);
            this.txtDescription.TabIndex = 6;
            // 
            // cboGradeLevel
            // 
            this.cboGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGradeLevel.FormattingEnabled = true;
            this.cboGradeLevel.Items.AddRange(new object[] {
            "Kindergarten",
            "1st Grade",
            "2nd Grade",
            "3rd Grade",
            "4th Grade",
            "5th Grade",
            "6th Grade",
            "7th Grade",
            "8th Grade",
            "9th Grade",
            "10th Grade",
            "11th Grade",
            "12th Grade",
            "College"});
            this.cboGradeLevel.Location = new System.Drawing.Point(86, 46);
            this.cboGradeLevel.Name = "cboGradeLevel";
            this.cboGradeLevel.Size = new System.Drawing.Size(186, 21);
            this.cboGradeLevel.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(86, 19);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(186, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(46, 157);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(34, 13);
            this.lblTags.TabIndex = 3;
            this.lblTags.Text = "Tags:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 76);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description:";
            // 
            // lblGradeLevel
            // 
            this.lblGradeLevel.AutoSize = true;
            this.lblGradeLevel.Location = new System.Drawing.Point(12, 49);
            this.lblGradeLevel.Name = "lblGradeLevel";
            this.lblGradeLevel.Size = new System.Drawing.Size(68, 13);
            this.lblGradeLevel.TabIndex = 1;
            this.lblGradeLevel.Text = "Grade Level:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(53, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(379, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.Location = new System.Drawing.Point(298, 217);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next ->";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.Location = new System.Drawing.Point(217, 217);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "<- Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // pnlStep2
            // 
            this.pnlStep2.Controls.Add(this.lblCurrentTask);
            this.pnlStep2.Controls.Add(this.prgReviewingSubmission);
            this.pnlStep2.Controls.Add(this.lblReviewingSubmission);
            this.pnlStep2.Controls.Add(this.lblStep2);
            this.pnlStep2.Location = new System.Drawing.Point(5, 2);
            this.pnlStep2.Name = "pnlStep2";
            this.pnlStep2.Size = new System.Drawing.Size(449, 209);
            this.pnlStep2.TabIndex = 4;
            // 
            // lblCurrentTask
            // 
            this.lblCurrentTask.AutoSize = true;
            this.lblCurrentTask.Location = new System.Drawing.Point(12, 112);
            this.lblCurrentTask.Name = "lblCurrentTask";
            this.lblCurrentTask.Size = new System.Drawing.Size(179, 13);
            this.lblCurrentTask.TabIndex = 3;
            this.lblCurrentTask.Text = "Checking for inappropriate content...";
            // 
            // prgReviewingSubmission
            // 
            this.prgReviewingSubmission.Location = new System.Drawing.Point(15, 89);
            this.prgReviewingSubmission.Name = "prgReviewingSubmission";
            this.prgReviewingSubmission.Size = new System.Drawing.Size(422, 20);
            this.prgReviewingSubmission.TabIndex = 2;
            // 
            // lblReviewingSubmission
            // 
            this.lblReviewingSubmission.AutoSize = true;
            this.lblReviewingSubmission.Location = new System.Drawing.Point(12, 73);
            this.lblReviewingSubmission.Name = "lblReviewingSubmission";
            this.lblReviewingSubmission.Size = new System.Drawing.Size(122, 13);
            this.lblReviewingSubmission.TabIndex = 1;
            this.lblReviewingSubmission.Text = "Reviewing Submission...";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Location = new System.Drawing.Point(7, 7);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(431, 26);
            this.lblStep2.TabIndex = 0;
            this.lblStep2.Text = "Your submission must first be checked for anything inappropriate and then exporte" +
    "d before\r\nbeing published.";
            // 
            // bgwBackgroundWorker
            // 
            this.bgwBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwBackgroundWorker_DoWork);
            // 
            // FrmPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 244);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlStep2);
            this.Controls.Add(this.pnlStep1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPublish";
            this.Text = "Publish Project to Acadiverse";
            this.pnlStep1.ResumeLayout(false);
            this.pnlStep1.PerformLayout();
            this.pnlStep2.ResumeLayout(false);
            this.pnlStep2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStep1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblTagInstructions;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cboGradeLevel;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblGradeLevel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlStep2;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.ProgressBar prgReviewingSubmission;
        private System.Windows.Forms.Label lblReviewingSubmission;
        private System.ComponentModel.BackgroundWorker bgwBackgroundWorker;
        private System.Windows.Forms.Label lblCurrentTask;
    }
}