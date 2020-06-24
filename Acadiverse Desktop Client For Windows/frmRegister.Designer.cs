namespace AcadiverseDesktop
{
    partial class FrmRegister
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.rbtStudent = new System.Windows.Forms.RadioButton();
            this.rbtParent = new System.Windows.Forms.RadioButton();
            this.rbtTeacher = new System.Windows.Forms.RadioButton();
            this.mtxBirthday = new System.Windows.Forms.MaskedTextBox();
            this.lblPasswordStrength = new System.Windows.Forms.Label();
            this.lblPasswordRequirements = new System.Windows.Forms.Label();
            this.prgPasswordStrength = new System.Windows.Forms.ProgressBar();
            this.lblPasswordStrengthValue = new System.Windows.Forms.Label();
            this.chkAgreeToPolicies = new System.Windows.Forms.CheckBox();
            this.linkViewTermsOfService = new System.Windows.Forms.LinkLabel();
            this.lnkViewPrivacyPolicy = new System.Windows.Forms.LinkLabel();
            this.lnkViewCodeOfConduct = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(60, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(62, 44);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(24, 79);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(94, 13);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(-2, 241);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(124, 13);
            this.lblBirthday.TabIndex = 16;
            this.lblBirthday.Text = "Birth Date (mm/dd/yyyy):";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(77, 209);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(45, 13);
            this.lblAccountType.TabIndex = 12;
            this.lblAccountType.Text = "I am a...";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(130, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(189, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(130, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(189, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(130, 76);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(187, 20);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // rbtStudent
            // 
            this.rbtStudent.AutoSize = true;
            this.rbtStudent.Location = new System.Drawing.Point(124, 207);
            this.rbtStudent.Name = "rbtStudent";
            this.rbtStudent.Size = new System.Drawing.Size(62, 17);
            this.rbtStudent.TabIndex = 13;
            this.rbtStudent.TabStop = true;
            this.rbtStudent.Text = "Student";
            this.rbtStudent.UseVisualStyleBackColor = true;
            // 
            // rbtParent
            // 
            this.rbtParent.AutoSize = true;
            this.rbtParent.Location = new System.Drawing.Point(192, 207);
            this.rbtParent.Name = "rbtParent";
            this.rbtParent.Size = new System.Drawing.Size(56, 17);
            this.rbtParent.TabIndex = 14;
            this.rbtParent.TabStop = true;
            this.rbtParent.Text = "Parent";
            this.rbtParent.UseVisualStyleBackColor = true;
            // 
            // rbtTeacher
            // 
            this.rbtTeacher.AutoSize = true;
            this.rbtTeacher.Location = new System.Drawing.Point(254, 207);
            this.rbtTeacher.Name = "rbtTeacher";
            this.rbtTeacher.Size = new System.Drawing.Size(65, 17);
            this.rbtTeacher.TabIndex = 15;
            this.rbtTeacher.TabStop = true;
            this.rbtTeacher.Text = "Teacher";
            this.rbtTeacher.UseVisualStyleBackColor = true;
            // 
            // mtxBirthday
            // 
            this.mtxBirthday.Location = new System.Drawing.Point(128, 238);
            this.mtxBirthday.Mask = "00/00/0000";
            this.mtxBirthday.Name = "mtxBirthday";
            this.mtxBirthday.Size = new System.Drawing.Size(70, 20);
            this.mtxBirthday.TabIndex = 17;
            this.mtxBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // lblPasswordStrength
            // 
            this.lblPasswordStrength.AutoSize = true;
            this.lblPasswordStrength.Location = new System.Drawing.Point(19, 161);
            this.lblPasswordStrength.Name = "lblPasswordStrength";
            this.lblPasswordStrength.Size = new System.Drawing.Size(99, 13);
            this.lblPasswordStrength.TabIndex = 9;
            this.lblPasswordStrength.Text = "Password Strength:";
            // 
            // lblPasswordRequirements
            // 
            this.lblPasswordRequirements.AutoSize = true;
            this.lblPasswordRequirements.Location = new System.Drawing.Point(339, 41);
            this.lblPasswordRequirements.Name = "lblPasswordRequirements";
            this.lblPasswordRequirements.Size = new System.Drawing.Size(151, 104);
            this.lblPasswordRequirements.TabIndex = 4;
            this.lblPasswordRequirements.Text = "Password must be at least \r\n8 characters long and contain \r\nthe following:\r\n\r\nAt " +
    "least one capital letter.\r\nAt least one lowercase letter.\r\nAt least one number.\r" +
    "\nAt least one symbol.";
            // 
            // prgPasswordStrength
            // 
            this.prgPasswordStrength.Location = new System.Drawing.Point(130, 161);
            this.prgPasswordStrength.Maximum = 5;
            this.prgPasswordStrength.Name = "prgPasswordStrength";
            this.prgPasswordStrength.Size = new System.Drawing.Size(187, 13);
            this.prgPasswordStrength.TabIndex = 10;
            // 
            // lblPasswordStrengthValue
            // 
            this.lblPasswordStrengthValue.AutoSize = true;
            this.lblPasswordStrengthValue.Location = new System.Drawing.Point(127, 177);
            this.lblPasswordStrengthValue.Name = "lblPasswordStrengthValue";
            this.lblPasswordStrengthValue.Size = new System.Drawing.Size(54, 13);
            this.lblPasswordStrengthValue.TabIndex = 11;
            this.lblPasswordStrengthValue.Text = "Too Short";
            // 
            // chkAgreeToPolicies
            // 
            this.chkAgreeToPolicies.AutoSize = true;
            this.chkAgreeToPolicies.Location = new System.Drawing.Point(1, 273);
            this.chkAgreeToPolicies.Margin = new System.Windows.Forms.Padding(0);
            this.chkAgreeToPolicies.Name = "chkAgreeToPolicies";
            this.chkAgreeToPolicies.Size = new System.Drawing.Size(354, 17);
            this.chkAgreeToPolicies.TabIndex = 18;
            this.chkAgreeToPolicies.Text = "I agree to the Terms of Service, Privacy Policy, and Code of Conduct.";
            this.chkAgreeToPolicies.UseVisualStyleBackColor = true;
            // 
            // linkViewTermsOfService
            // 
            this.linkViewTermsOfService.AutoSize = true;
            this.linkViewTermsOfService.Location = new System.Drawing.Point(5, 290);
            this.linkViewTermsOfService.Name = "linkViewTermsOfService";
            this.linkViewTermsOfService.Size = new System.Drawing.Size(113, 13);
            this.linkViewTermsOfService.TabIndex = 19;
            this.linkViewTermsOfService.TabStop = true;
            this.linkViewTermsOfService.Text = "View Terms of Service";
            this.linkViewTermsOfService.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkViewTermsOfService_LinkClicked);
            // 
            // lnkViewPrivacyPolicy
            // 
            this.lnkViewPrivacyPolicy.AutoSize = true;
            this.lnkViewPrivacyPolicy.Location = new System.Drawing.Point(130, 290);
            this.lnkViewPrivacyPolicy.Name = "lnkViewPrivacyPolicy";
            this.lnkViewPrivacyPolicy.Size = new System.Drawing.Size(99, 13);
            this.lnkViewPrivacyPolicy.TabIndex = 20;
            this.lnkViewPrivacyPolicy.TabStop = true;
            this.lnkViewPrivacyPolicy.Text = "View Privacy Policy";
            this.lnkViewPrivacyPolicy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkViewPrivacyPolicy_LinkClicked);
            // 
            // lnkViewCodeOfConduct
            // 
            this.lnkViewCodeOfConduct.AutoSize = true;
            this.lnkViewCodeOfConduct.Location = new System.Drawing.Point(232, 290);
            this.lnkViewCodeOfConduct.Name = "lnkViewCodeOfConduct";
            this.lnkViewCodeOfConduct.Size = new System.Drawing.Size(113, 13);
            this.lnkViewCodeOfConduct.TabIndex = 21;
            this.lnkViewCodeOfConduct.TabStop = true;
            this.lnkViewCodeOfConduct.Text = "View Code of Conduct";
            this.lnkViewCodeOfConduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkViewCodeOfConduct_LinkClicked);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(334, 315);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 22;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(415, 315);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(77, 121);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // frmRegister
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(502, 351);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lnkViewCodeOfConduct);
            this.Controls.Add(this.lnkViewPrivacyPolicy);
            this.Controls.Add(this.linkViewTermsOfService);
            this.Controls.Add(this.chkAgreeToPolicies);
            this.Controls.Add(this.lblPasswordStrengthValue);
            this.Controls.Add(this.prgPasswordStrength);
            this.Controls.Add(this.lblPasswordRequirements);
            this.Controls.Add(this.lblPasswordStrength);
            this.Controls.Add(this.mtxBirthday);
            this.Controls.Add(this.rbtTeacher);
            this.Controls.Add(this.rbtParent);
            this.Controls.Add(this.rbtStudent);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.RadioButton rbtStudent;
        private System.Windows.Forms.RadioButton rbtParent;
        private System.Windows.Forms.RadioButton rbtTeacher;
        private System.Windows.Forms.MaskedTextBox mtxBirthday;
        private System.Windows.Forms.Label lblPasswordStrength;
        private System.Windows.Forms.Label lblPasswordRequirements;
        private System.Windows.Forms.ProgressBar prgPasswordStrength;
        private System.Windows.Forms.Label lblPasswordStrengthValue;
        private System.Windows.Forms.CheckBox chkAgreeToPolicies;
        private System.Windows.Forms.LinkLabel linkViewTermsOfService;
        private System.Windows.Forms.LinkLabel lnkViewPrivacyPolicy;
        private System.Windows.Forms.LinkLabel lnkViewCodeOfConduct;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}