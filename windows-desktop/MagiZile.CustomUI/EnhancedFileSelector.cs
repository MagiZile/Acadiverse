using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI
{
    public partial class EnhancedFileSelector : Form
    {
        public EnhancedFileSelector()
        {
            InitializeComponent();
        }

        public MagiZile.CustomUI.FileSelectorControl.FileMode Mode
        {
            get
            {
                return objFileSelector.Mode;
            }
            set
            {
                if (objFileSelector.Mode == FileSelectorControl.FileMode.Save)
                {
                    btnSelect.Text = "Save";
                }
                else
                {
                    btnSelect.Text = "Select";
                }
                objFileSelector.Mode = value;
            }
        }

        public string[] FileFilter
        {
            get
            {
                return objFileSelector.FileFilter;
            }
            set
            {
                objFileSelector.FileFilter = value;
            }
        }

        public string StartingPath
        {
            get
            {
                return objFileSelector.StartingPath;
            }
            set
            {
                objFileSelector.StartingPath = value;
            }
        }

        public string Selection
        {
            get
            {
                return objFileSelector.Selection;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
