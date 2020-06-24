namespace MagiZile.CustomUI
{
    partial class GridControl
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
            this.tlpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pic00 = new System.Windows.Forms.PictureBox();
            this.pic01 = new System.Windows.Forms.PictureBox();
            this.pic11 = new System.Windows.Forms.PictureBox();
            this.pic10 = new System.Windows.Forms.PictureBox();
            this.tlpLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpLayout
            // 
            this.tlpLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpLayout.ColumnCount = 2;
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLayout.Controls.Add(this.pic00, 0, 0);
            this.tlpLayout.Controls.Add(this.pic01, 1, 0);
            this.tlpLayout.Controls.Add(this.pic11, 1, 1);
            this.tlpLayout.Controls.Add(this.pic10, 0, 1);
            this.tlpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tlpLayout.Location = new System.Drawing.Point(0, 0);
            this.tlpLayout.Name = "tlpLayout";
            this.tlpLayout.RowCount = 2;
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpLayout.Size = new System.Drawing.Size(128, 128);
            this.tlpLayout.TabIndex = 0;
            // 
            // pic00
            // 
            this.pic00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic00.Location = new System.Drawing.Point(4, 4);
            this.pic00.Name = "pic00";
            this.pic00.Size = new System.Drawing.Size(58, 58);
            this.pic00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic00.TabIndex = 0;
            this.pic00.TabStop = false;
            // 
            // pic01
            // 
            this.pic01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic01.Location = new System.Drawing.Point(69, 4);
            this.pic01.Name = "pic01";
            this.pic01.Size = new System.Drawing.Size(58, 58);
            this.pic01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic01.TabIndex = 0;
            this.pic01.TabStop = false;
            // 
            // pic11
            // 
            this.pic11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic11.Location = new System.Drawing.Point(69, 69);
            this.pic11.Name = "pic11";
            this.pic11.Size = new System.Drawing.Size(58, 58);
            this.pic11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic11.TabIndex = 0;
            this.pic11.TabStop = false;
            // 
            // pic10
            // 
            this.pic10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic10.Location = new System.Drawing.Point(4, 69);
            this.pic10.Name = "pic10";
            this.pic10.Size = new System.Drawing.Size(58, 58);
            this.pic10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic10.TabIndex = 0;
            this.pic10.TabStop = false;
            // 
            // GridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpLayout);
            this.Name = "GridControl";
            this.Size = new System.Drawing.Size(128, 128);
            this.tlpLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpLayout;
        private System.Windows.Forms.PictureBox pic00;
        private System.Windows.Forms.PictureBox pic01;
        private System.Windows.Forms.PictureBox pic11;
        private System.Windows.Forms.PictureBox pic10;
    }
}
