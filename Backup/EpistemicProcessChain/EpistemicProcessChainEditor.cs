using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EpistemicProcessChain.Models;
using EpistemicProcessChain.Properties;

namespace EpistemicProcessChain
{
    public partial class EpistemicProcessChainEditor : Form
    {
        private ProcessChain _processChain = new ProcessChain();

        public EpistemicProcessChainEditor()
        {
            InitializeComponent();

            EpisProcess_ARE.AddItem += OnProcessAdded;
            EpisProcess_ARE.RemoveItem += OnProcessRemoved;
            EpisProcess_ARE.EditItem += OnProcessEdit;

            EpisModels_AR.AddItem += OnModelAdded;
            EpisModels_AR.RemoveItem += OnModelRemoved;

            EpisProcEditPanel.ChangeSource += OnProcessSourceChanged;
            EpisProcEditPanel.ChangeResault += OnProcessResaultChanged;
            EpisProcEditPanel.AddAction += OnActionAddedToProcess;
            EpisProcEditPanel.ChangeAction += OnActionChangedInProcess;
            EpisProcEditPanel.RemoveAction += OnActionRemovedFromProcess;

            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "Epistemic Model Description |*.emd|Epistemic Process Chain |*.epc";

        }

        public void SetEpisModel(EpistemicModel model)
        {
            _processChain = new ProcessChain(model);
        }

        private void OnProcessEdit(string name)
        {
            EpisProcEditPanel.ResetAppearence();
            EpisProcEditPanel.ProcName = name;
            EpisProcEditPanel.SetPanelData(_processChain.GetModelNames(), _processChain.GetActionModelNames());
            EpisProcEditPanel.Process = _processChain.GetProcess(name);
            EpisProcEditPanel.Visible = true;
        }


        private bool OnProcessAdded(string name)
        {
            if (_processChain.ContainsProcessWithName(name))
                return false;

            _processChain.CreateNewProcess(name);
            return true;
        }

        public bool OnProcessRemoved(string name)
        {
            _processChain.RemoveProcess(name);
            return true;
        }



        private bool OnModelAdded(string name)
        {
            if (_processChain.ContainsModelWithName(name))
                return false;

            _processChain.CreateNewModel(name);
            return true;
        }

        public bool OnModelRemoved(string name)
        {
            bool b = true;
            b = _processChain.RemoveModel(name);
            if (b) return true;
            MessageBox.Show("Raw Model can not be deleted");
            return false;
        }

        public void OnProcessSourceChanged(string procName, string newSource)
        {
            _processChain.SetProcessSource(procName , newSource);
        }

        public void OnProcessResaultChanged(string procName, string newResault)
        {
            _processChain.SetProcessResault(procName , newResault);
        }

        public bool OnActionAddedToProcess(string procName, string actionName)
        {
            _processChain.AddActionToProcess(procName , actionName);
            return true;
        }

        public void OnActionChangedInProcess(string procName, int index, string newActionName)
        {
            _processChain.ChangeActionOfProcessAtIndex(procName ,index , newActionName);
        }

        public void OnActionRemovedFromProcess(string procName, int index)
        {
            _processChain.RemoveActionFromProcess(procName,index);
        }

        private void Generator_BT_Click(object sender, EventArgs e)
        {
            _processChain.Run();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string path = saveFileDialog1.FileName;
            string[] whole = _processChain.SaveAsText();
            File.WriteAllLines(path, whole.ToArray());
        }

        private bool? LoadingProcedure()
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                if (dialogResult == DialogResult.Cancel)
                {
                    return null;
                }
                else
                {
                    return false;
                }
            }

            ProcessChain newChain = null;

            string path = openFileDialog1.FileName;
            string[] data = File.ReadAllLines(path);
            newChain = ProcessChain.FromText(data);
            if (newChain != null)
            {
                _processChain = newChain;
                FillFormWithProcessChain(_processChain);
                return true;
            }
            else
            {
                MessageBox.Show(Resources.Loading_epc_Error);
                return false;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            ProcessChain newChain = null;

            string path = openFileDialog1.FileName;
            string[] data = File.ReadAllLines(path);
            newChain = ProcessChain.FromText(data);
            if (newChain != null)
            {
                _processChain = newChain;
                FillFormWithProcessChain(_processChain);
            }
            else
            {
                MessageBox.Show(Resources.Loading_epc_Error);
            }
        }

        private void FillFormWithProcessChain(ProcessChain processChain)
        {
            foreach (var modelName in processChain.GetModelNames())
            {
                EpisModels_AR.AddTextToList(modelName);
            }

            foreach (var procName in processChain.GetProcessNames())
            {
                EpisProcess_ARE.AddTextToList(procName);   
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EpistemicProcessChainEditor_Load(object sender, EventArgs e)
        {
            bool? res = LoadingProcedure();
            while (res!=true)
            {
                if (res != null)
                {
                    MessageBox.Show("Please Select a model");
                    res = LoadingProcedure();
                }
                else
                {
                    this.Close();
                    break;
                }
            }          
        }
    }
}
