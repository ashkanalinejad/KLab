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
    public partial class RemovableDropDownControl : UserControl
    {
        public delegate void RemoveDelegate(RemovableDropDownControl sender);
        public RemoveDelegate Remove = delegate { };

        public delegate void ChangeContentDelegate(RemovableDropDownControl sender);
        public ChangeContentDelegate ChangeValue = delegate { };

        public RemovableDropDownControl()
        {
            InitializeComponent();
        }

        public string Value
        {
            get
            {
                return Content_CB.Text;
            }
            set
            {
                Content_CB.Text = value;
            }
        }

        public void SetMembers(String[] members)
        {
            if (members != null) 
                Content_CB.Items.AddRange(members);
        }

        private void Remove_BT_Click(object sender, EventArgs e)
        {
            Remove(this);
        }

        private void Content_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeValue(this);
        }
    }
}
