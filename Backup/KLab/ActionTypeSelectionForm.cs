using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KLab.Models.ActionModels;
using KLab.Properties;

namespace KLab
{
    public partial class ActionTypeSelectionForm : Form
    {
        public string ActionInfoName;
        public bool Canceled = true;

        public delegate void SelectTypeDelegate(string name , ActionModelType type);
        public SelectTypeDelegate SelectActionType = delegate { };

        public ActionTypeSelectionForm()
        {
            InitializeComponent();
            this.Text += " : " + ActionInfoName;
        }

        private void Ok_BT_Click(object sender, EventArgs e)
        {
            if (Actions_List.SelectedIndex == -1)
            {
                MessageBox.Show(Resources.NoSelectionAlert);
                return;
            }

            ActionModelType type = ActionModelType.SecretAnnouncement;
            switch (Actions_List.SelectedItem.ToString())
            {
                case("Secret Announcement"):
                    {
                        type = ActionModelType.SecretAnnouncement;
                        break;
                    }
                case ("Public Announcement"):
                    {
                        type = ActionModelType.PublicAnnouncement;
                        break;
                    }
            }

            SelectActionType(ActionInfoName , type);
            Canceled = false;
            this.Close();
        }

        private void Cancel_BT_Click(object sender, EventArgs e)
        {
            Canceled = true;
            this.Close();
        }
    }
}
