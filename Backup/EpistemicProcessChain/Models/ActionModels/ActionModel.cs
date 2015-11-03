using System.Collections.Generic;

namespace EpistemicProcessChain.Models.ActionModels
{
    public class ActionModel : Token
    {
        public readonly List<ActionState> ActionStates = new List<ActionState>();
        public readonly List<ActionIndecisionPair> TransitionRelation 
            = new List<ActionIndecisionPair>();

        public AssossiativeSet<Agent> GetTagedAgentOfTransitionBetween(ActionState a, ActionState b)
        {
            ActionIndecisionPair key = new ActionIndecisionPair(a, b);
            key = TransitionRelation.Find(x => x.Equals(key));
            if (key == null) return null;
            return key.TagedAgents;
        }

        public ActionModel(string name) : base(name)
        {
        }
    }
}
