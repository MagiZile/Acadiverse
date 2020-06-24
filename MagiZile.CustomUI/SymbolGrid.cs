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
    public partial class SymbolGrid : UserControl
    {
        public SymbolGrid()
        {
            InitializeComponent();
        }

        public string SelectedSymbol = "";

        /// <summary>
        /// This event occurs when the user selects a symbol.
        /// </summary>
        public event EventHandler SymbolSelected;

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            lblDescription.Text = "Symbol: Square Root";
            SelectedSymbol = btnSquareRoot.Text;
            SymbolSelected?.Invoke(this, e);
        }

        private void btnNotEqualTo_Click(object sender, EventArgs e)
        {
            lblDescription.Text = "Symbol: Not Equal To";
            SelectedSymbol = btnNotEqualTo.Text;
            SymbolSelected?.Invoke(this, e);
        }

        private void btnGreaterThanOrEqualTo_Click(object sender, EventArgs e)
        {
            lblDescription.Text = "Symbol: Greater Than/Equal To";
            SelectedSymbol = btnGreaterThanOrEqualTo.Text;
            SymbolSelected?.Invoke(this, e);
        }

        private void btnLessThanOrEqualTo_Click(object sender, EventArgs e)
        {
            lblDescription.Text = "Symbol: Less Than/Equal To";
            SelectedSymbol = btnLessThanOrEqualTo.Text;
            SymbolSelected?.Invoke(this, e);
        }

        private void btnInfinity_Click(object sender, EventArgs e)
        {
            lblDescription.Text = "Symbol: Infinity";
            SelectedSymbol = btnInfinity.Text;
            SymbolSelected?.Invoke(this, e);
        }

        private void btnMultiplicationSign_Click(object sender, EventArgs e)
        {
            lblDescription.Text = "Symbol: Multiplication Sign";
            SelectedSymbol = btnMultiplicationSign.Text;
            SymbolSelected?.Invoke(this, e);
        }

        private void btnDivisionSign_Click(object sender, EventArgs e)
        {
            lblDescription.Text = "Symbol: Division Sign";
            SelectedSymbol = btnDivisionSign.Text;
            SymbolSelected?.Invoke(this, e);
        }

        private void btnPlusOrMinus_Click(object sender, EventArgs e)
        {
            lblDescription.Text = "Symbol: Plus/Minus";
            SelectedSymbol = btnPlusOrMinus.Text;
            SymbolSelected?.Invoke(this, e);
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            lblDescription.Text = "Symbol: Sum";
            SelectedSymbol = btnSum.Text;
            SymbolSelected?.Invoke(this, e);
        }
    }
}
