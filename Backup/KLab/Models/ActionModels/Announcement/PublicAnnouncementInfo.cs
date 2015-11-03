using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KLab.Models.ActionModels.Announcement
{
    public class PublicAnnouncementInfo
    {
        public Formula Announcement = new Formula();
        public Dictionary<string, Agent> Audience = new Dictionary<string, Agent>();

        public void ClearAudience()
        {
            Audience.Clear();
        }

        public bool AddNewAudience(string agentName)
        {
            Agent agent = null;
            if (Audience.TryGetValue(agentName, out agent))
            {
                return false;
            }

            agent = new Agent(agentName);
            Audience.Add(agentName, agent);
            return true;

        }

        public void CopyFrom(PublicAnnouncementInfo publicAnnouncementInfo)
        {
            Announcement = publicAnnouncementInfo.Announcement;
            Audience = publicAnnouncementInfo.Audience;
        }
    }
}
