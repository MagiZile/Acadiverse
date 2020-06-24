using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI
{
    public partial class EnhancedPrintPreview : Form
    {
        public EnhancedPrintPreview()
        {
            InitializeComponent();
        }

        enum ZoomChangeType { ZoomIn, ZoomOut, ZoomToFit };

        /// <summary>
        /// Changes the zoom level of the document.
        /// </summary>
        /// <param name="zoom">The amount to zoom.</param>
        /// <param name="ZoomChange">The type of zoom.</param>
        void ChangeZoom(double zoom, ZoomChangeType ZoomChange)
        {
            try
            {
                switch (ZoomChange)
                {
                    case ZoomChangeType.ZoomIn:
                        ppcDocument.Zoom += zoom;
                        break;

                    case ZoomChangeType.ZoomOut:
                        ppcDocument.Zoom -= zoom;
                        break;

                    case ZoomChangeType.ZoomToFit:
                        ppcDocument.Zoom = 1;
                        break;
                }
                tscZoom.Text = (ppcDocument.Zoom * 100).ToString() + "%";
            }
            catch
            {
                //Ignore the error.
            }
        }

        private void tsbZoomToFit_Click(object sender, EventArgs e)
        {
            ChangeZoom(1, ZoomChangeType.ZoomToFit);
        }

        private void tsbZoomIn_Click(object sender, EventArgs e)
        {
            ChangeZoom(0.2, ZoomChangeType.ZoomIn);
        }

        private void tsbZoomOut_Click(object sender, EventArgs e)
        {
            ChangeZoom(0.2, ZoomChangeType.ZoomOut);
        }

        private void EnhancedPrintPreview_Load(object sender, EventArgs e)
        {
            ppcDocument.Zoom = 0.4;
            tscZoom.Text = (ppcDocument.Zoom * 100).ToString() + "%";
        }

        private void tscZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ppcDocument.Zoom = Convert.ToDouble(tscZoom.Text.Replace("%", "")) / 100;
        }
    }
}
