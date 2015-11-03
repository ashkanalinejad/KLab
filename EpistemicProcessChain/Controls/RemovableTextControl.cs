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
    public partial class RemovableTextControl : UserControl
    {

        public delegate void RemoveDelegate(RemovableTextControl control);
        public RemoveDelegate Remove = delegate{};

        public RemovableTextControl()
        {
            InitializeComponent();
        }

        public string Content
        {
            set { Text_LB.Text = value; }
            get { return Text_LB.Text; }
        }

        private void Remove_PB_Click(object sender, EventArgs e)
        {
            Remove(this);
        }
    }
}
