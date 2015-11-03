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
    public partial class AddRemoveMemSpecifiedList : UserControl
    {
        public delegate void RemoveItemDelegate(int index);
        public RemoveItemDelegate RemoveItem = delegate { };

        public delegate bool AddItemDelegate(string content);
        public AddItemDelegate AddItem = delegate { return true; };

        public delegate void ChangeItemDelegate(int index, string newContent);
        public ChangeItemDelegate ChangeItem = delegate { };

        private string[] _members;
        private readonly List<RemovableDropDownControl> _removableDropDownControls = new List<RemovableDropDownControl>();

        public AddRemoveMemSpecifiedList()
        {
            InitializeComponent();
        }

        public string[] Members
        {
            set
            {
                _members = value;
                NewContent_CB.Items.AddRange(_members);
                NewContent_CB.Text = _members.First();
            }
        }

        private void OnRemoveItemFromList(RemovableDropDownControl control)
        {
            List_TL.Controls.Remove(control);
            RemoveItem(_removableDropDownControls.FindIndex(x=>x==control));

            _removableDropDownControls.Remove(control);
        }

        private void OnItemValueChanged(RemovableDropDownControl control)
        {
            int index = _removableDropDownControls.FindIndex(x=>x==control);
            ChangeItem(index, control.Value);
        }

        private void AddNew_BT_Click(object sender, EventArgs e)
        {
            AddNewItemToList(NewContent_CB.Text);
        }

        public void AddNewItemToList(string itemName)
        {
            if (!AddItem(itemName))
                return;

            RemovableDropDownControl newC = new RemovableDropDownControl();
            newC.SetMembers(_members);
            newC.Value = itemName;
            newC.Remove += OnRemoveItemFromList;
            newC.ChangeValue += OnItemValueChanged;
            List_TL.Controls.Add(newC);
            _removableDropDownControls.Add(newC);
        }

        public void SetListItemsTexts(string[] texts)
        {
            List_TL.Controls.Clear();
            foreach (var text in texts)
            {
                RemovableDropDownControl newC = new RemovableDropDownControl();
                newC.SetMembers(_members);
                newC.Value = text;
                newC.Remove += OnRemoveItemFromList;
                newC.ChangeValue += OnItemValueChanged;
                List_TL.Controls.Add(newC);
                _removableDropDownControls.Add(newC);
            }
        }

        public List<string> ListContents
        {
            get
            {
                List<string> toret = new List<string>();

                for (int i = 0; i < _removableDropDownControls.Count; i++)
                {
                    toret.Add(_removableDropDownControls[i].Value);     
                }

                return toret;
            }
        }

        public void ClearItems()
        {
            List_TL.Controls.Clear();
            NewContent_CB.Items.Clear();
            NewContent_CB.Text = "";
        }
    }
}
