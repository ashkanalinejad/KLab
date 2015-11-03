using System.Collections.Generic;

namespace EpistemicProcessChain.Models.ActionModels.Announcement
{
    class PublicAnnouncement : AnnounceActionModel
    {
        public PublicAnnouncement(string name, Dictionary<string, Agent> allAgents, Dictionary<string, Agent> audience, Formula announcement) : base(name, allAgents, audience, announcement)
        {
        }
    }
}
