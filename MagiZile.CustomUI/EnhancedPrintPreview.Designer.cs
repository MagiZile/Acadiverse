namespace MagiZile.CustomUI
{
    partial class EnhancedPrintPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnhancedPrintPreview));
            this.ppcDocument = new System.Windows.Forms.PrintPreviewControl();
            this.tbrPrintPreview = new System.Windows.Forms.ToolStrip();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.sep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbZoomOut = new System.Windows.Forms.ToolStripButton();
            this.tsbZoomIn = new System.Windows.Forms.ToolStripButton();
            this.tsbZoomToFit = new System.Windows.Forms.ToolStripButton();
            this.sep2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslZoom = new System.Windows.Forms.ToolStripLabel();
            this.tscZoom = new System.Windows.Forms.ToolStripComboBox();
            this.tbrPrintPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // ppcDocument
            // 
            this.ppcDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ppcDocument.Location = new System.Drawing.Point(0, 28);
            this.ppcDocument.Name = "ppcDocument";
            this.ppcDocument.Size = new System.Drawing.Size(455, 301);
            this.ppcDocument.TabIndex = 0;
            // 
            // tbrPrintPreview
            // 
            this.tbrPrintPreview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrint,
            this.sep1,
            this.tsbZoomOut,
            this.tsbZoomIn,
            this.tsbZoomToFit,
            this.sep2,
            this.tslZoom,
            this.tscZoom});
            this.tbrPrintPreview.Location = new System.Drawing.Point(0, 0);
            this.tbrPrintPreview.Name = "tbrPrintPreview";
            this.tbrPrintPreview.Size = new System.Drawing.Size(455, 25);
            this.tbrPrintPreview.TabIndex = 1;
            this.tbrPrintPreview.Text = "toolStrip1";
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(36, 22);
            this.tsbPrint.Text = "Print";
            // 
            // sep1
            // 
            this.sep1.Name = "sep1";
            this.sep1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbZoomOut
            // 
            this.tsbZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("tsbZoomOut.Image")));
            this.tsbZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZoomOut.Name = "tsbZoomOut";
            this.tsbZoomOut.Size = new System.Drawing.Size(66, 22);
            this.tsbZoomOut.Text = "Zoom Out";
            this.tsbZoomOut.Click += new System.EventHandler(this.tsbZoomOut_Click);
            // 
            // tsbZoomIn
            // 
            this.tsbZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("tsbZoomIn.Image")));
            this.tsbZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZoomIn.Name = "tsbZoomIn";
            this.tsbZoomIn.Size = new System.Drawing.Size(56, 22);
            this.tsbZoomIn.Text = "Zoom In";
            this.tsbZoomIn.Click += new System.EventHandler(this.tsbZoomIn_Click);
            // 
            // tsbZoomToFit
            // 
            this.tsbZoomToFit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbZoomToFit.Image = ((System.Drawing.Image)(resources.GetObject("tsbZoomToFit.Image")));
            this.tsbZoomToFit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbZoomToFit.Name = "tsbZoomToFit";
            this.tsbZoomToFit.Size = new System.Drawing.Size(73, 22);
            this.tsbZoomToFit.Text = "Zoom to Fit";
            this.tsbZoomToFit.Click += new System.EventHandler(this.tsbZoomToFit_Click);
            // 
            // sep2
            // 
            this.sep2.Name = "sep2";
            this.sep2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslZoom
            // 
            this.tslZoom.Name = "tslZoom";
            this.tslZoom.Size = new System.Drawing.Size(42, 22);
            this.tslZoom.Text = "Zoom:";
            // 
            // tscZoom
            // 
            this.tscZoom.Items.AddRange(new object[] {
            "500%",
            "450%",
            "400%",
            "350%",
            "300%",
            "250%",
            "200%",
            "150%",
            "100%",
            "50%"});
            this.tscZoom.Name = "tscZoom";
            this.tscZoom.Size = new System.Drawing.Size(121, 25);
            this.tscZoom.SelectedIndexChanged += new System.EventHandler(this.tscZoom_SelectedIndexChanged);
            // 
            // EnhancedPrintPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 327);
            this.Controls.Add(this.tbrPrintPreview);
            this.Controls.Add(this.ppcDocument);
            this.MinimumSize = new System.Drawing.Size(382, 366);
            this.Name = "EnhancedPrintPreview";
            this.Text = "Print Preview";
            this.Load += new System.EventHandler(this.EnhancedPrintPreview_Load);
            this.tbrPrintPreview.ResumeLayout(false);
            this.tbrPrintPreview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tbrPrintPreview;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripSeparator sep1;
        private System.Windows.Forms.ToolStripButton tsbZoomOut;
        private System.Windows.Forms.ToolStripButton tsbZoomIn;
        private System.Windows.Forms.ToolStripButton tsbZoomToFit;
        private System.Windows.Forms.ToolStripSeparator sep2;
        private System.Windows.Forms.ToolStripLabel tslZoom;
        private System.Windows.Forms.ToolStripComboBox tscZoom;
        public System.Windows.Forms.PrintPreviewControl ppcDocument;

    }
}