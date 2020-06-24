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
    public partial class HierarchyNodeValue : UserControl
    {
        public HierarchyNodeValue()
        {
            InitializeComponent();
        }

        public enum NodeValueType {Text, List, IntegerNumber, DoubleNumber, Bool};
        public NodeValueType type = NodeValueType.Text;
        public bool userCanDelete = true;

        public NodeValueType DataType
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                switch (value)
                {
                    case NodeValueType.Bool:
                        txtStringValue.Visible = false;
                        chkBoolValue.Visible = true;
                        numDoubleValue.Visible = false;
                        trkIntValue.Visible = false;
                        cboEnumValue.Visible = false;
                        break;
                    case NodeValueType.DoubleNumber:
                        txtStringValue.Visible = false;
                        chkBoolValue.Visible = false;
                        numDoubleValue.Visible = true;
                        trkIntValue.Visible = false;
                        cboEnumValue.Visible = false;
                        break;
                    case NodeValueType.IntegerNumber:
                        txtStringValue.Visible = false;
                        chkBoolValue.Visible = false;
                        numDoubleValue.Visible = false;
                        trkIntValue.Visible = true;
                        cboEnumValue.Visible = false;
                        break;
                    case NodeValueType.List:
                        txtStringValue.Visible = false;
                        chkBoolValue.Visible = false;
                        numDoubleValue.Visible = false;
                        trkIntValue.Visible = false;
                        cboEnumValue.Visible = true;
                        break;
                    default:
                        txtStringValue.Visible = true;
                        chkBoolValue.Visible = false;
                        numDoubleValue.Visible = false;
                        trkIntValue.Visible = false;
                        cboEnumValue.Visible = false;
                        break;
                }
            }
        }

        public bool UserCanDelete
        {
            get
            {
                return userCanDelete;
            }
            set
            {
                userCanDelete = value;
                btnDelete.Visible = value;
            }
        }
    }
}
