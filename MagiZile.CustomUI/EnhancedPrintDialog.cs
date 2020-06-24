using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI
{
    public partial class EnhancedPrintDialog : Form
    {
        public EnhancedPrintDialog()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnhancedPrintDialog_Load(object sender, EventArgs e)
        {
            ImageList objImages = new ImageList();
            objImages.Images.Add(Properties.Resources.ico_printer);
            objImages.Images.Add(Properties.Resources.ico_printer_default);
            lvwPrinters.SmallImageList = objImages;
            lvwPrinters.LargeImageList = objImages;
            lvwPrinters.StateImageList = objImages;
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                PrinterSettings objPrinter = new PrinterSettings();
                objPrinter.PrinterName = printer;
                ListViewItem objItem = new ListViewItem();
                objItem.Text = printer;
                if (objPrinter.IsDefaultPrinter)
                {
                    objItem.ImageIndex = 1;
                }
                else
                {
                    objItem.ImageIndex = 0;
                }
                lvwPrinters.Items.Add(objItem);
            }
        }

        private void lvwPrinters_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrinterSettings objPrinterSettings = new PrinterSettings();
            objPrinterSettings.PrinterName = lvwPrinters.SelectedItems[0].Text;
            
        }
    }
}
