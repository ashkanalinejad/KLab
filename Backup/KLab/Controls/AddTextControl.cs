using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KLab.Controls
{
    
    public partial class AddTextControl : UserControl
    {
        public delegate void AddDelegate(string text);
        public AddDelegate Add = delegate{};

        public AddTextControl()
        {
            InitializeComponent();
        }

        private void Add_PB_Click(object sender, EventArgs e)
        {
            string text = Text_TB.Text;
            if (text != "")
            {
                Add(text);
                Text_TB.Text = "";
            }
        }
    }
}
