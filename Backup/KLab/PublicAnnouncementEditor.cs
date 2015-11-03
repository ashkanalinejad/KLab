using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KLab.Models;
using KLab.Models.ActionModels;
using KLab.Models.ActionModels.Announcement;

namespace KLab
{
    public partial class PublicAnnouncementEditor : Form
    {
        private PublicAnnouncementInfo _originalPublicAnnouncementInfo;

        public PublicAnnouncementEditor()
        {
            InitializeComponent();
            Announcement_FC.InitializeFormula();
        }

        public void SetOriginalActionModel(PublicAnnouncementInfo info)
        {
            _originalPublicAnnouncementInfo = info;
            foreach (string name in info.Audience.Keys)
            {
                Aaud_ARL.AddItemToList(name);
            }
            Announcement_FC.SetFormulaExpression(info.Announcement.Expression);
        }

        private void Cancel_BT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OK_BT_Click(object sender, EventArgs e)
        {
            _originalPublicAnnouncementInfo.ClearAudience();
            foreach (string agentName in Aaud_ARL.ListContents)
            {
                _originalPublicAnnouncementInfo.AddNewAudience(agentName);
            }
            _originalPublicAnnouncementInfo.Announcement = Announcement_FC.Formula;
            this.Close();
        }
    }
}
