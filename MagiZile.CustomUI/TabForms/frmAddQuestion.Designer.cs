namespace MagiZile.CustomUI.TabForms
{
    partial class frmAddQuestion
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
            this.lblQuestionType = new System.Windows.Forms.Label();
            this.cboQuestionType = new System.Windows.Forms.ComboBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestionType
            // 
            this.lblQuestionType.AutoSize = true;
            this.lblQuestionType.Location = new System.Drawing.Point(10, 10);
            this.lblQuestionType.Name = "lblQuestionType";
            this.lblQuestionType.Size = new System.Drawing.Size(79, 13);
            this.lblQuestionType.TabIndex = 0;
            this.lblQuestionType.Text = "Question Type:";
            // 
            // cboQuestionType
            // 
            this.cboQuestionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuestionType.FormattingEnabled = true;
            this.cboQuestionType.Items.AddRange(new object[] {
            "Multiple Choice",
            "Fill-In-The-Blanks",
            "Matching",
            "Short Answer",
            "Free Response",
            "True/False"});
            this.cboQuestionType.Location = new System.Drawing.Point(95, 7);
            this.cboQuestionType.Name = "cboQuestionType";
            this.cboQuestionType.Size = new System.Drawing.Size(121, 21);
            this.cboQuestionType.TabIndex = 1;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(10, 36);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(52, 13);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Question:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(68, 33);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(329, 53);
            this.textBox1.TabIndex = 3;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(5, 89);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(211, 13);
            this.lblNote.TabIndex = 4;
            this.lblNote.Text = "Question details can always be edited later.";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(314, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(233, 106);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddQuestion
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(401, 131);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.cboQuestionType);
            this.Controls.Add(this.lblQuestionType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddQuestion";
            this.Text = "Add Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestionType;
        private System.Windows.Forms.ComboBox cboQuestionType;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}