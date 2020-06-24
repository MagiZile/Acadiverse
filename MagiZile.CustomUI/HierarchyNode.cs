using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagiZile.CustomUI
{
    public partial class HierarchyNode : UserControl
    {
        public HierarchyNode()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public bool valueEditingAllowed = true;

        public bool ValueEditingAllowed
        {
            get
            {
                return valueEditingAllowed;
            }
            set
            {
                valueEditingAllowed = value;
                btnAddValue.Visible = value;
                foreach (Control control in pnlNodeObjects.Controls)
                {
                    if (control.GetType() == typeof(HierarchyNodeValue))
                    {
                        HierarchyNodeValue nodeValue = (HierarchyNodeValue)control;
                        nodeValue.UserCanDelete = value;
                    }
                }
            }
        }
    }
}
