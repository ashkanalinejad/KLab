using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KLab.Models;

namespace KLab.Controls
{
    public partial class ProcessEditPanel : UserControl
    {
        private string _procName;
        private EpistemicProcess _process;

        public delegate void ChangeSourceDelegate(string procName, string newSource);
        public ChangeSourceDelegate ChangeSource = delegate { };

        public delegate void ChangedResaultDelegate(string procName, string newResault);
        public ChangedResaultDelegate ChangeResault = delegate { };

        public delegate bool AddActionDelegate(string procName , string actionName);
        public AddActionDelegate AddAction = delegate { return true; };

        public delegate void ChangeActionDelegate(string procName,int index ,string newActionName);
        public ChangeActionDelegate ChangeAction = delegate { };

        public delegate void RemoveActionDelegate(string procName, int index);
        public RemoveActionDelegate RemoveAction = delegate { };

        public ProcessEditPanel()
        {
            InitializeComponent();

            ActionList_ARDDL.AddItem += OnItemAddedToActions;
            ActionList_ARDDL.ChangeItem += OnItemChangedInActions;
            ActionList_ARDDL.RemoveItem += OnItemRemovedFromActions;
        }

        public bool OnItemAddedToActions(string actionName)
        {
            return AddAction(_procName, actionName);
        }

        public void OnItemChangedInActions(int index ,string newActionName)
        {
            ChangeAction(_procName, index, newActionName);
        }

        public void OnItemRemovedFromActions(int index)
        {
            RemoveAction(_procName, index);
        }

        public void SetPanelData(string[] modelNames, string[] actionName)
        {
            Source_CB.Items.AddRange(modelNames);
            Resault_CB.Items.AddRange(modelNames);

            ActionList_ARDDL.Members = actionName;
        }

        public EpistemicProcess Process
        {
            set 
            { 
                _process = value;
                SyncAppearenceWithProcess();
            }
        }

        private void SyncAppearenceWithProcess()
        {
            Source_CB.Text = _process.GetStartName();
            Resault_CB.Text = _process.GetResaultName();
            string[] actnames = _process.GetActionNames();
            ActionList_ARDDL.SetListItemsTexts(actnames);
        }

        public string ProcName
        {
            get
            {
                return _procName;
            }
            set
            {
                _procName = value;
                SetHeader(_procName);
            }
        }

        private void SetHeader(string name)
        {
            EpisProcName_LB.Text = name;
        }

        private void Source_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeSource(ProcName, Source_CB.SelectedItem.ToString());
        }

        private void Resault_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeResault(ProcName, Resault_CB.SelectedItem.ToString());
        }

        public void ResetAppearence()
        {
            EpisProcName_LB.Text = "";
            Source_CB.Items.Clear();
            Source_CB.Text = "";
            Resault_CB.Items.Clear();
            Resault_CB.Text = "";
            ActionList_ARDDL.ClearItems();
        }
    }
}
