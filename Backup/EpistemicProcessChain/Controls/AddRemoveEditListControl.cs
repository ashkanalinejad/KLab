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
    public partial class AddRemoveEditListControl : UserControl
    {
        public delegate bool RemoveItemDelegate(string name);
        public RemoveItemDelegate RemoveItem = delegate { return true; };

        public delegate bool AddItemDelegate(string name);
        public AddItemDelegate AddItem = delegate { return true; };

        public delegate void EditItemDelegate(string name);
        public EditItemDelegate EditItem = delegate { };

        public AddRemoveEditListControl()
        {
            InitializeComponent();
            addTextControl1.Add += OnAddItemToList;
        }

        public void OnAddItemToList(string s)
        {
            if(!AddItem(s))
                return;

            //TODO
            if (true)
            {
                RemovableEditableTextControl newItem = new RemovableEditableTextControl {Content = s};
                newItem.Remove += OnRemoveItemFromList;
                newItem.Edit += OnEditItem;
                List_TL.Controls.Add(newItem);
            }
        }

        private void OnRemoveItemFromList(RemovableEditableTextControl control)
        {
            if(RemoveItem(control.Content))
                List_TL.Controls.Remove(control);
        }

        private void OnEditItem(RemovableEditableTextControl control)
        {
            EditItem(control.Content);
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
            RemovableEditableTextControl newItem = new RemovableEditableTextControl { Content = text };
            newItem.Remove += OnRemoveItemFromList;
            newItem.Edit += OnEditItem;
            List_TL.Controls.Add(newItem);
        }
    }
}
