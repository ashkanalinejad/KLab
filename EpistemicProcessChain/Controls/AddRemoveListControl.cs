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
    public partial class AddRemoveListControl : UserControl
    {
        public delegate bool RemoveItemDelegate(string name);
        public RemoveItemDelegate RemoveItem = delegate { return true; };

        public delegate bool AddItemDelegate(string name);
        public AddItemDelegate AddItem = delegate{ return true; };

        public AddRemoveListControl()
        {
            InitializeComponent();
            addTextControl1.Add += OnAddItemToList;
        }

        public void AddItemToList(string s)
        {
            if (!AddItem(s))
                return;

            //TODO
            if (true)
            {
                RemovableTextControl newItem = new RemovableTextControl();
                newItem.Content = s;
                newItem.Remove += OnRemoveItemFromList;
                List_TL.Controls.Add(newItem);
            }
        }

        
        private void OnAddItemToList(string s)
        {
            AddItemToList(s);
        }  

        private void OnRemoveItemFromList(RemovableTextControl control)
        {
            if (RemoveItem(control.Content))
            {
                List_TL.Controls.Remove(control);
            }
        }

        public List<string> ListContents
        {
            get
            {
                List<string> toret = new List<string>();
                foreach (RemovableTextControl control in List_TL.Controls)
                {
                    toret.Add(control.Content);
                }

                return toret;
            }
        }

        public void AddTextToList(string text)
        {
            RemovableTextControl newItem = new RemovableTextControl();
            newItem.Content = text;
            newItem.Remove += OnRemoveItemFromList;
            List_TL.Controls.Add(newItem);
        }
    }
}
