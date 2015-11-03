using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KLab.Models;
using KLab.Models.ActionModels;
using KLab.Models.ActionModels.Announcement;
using KLab.Properties;

namespace KLab
{
    public partial class KLabMainForm : Form
    {
        public EpistemicModel EpisModel = new EpistemicModel();

        public KLabMainForm()
        {
            InitializeComponent();

            agents_ARL.AddItem += OnAgentAdded;
            agents_ARL.RemoveItem += OnAgentRemoved;

            atomics_ARL.AddItem += OnAtomicAdded;
            atomics_ARL.RemoveItem += OnAtomicRemoved;

            ActionModels_ARL.AddItem += OnActionModelAdded;
            ActionModels_ARL.RemoveItem += OnActionModelRemoved;
            ActionModels_ARL.EditItem += OnActionModelEdited;

            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Filter = "Epistemic Model Description |*.emd|Epistemic Process Chain |*.epc";
        }


        private void OnActionModelRemoved(string name)
        {
            EpisModel.RemoveActionModelInfo(name);
        }

        private void CreateActionModelInfo(string name , ActionModelType type)
        {
            switch (type)
            {
                case(ActionModelType.SecretAnnouncement):
                    {
                        EpisModel.CreateSecretAnnouncementInfo(name);
                        break;
                    }
                case (ActionModelType.PublicAnnouncement):
                    {
                        EpisModel.CreatePublicAnnouncementInfo(name);
                        break;
                    }
            } 
        }

        private bool OnActionModelAdded(string name)
        {
            ActionTypeSelectionForm typeSelectionForm = new ActionTypeSelectionForm();
            typeSelectionForm.ActionInfoName = name;
            typeSelectionForm.SelectActionType += CreateActionModelInfo; 
            typeSelectionForm.ShowDialog();
            return !typeSelectionForm.Canceled;
        }

        private void OnActionModelEdited(string name)
        {
            ActionModelType? type = EpisModel.FindTypeOfAction(name);
            switch (type)
            {
                case(ActionModelType.SecretAnnouncement):
                    {
                        SecretAnnouncementEditor ActionModelEditor = new SecretAnnouncementEditor();
                        SecretAnnouncementInfo modelInfo = EpisModel.GetSecretAnnouncementInfo(name);
                        if (modelInfo != null)
                        {
                            ActionModelEditor.SetOriginalActionModel(modelInfo);
                            ActionModelEditor.ShowDialog();
                        }
                        break;
                    }
                case (ActionModelType.PublicAnnouncement):
                    {
                        PublicAnnouncementEditor ActionModelEditor = new PublicAnnouncementEditor();
                        PublicAnnouncementInfo modelInfo = EpisModel.GetPublicAnnouncementInfo(name);
                        if (modelInfo != null)
                        {
                            ActionModelEditor.SetOriginalActionModel(modelInfo);
                            ActionModelEditor.ShowDialog();
                        }
                        break;
                    }
            }
            
        }

        private void OnAtomicRemoved(string name)
        {
            EpisModel.RemoveAtomic(name);
        }

        private bool OnAtomicAdded(string name)
        {
            return EpisModel.AddAtomic(name);
        }

        private void OnAgentRemoved(string name)
        {
            EpisModel.RemoveAgent(name);
        }

        private bool OnAgentAdded(string name)
        {
            return EpisModel.AddAgent(name);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string path = saveFileDialog1.FileName;
            File.WriteAllLines(path,EpisModel.SaveModelAsText());
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            string path = openFileDialog1.FileName;
            string[] data = File.ReadAllLines(path);
            EpistemicModel newModel = EpistemicModel.FromText(ref data);

            if(newModel!=null)
            {
                EpisModel.Clear();
                FillFormWithModel(newModel);
            }
            else
            {
                MessageBox.Show(Resources.Loading_emd_Error);
            }
        }

        private void FillFormWithModel(EpistemicModel newModel)
        {
            agents_ARL.ClearItems();
            foreach (string agentName in newModel.GetAgentNames())
            {
                agents_ARL.AddItemToList(agentName);
            }

            atomics_ARL.ClearItems();
            foreach (string atomicName in newModel.GetAtomicNames())
            {
                atomics_ARL.AddItemToList(atomicName);
            }


            ActionModels_ARL.ClearItems();
            foreach (string secretName in newModel.GetSecretAnnouncementInfoNames())
            {
                ActionModels_ARL.AddTextToList(secretName);
                EpisModel.CreateSecretAnnouncementInfo(secretName);
                EpisModel.GetSecretAnnouncementInfo(secretName)
                    .CopyFrom(newModel.GetSecretAnnouncementInfo(secretName));
            }

            foreach (string publicName in newModel.GetPublicAnnouncementInfoNames())
            {
                ActionModels_ARL.AddTextToList(publicName);
                EpisModel.CreatePublicAnnouncementInfo(publicName);
                EpisModel.GetPublicAnnouncementInfo(publicName)
                    .CopyFrom(newModel.GetPublicAnnouncementInfo(publicName));
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
