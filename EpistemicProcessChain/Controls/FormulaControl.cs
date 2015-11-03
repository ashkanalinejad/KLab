using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EpistemicProcessChain.Models;

namespace KLab.Controls
{
    public partial class FormulaControl : UserControl
    {
        public Formula Formula = null;

        public FormulaControl()
        {
            InitializeComponent();
        }

        private void Formula_TB_Leave(object sender, EventArgs e)
        {
            Formula.Expression = Formula_TB.Text;
        }

        private void Formula_TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
                Formula.Expression = Formula_TB.Text;
        }

        public void InitializeFormula()
        {
            Formula = new Formula();
        }

        public void SetFormulaExpression(string s)
        {
            Formula.Expression = s;
            Formula_TB.Text = s;
        }
    }
}
