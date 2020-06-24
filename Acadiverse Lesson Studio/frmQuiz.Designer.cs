namespace Acadiverse_Lesson_Studio
{
    partial class FrmQuiz
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
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.txtQuestionText = new System.Windows.Forms.TextBox();
            this.lblQuestionType = new System.Windows.Forms.Label();
            this.cboQuestionType = new System.Windows.Forms.ComboBox();
            this.pnlMultipleChoice = new System.Windows.Forms.Panel();
            this.rbtChoice1 = new System.Windows.Forms.RadioButton();
            this.rbtChoice2 = new System.Windows.Forms.RadioButton();
            this.rbtChoice3 = new System.Windows.Forms.RadioButton();
            this.rbtChoice4 = new System.Windows.Forms.RadioButton();
            this.txtChoice1 = new System.Windows.Forms.TextBox();
            this.txtChoice2 = new System.Windows.Forms.TextBox();
            this.txtChoice3 = new System.Windows.Forms.TextBox();
            this.txtChoice4 = new System.Windows.Forms.TextBox();
            this.pnlShortAnswer = new System.Windows.Forms.Panel();
            this.lblMultipleChoice = new System.Windows.Forms.Label();
            this.lblShortAnswer = new System.Windows.Forms.Label();
            this.txtShortAnswer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFreeResponse = new System.Windows.Forms.Label();
            this.flpFreeResponse = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddFreeResponseKeyword = new System.Windows.Forms.Button();
            this.pnlNavigationPanel = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblJumpToQuestion = new System.Windows.Forms.Label();
            this.cboJumpToQuestion = new System.Windows.Forms.ComboBox();
            this.pnlMultipleChoice.SuspendLayout();
            this.pnlShortAnswer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlNavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Location = new System.Drawing.Point(9, 11);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(76, 13);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "Question Text:";
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestionText.Location = new System.Drawing.Point(12, 30);
            this.txtQuestionText.Multiline = true;
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(538, 68);
            this.txtQuestionText.TabIndex = 1;
            // 
            // lblQuestionType
            // 
            this.lblQuestionType.AutoSize = true;
            this.lblQuestionType.Location = new System.Drawing.Point(11, 107);
            this.lblQuestionType.Name = "lblQuestionType";
            this.lblQuestionType.Size = new System.Drawing.Size(79, 13);
            this.lblQuestionType.TabIndex = 2;
            this.lblQuestionType.Text = "Question Type:";
            // 
            // cboQuestionType
            // 
            this.cboQuestionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuestionType.FormattingEnabled = true;
            this.cboQuestionType.Items.AddRange(new object[] {
            "Multiple Choice",
            "Short Answer",
            "Free Response",
            "Label The Image",
            "True/False"});
            this.cboQuestionType.Location = new System.Drawing.Point(96, 104);
            this.cboQuestionType.Name = "cboQuestionType";
            this.cboQuestionType.Size = new System.Drawing.Size(150, 21);
            this.cboQuestionType.TabIndex = 3;
            // 
            // pnlMultipleChoice
            // 
            this.pnlMultipleChoice.Controls.Add(this.lblMultipleChoice);
            this.pnlMultipleChoice.Controls.Add(this.txtChoice4);
            this.pnlMultipleChoice.Controls.Add(this.txtChoice3);
            this.pnlMultipleChoice.Controls.Add(this.txtChoice2);
            this.pnlMultipleChoice.Controls.Add(this.txtChoice1);
            this.pnlMultipleChoice.Controls.Add(this.rbtChoice4);
            this.pnlMultipleChoice.Controls.Add(this.rbtChoice3);
            this.pnlMultipleChoice.Controls.Add(this.rbtChoice2);
            this.pnlMultipleChoice.Controls.Add(this.rbtChoice1);
            this.pnlMultipleChoice.Location = new System.Drawing.Point(12, 131);
            this.pnlMultipleChoice.Name = "pnlMultipleChoice";
            this.pnlMultipleChoice.Size = new System.Drawing.Size(214, 125);
            this.pnlMultipleChoice.TabIndex = 4;
            this.pnlMultipleChoice.Visible = false;
            // 
            // rbtChoice1
            // 
            this.rbtChoice1.AutoSize = true;
            this.rbtChoice1.Location = new System.Drawing.Point(15, 18);
            this.rbtChoice1.Name = "rbtChoice1";
            this.rbtChoice1.Size = new System.Drawing.Size(38, 17);
            this.rbtChoice1.TabIndex = 0;
            this.rbtChoice1.TabStop = true;
            this.rbtChoice1.Text = "A. ";
            this.rbtChoice1.UseVisualStyleBackColor = true;
            // 
            // rbtChoice2
            // 
            this.rbtChoice2.AutoSize = true;
            this.rbtChoice2.Location = new System.Drawing.Point(15, 41);
            this.rbtChoice2.Name = "rbtChoice2";
            this.rbtChoice2.Size = new System.Drawing.Size(38, 17);
            this.rbtChoice2.TabIndex = 0;
            this.rbtChoice2.TabStop = true;
            this.rbtChoice2.Text = "B. ";
            this.rbtChoice2.UseVisualStyleBackColor = true;
            // 
            // rbtChoice3
            // 
            this.rbtChoice3.AutoSize = true;
            this.rbtChoice3.Location = new System.Drawing.Point(15, 68);
            this.rbtChoice3.Name = "rbtChoice3";
            this.rbtChoice3.Size = new System.Drawing.Size(38, 17);
            this.rbtChoice3.TabIndex = 0;
            this.rbtChoice3.TabStop = true;
            this.rbtChoice3.Text = "C. ";
            this.rbtChoice3.UseVisualStyleBackColor = true;
            // 
            // rbtChoice4
            // 
            this.rbtChoice4.AutoSize = true;
            this.rbtChoice4.Location = new System.Drawing.Point(15, 94);
            this.rbtChoice4.Name = "rbtChoice4";
            this.rbtChoice4.Size = new System.Drawing.Size(39, 17);
            this.rbtChoice4.TabIndex = 0;
            this.rbtChoice4.TabStop = true;
            this.rbtChoice4.Text = "D. ";
            this.rbtChoice4.UseVisualStyleBackColor = true;
            // 
            // txtChoice1
            // 
            this.txtChoice1.Location = new System.Drawing.Point(59, 15);
            this.txtChoice1.Name = "txtChoice1";
            this.txtChoice1.Size = new System.Drawing.Size(145, 20);
            this.txtChoice1.TabIndex = 1;
            // 
            // txtChoice2
            // 
            this.txtChoice2.Location = new System.Drawing.Point(60, 41);
            this.txtChoice2.Name = "txtChoice2";
            this.txtChoice2.Size = new System.Drawing.Size(145, 20);
            this.txtChoice2.TabIndex = 1;
            // 
            // txtChoice3
            // 
            this.txtChoice3.Location = new System.Drawing.Point(60, 67);
            this.txtChoice3.Name = "txtChoice3";
            this.txtChoice3.Size = new System.Drawing.Size(145, 20);
            this.txtChoice3.TabIndex = 1;
            // 
            // txtChoice4
            // 
            this.txtChoice4.Location = new System.Drawing.Point(60, 93);
            this.txtChoice4.Name = "txtChoice4";
            this.txtChoice4.Size = new System.Drawing.Size(145, 20);
            this.txtChoice4.TabIndex = 1;
            // 
            // pnlShortAnswer
            // 
            this.pnlShortAnswer.Controls.Add(this.txtShortAnswer);
            this.pnlShortAnswer.Controls.Add(this.lblShortAnswer);
            this.pnlShortAnswer.Location = new System.Drawing.Point(12, 131);
            this.pnlShortAnswer.Name = "pnlShortAnswer";
            this.pnlShortAnswer.Size = new System.Drawing.Size(200, 58);
            this.pnlShortAnswer.TabIndex = 5;
            this.pnlShortAnswer.Visible = false;
            // 
            // lblMultipleChoice
            // 
            this.lblMultipleChoice.AutoSize = true;
            this.lblMultipleChoice.Location = new System.Drawing.Point(5, 2);
            this.lblMultipleChoice.Name = "lblMultipleChoice";
            this.lblMultipleChoice.Size = new System.Drawing.Size(48, 13);
            this.lblMultipleChoice.TabIndex = 6;
            this.lblMultipleChoice.Text = "Choices:";
            // 
            // lblShortAnswer
            // 
            this.lblShortAnswer.AutoSize = true;
            this.lblShortAnswer.Location = new System.Drawing.Point(3, 8);
            this.lblShortAnswer.Name = "lblShortAnswer";
            this.lblShortAnswer.Size = new System.Drawing.Size(45, 13);
            this.lblShortAnswer.TabIndex = 0;
            this.lblShortAnswer.Text = "Answer:";
            // 
            // txtShortAnswer
            // 
            this.txtShortAnswer.Location = new System.Drawing.Point(6, 24);
            this.txtShortAnswer.Name = "txtShortAnswer";
            this.txtShortAnswer.Size = new System.Drawing.Size(191, 20);
            this.txtShortAnswer.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddFreeResponseKeyword);
            this.panel1.Controls.Add(this.flpFreeResponse);
            this.panel1.Controls.Add(this.lblFreeResponse);
            this.panel1.Location = new System.Drawing.Point(12, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 264);
            this.panel1.TabIndex = 6;
            // 
            // lblFreeResponse
            // 
            this.lblFreeResponse.AutoSize = true;
            this.lblFreeResponse.Location = new System.Drawing.Point(3, 8);
            this.lblFreeResponse.Name = "lblFreeResponse";
            this.lblFreeResponse.Size = new System.Drawing.Size(106, 13);
            this.lblFreeResponse.TabIndex = 0;
            this.lblFreeResponse.Text = "Keywords In Answer:";
            // 
            // flpFreeResponse
            // 
            this.flpFreeResponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpFreeResponse.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFreeResponse.Location = new System.Drawing.Point(0, 32);
            this.flpFreeResponse.Name = "flpFreeResponse";
            this.flpFreeResponse.Size = new System.Drawing.Size(231, 229);
            this.flpFreeResponse.TabIndex = 1;
            // 
            // btnAddFreeResponseKeyword
            // 
            this.btnAddFreeResponseKeyword.Location = new System.Drawing.Point(156, 3);
            this.btnAddFreeResponseKeyword.Name = "btnAddFreeResponseKeyword";
            this.btnAddFreeResponseKeyword.Size = new System.Drawing.Size(75, 23);
            this.btnAddFreeResponseKeyword.TabIndex = 2;
            this.btnAddFreeResponseKeyword.Text = "Add";
            this.btnAddFreeResponseKeyword.UseVisualStyleBackColor = true;
            this.btnAddFreeResponseKeyword.Click += new System.EventHandler(this.BtnAddFreeResponseKeyword_Click);
            // 
            // pnlNavigationPanel
            // 
            this.pnlNavigationPanel.Controls.Add(this.btnNext);
            this.pnlNavigationPanel.Controls.Add(this.btnPrevious);
            this.pnlNavigationPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNavigationPanel.Location = new System.Drawing.Point(0, 401);
            this.pnlNavigationPanel.Name = "pnlNavigationPanel";
            this.pnlNavigationPanel.Size = new System.Drawing.Size(556, 25);
            this.pnlNavigationPanel.TabIndex = 7;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevious.Location = new System.Drawing.Point(0, 0);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 25);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<= Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Location = new System.Drawing.Point(481, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 25);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next =>";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblJumpToQuestion
            // 
            this.lblJumpToQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJumpToQuestion.AutoSize = true;
            this.lblJumpToQuestion.Location = new System.Drawing.Point(327, 9);
            this.lblJumpToQuestion.Name = "lblJumpToQuestion";
            this.lblJumpToQuestion.Size = new System.Drawing.Size(96, 13);
            this.lblJumpToQuestion.TabIndex = 8;
            this.lblJumpToQuestion.Text = "Jump To Question:";
            // 
            // cboJumpToQuestion
            // 
            this.cboJumpToQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboJumpToQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJumpToQuestion.FormattingEnabled = true;
            this.cboJumpToQuestion.Location = new System.Drawing.Point(429, 3);
            this.cboJumpToQuestion.Name = "cboJumpToQuestion";
            this.cboJumpToQuestion.Size = new System.Drawing.Size(121, 21);
            this.cboJumpToQuestion.TabIndex = 9;
            // 
            // frmQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 426);
            this.Controls.Add(this.cboJumpToQuestion);
            this.Controls.Add(this.lblJumpToQuestion);
            this.Controls.Add(this.pnlNavigationPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlShortAnswer);
            this.Controls.Add(this.pnlMultipleChoice);
            this.Controls.Add(this.cboQuestionType);
            this.Controls.Add(this.lblQuestionType);
            this.Controls.Add(this.txtQuestionText);
            this.Controls.Add(this.lblQuestionText);
            this.Name = "frmQuiz";
            this.Text = "New Quiz";
            this.pnlMultipleChoice.ResumeLayout(false);
            this.pnlMultipleChoice.PerformLayout();
            this.pnlShortAnswer.ResumeLayout(false);
            this.pnlShortAnswer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlNavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.TextBox txtQuestionText;
        private System.Windows.Forms.Label lblQuestionType;
        private System.Windows.Forms.ComboBox cboQuestionType;
        private System.Windows.Forms.Panel pnlMultipleChoice;
        private System.Windows.Forms.Label lblMultipleChoice;
        private System.Windows.Forms.TextBox txtChoice4;
        private System.Windows.Forms.TextBox txtChoice3;
        private System.Windows.Forms.TextBox txtChoice2;
        private System.Windows.Forms.TextBox txtChoice1;
        private System.Windows.Forms.RadioButton rbtChoice4;
        private System.Windows.Forms.RadioButton rbtChoice3;
        private System.Windows.Forms.RadioButton rbtChoice2;
        private System.Windows.Forms.RadioButton rbtChoice1;
        private System.Windows.Forms.Panel pnlShortAnswer;
        private System.Windows.Forms.TextBox txtShortAnswer;
        private System.Windows.Forms.Label lblShortAnswer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpFreeResponse;
        private System.Windows.Forms.Label lblFreeResponse;
        private System.Windows.Forms.Button btnAddFreeResponseKeyword;
        private System.Windows.Forms.Panel pnlNavigationPanel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblJumpToQuestion;
        private System.Windows.Forms.ComboBox cboJumpToQuestion;
    }
}