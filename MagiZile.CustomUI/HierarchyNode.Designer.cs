namespace MagiZile.CustomUI
{
    partial class HierarchyNode
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
            this.components = new System.ComponentModel.Container();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblNodeTitle = new System.Windows.Forms.Label();
            this.pnlNodeObjects = new System.Windows.Forms.Panel();
            this.objNodeValue = new MagiZile.CustomUI.HierarchyNodeValue();
            this.cmuValueActions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trueFalseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wholeNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberWDecimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteValueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.pnlNodeObjects.SuspendLayout();
            this.cmuValueActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(225, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(21, 22);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNodeTitle
            // 
            this.lblNodeTitle.AutoSize = true;
            this.lblNodeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNodeTitle.Location = new System.Drawing.Point(3, -3);
            this.lblNodeTitle.Name = "lblNodeTitle";
            this.lblNodeTitle.Size = new System.Drawing.Size(61, 24);
            this.lblNodeTitle.TabIndex = 1;
            this.lblNodeTitle.Text = "Node";
            // 
            // pnlNodeObjects
            // 
            this.pnlNodeObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNodeObjects.AutoSize = true;
            this.pnlNodeObjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNodeObjects.Controls.Add(this.objNodeValue);
            this.pnlNodeObjects.Location = new System.Drawing.Point(3, 24);
            this.pnlNodeObjects.Name = "pnlNodeObjects";
            this.pnlNodeObjects.Size = new System.Drawing.Size(243, 123);
            this.pnlNodeObjects.TabIndex = 2;
            // 
            // objNodeValue
            // 
            this.objNodeValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.objNodeValue.AutoSize = true;
            this.objNodeValue.ContextMenuStrip = this.cmuValueActions;
            this.objNodeValue.DataType = MagiZile.CustomUI.HierarchyNodeValue.NodeValueType.Text;
            this.objNodeValue.Location = new System.Drawing.Point(3, 3);
            this.objNodeValue.Name = "objNodeValue";
            this.objNodeValue.Size = new System.Drawing.Size(236, 26);
            this.objNodeValue.TabIndex = 0;
            this.objNodeValue.UserCanDelete = true;
            // 
            // cmuValueActions
            // 
            this.cmuValueActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.trueFalseToolStripMenuItem,
            this.wholeNumberToolStripMenuItem,
            this.numberWDecimalToolStripMenuItem,
            this.listToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteValueToolStripMenuItem});
            this.cmuValueActions.Name = "cmuValueActions";
            this.cmuValueActions.Size = new System.Drawing.Size(182, 142);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Checked = true;
            this.textToolStripMenuItem.CheckOnClick = true;
            this.textToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.textToolStripMenuItem.Text = "&Text";
            // 
            // trueFalseToolStripMenuItem
            // 
            this.trueFalseToolStripMenuItem.CheckOnClick = true;
            this.trueFalseToolStripMenuItem.Name = "trueFalseToolStripMenuItem";
            this.trueFalseToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.trueFalseToolStripMenuItem.Text = "T&rue/False";
            // 
            // wholeNumberToolStripMenuItem
            // 
            this.wholeNumberToolStripMenuItem.CheckOnClick = true;
            this.wholeNumberToolStripMenuItem.Name = "wholeNumberToolStripMenuItem";
            this.wholeNumberToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.wholeNumberToolStripMenuItem.Text = "&Whole Number";
            // 
            // numberWDecimalToolStripMenuItem
            // 
            this.numberWDecimalToolStripMenuItem.CheckOnClick = true;
            this.numberWDecimalToolStripMenuItem.Name = "numberWDecimalToolStripMenuItem";
            this.numberWDecimalToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.numberWDecimalToolStripMenuItem.Text = "&Number w/ Decimal";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.CheckOnClick = true;
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listToolStripMenuItem.Text = "&List";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 6);
            // 
            // deleteValueToolStripMenuItem
            // 
            this.deleteValueToolStripMenuItem.Name = "deleteValueToolStripMenuItem";
            this.deleteValueToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deleteValueToolStripMenuItem.Text = "&Delete";
            // 
            // btnAddValue
            // 
            this.btnAddValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddValue.Location = new System.Drawing.Point(196, 0);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(24, 23);
            this.btnAddValue.TabIndex = 3;
            this.btnAddValue.Text = "+";
            this.btnAddValue.UseVisualStyleBackColor = true;
            // 
            // HierarchyNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.btnAddValue);
            this.Controls.Add(this.pnlNodeObjects);
            this.Controls.Add(this.lblNodeTitle);
            this.Controls.Add(this.btnDelete);
            this.Name = "HierarchyNode";
            this.Size = new System.Drawing.Size(246, 150);
            this.pnlNodeObjects.ResumeLayout(false);
            this.pnlNodeObjects.PerformLayout();
            this.cmuValueActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblNodeTitle;
        private System.Windows.Forms.Panel pnlNodeObjects;
        private HierarchyNodeValue objNodeValue;
        private System.Windows.Forms.Button btnAddValue;
        private System.Windows.Forms.ContextMenuStrip cmuValueActions;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trueFalseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wholeNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numberWDecimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteValueToolStripMenuItem;
    }
}
