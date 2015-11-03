using System.Collections.Generic;

namespace EpistemicProcessChain.Models.ActionModels.Announcement
{
    public class SecretAnnouncement : AnnounceActionModel
    {
        public ActionState SecretState;
        public ActionIndecisionPair Relation;
        public SecretAnnouncement(string name, Dictionary<string, Agent> allAgents, Dictionary<string, Agent> audience, Formula announcement) 
            : base(name , allAgents , audience , announcement)
        {
            ActionState trueState = new ActionState("TrueState");
            SecretState = new ActionState("Secret");
            SecretState.Precondition = announcement;
            ActionStates.Add(trueState);
            ActionStates.Add(SecretState);

            Relation = new ActionIndecisionPair(SecretState, trueState);
            Relation.TagedAgents = GetSubtractionOfAgentDics(allAgents, audience);
            TransitionRelation.Add(Relation);
        }

        private AssossiativeSet<Agent> GetSubtractionOfAgentDics(Dictionary<string, Agent> a, Dictionary<string, Agent> b)
        {
            AssossiativeSet<Agent> toret = new AssossiativeSet<Agent>(100);
            foreach (KeyValuePair<string, Agent> pair in a)
            {
                if (!b.ContainsKey(pair.Key))
                {
                    toret.Add(pair.Value);
                }
            }
            return toret;
        }
    }
}
