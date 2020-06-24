namespace MagiZile.CustomUI
{
    partial class HierarchyNodeValue
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtStringValue = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkBoolValue = new System.Windows.Forms.CheckBox();
            this.numDoubleValue = new System.Windows.Forms.NumericUpDown();
            this.trkIntValue = new System.Windows.Forms.TrackBar();
            this.cboEnumValue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDoubleValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkIntValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Value";
            // 
            // txtStringValue
            // 
            this.txtStringValue.Location = new System.Drawing.Point(48, 3);
            this.txtStringValue.Name = "txtStringValue";
            this.txtStringValue.Size = new System.Drawing.Size(147, 20);
            this.txtStringValue.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(202, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 55);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // chkBoolValue
            // 
            this.chkBoolValue.AutoSize = true;
            this.chkBoolValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkBoolValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoolValue.Location = new System.Drawing.Point(0, 0);
            this.chkBoolValue.Name = "chkBoolValue";
            this.chkBoolValue.Size = new System.Drawing.Size(237, 55);
            this.chkBoolValue.TabIndex = 3;
            this.chkBoolValue.Text = "Value";
            this.chkBoolValue.UseVisualStyleBackColor = true;
            this.chkBoolValue.Visible = false;
            // 
            // numDoubleValue
            // 
            this.numDoubleValue.Location = new System.Drawing.Point(48, 4);
            this.numDoubleValue.Name = "numDoubleValue";
            this.numDoubleValue.Size = new System.Drawing.Size(44, 20);
            this.numDoubleValue.TabIndex = 4;
            this.numDoubleValue.Visible = false;
            // 
            // trkIntValue
            // 
            this.trkIntValue.Location = new System.Drawing.Point(48, 4);
            this.trkIntValue.Name = "trkIntValue";
            this.trkIntValue.Size = new System.Drawing.Size(147, 45);
            this.trkIntValue.TabIndex = 5;
            this.trkIntValue.Visible = false;
            // 
            // cboEnumValue
            // 
            this.cboEnumValue.FormattingEnabled = true;
            this.cboEnumValue.Location = new System.Drawing.Point(49, 17);
            this.cboEnumValue.Name = "cboEnumValue";
            this.cboEnumValue.Size = new System.Drawing.Size(147, 21);
            this.cboEnumValue.TabIndex = 6;
            this.cboEnumValue.Visible = false;
            // 
            // HeirarchyNodeValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.cboEnumValue);
            this.Controls.Add(this.trkIntValue);
            this.Controls.Add(this.numDoubleValue);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtStringValue);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.chkBoolValue);
            this.Name = "HeirarchyNodeValue";
            this.Size = new System.Drawing.Size(237, 55);
            ((System.ComponentModel.ISupportInitialize)(this.numDoubleValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkIntValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtStringValue;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.CheckBox chkBoolValue;
        private System.Windows.Forms.NumericUpDown numDoubleValue;
        private System.Windows.Forms.TrackBar trkIntValue;
        private System.Windows.Forms.ComboBox cboEnumValue;
    }
}
