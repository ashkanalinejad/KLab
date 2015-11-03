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
    public partial class RemovableEditableTextControl : UserControl
    {

        public delegate void Remover(RemovableEditableTextControl control);
        public Remover Remove = delegate{};

        public delegate void Editor(RemovableEditableTextControl control);
        public Editor Edit = delegate{};

        public RemovableEditableTextControl()
        {
            InitializeComponent();
        }

        public string Content
        {
            set { Text_LB.Text = value; }
            get { return Text_LB.Text; }
        }

        private void Edit_BT_Click(object sender, EventArgs e)
        {
            Edit(this);
        }

        private void Remove_BT_Click(object sender, EventArgs e)
        {
            Remove(this);
        }
    }
}
