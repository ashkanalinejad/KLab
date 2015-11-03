using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KLab.Models.ActionModels
{
    class PublicAnnouncement : AnnounceActionModel
    {
        public PublicAnnouncement(string name, Dictionary<string, Agent> allAgents, Dictionary<string, Agent> audience, Formula announcement) : base(name, allAgents, audience, announcement)
        {
        }
    }
}
