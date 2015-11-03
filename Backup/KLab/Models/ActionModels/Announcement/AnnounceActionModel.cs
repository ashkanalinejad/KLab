using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KLab.Models.ActionModels
{
    public class AnnounceActionModel : ActionModel
    {
        private Dictionary<string, Agent> _audience = new Dictionary<string, Agent>();
        private Dictionary<string, Agent> _allAgents = new Dictionary<string, Agent>();

        private Formula _announcement = new Formula();

        public AnnounceActionModel(string name, Dictionary<string, Agent> allAgents , Dictionary<string, Agent> audience , Formula announcement)
            : base(name)
        {
            AllAgents = allAgents;
            _audience = audience;
            _announcement = announcement;
        }

        public Formula Announcement
        {
            get { return _announcement; }
            set { _announcement = value; }
        }

        public Dictionary<string, Agent> Audience
        {
            get { return _audience; }
            set { _audience = value; }
        }

        public Dictionary<string, Agent> AllAgents
        {
            get { return _allAgents; }
            set { _allAgents = value; }
        }

        public void ClearAudience()
        {
            Audience.Clear();
        }

        public void RemoveAudience(string agentName)
        {
            Audience.Remove(agentName);
        }

        public void CopyFrom(AnnounceActionModel announcementAction)
        {
            Audience = announcementAction.Audience;
            _announcement = announcementAction._announcement;
        }

        public IEnumerable<string> GetAudienceNames()
        {
            return Audience.Keys;
        }

    }
}
