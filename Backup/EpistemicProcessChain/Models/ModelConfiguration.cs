using System;
using System.Collections.Generic;
using System.Linq;
using EpistemicProcessChain.Models.ActionModels;
using EpistemicProcessChain.Models.EAModel;

namespace EpistemicProcessChain.Models
{
    public class ModelConfiguration
    {
        public string Name;
        public List<EpisState> States = new List<EpisState>();
        public List<EpisTransitionPair> TransitionRelation = new List<EpisTransitionPair>();

        public AssossiativeSet<Agent> GetTagedAgentOfTransitionBetween(EpisState a, EpisState b)
        {
            EpisTransitionPair key = new EpisTransitionPair(a,b);
            key = TransitionRelation.Find(x => x.Equals(key));
            if (key == null) return null;
            return key.TagedAgents;
        }

        public ModelConfiguration(string name)
        {
            Name = name;
            States = new List<EpisState>();
            TransitionRelation = new List<EpisTransitionPair>();
        }

        public ModelConfiguration(ModelConfiguration model)
        {
            CopyFrom(model);
        }

        public void ClearAloneStates()
        {
            foreach (EpisState state in States)
            {
                if (IsStateAlone(state))
                    States.Remove(state);
            }
        }

        private bool IsStateAlone(EpisState state)
        {
            foreach (var relation in TransitionRelation)
            {
                if (state.Equals(relation.Right) || state.Equals(relation.Left))
                    return false;
            }
            return true;
        }

        public void ClearStateList()
        {
            States.Clear();
        }

        public void AddState(EpisState episState)
        {
            if(!States.Contains(episState))
                States.Add(episState);
        }

        public static ModelConfiguration operator *(ModelConfiguration model, ActionModel action)
        {
            ModelConfiguration toret = new ModelConfiguration(model.Name+"_"+action.Name);

            List<EAState> newStates = new List<EAState>();
            List<EAStatePair> newTrans = new List<EAStatePair>();

            foreach (var aState in action.ActionStates)
            {
                foreach (var eState in model.States)
                {
                    if(eState.SatisfiesFormula(aState.Precondition))
                        newStates.Add(new EAState(eState , aState));
                }
            }

            foreach (var a in newStates)
            {
                foreach (var b in newStates)
                {
                    AssossiativeSet<Agent> episTaged = model.GetTagedAgentOfTransitionBetween(a.ModelState, b.ModelState);
                    AssossiativeSet<Agent> actionTaged = action.GetTagedAgentOfTransitionBetween(a.ActionState, b.ActionState);
                    AssossiativeSet<Agent> intersection = episTaged.IntersectWith(actionTaged);
                    if (!intersection.IsEmpty)
                    {
                        EAStatePair newTransPair = new EAStatePair(a,b);
                        newTransPair.TagedAgents = intersection;
                        newTrans.Add(newTransPair);

                        toret.AddState(a.ModelState);
                        toret.AddState(b.ModelState);

                        toret.AddTransition(a.ModelState, b.ModelState, intersection , true);
                    }
                }
            }

            return toret;
        }

        private void AddTransition(EpisState a, EpisState b, AssossiativeSet<Agent> tags , bool unionTagsIfAlreadyAPair)
        {
            EpisTransitionPair newPair = new EpisTransitionPair(a,b) {TagedAgents = tags};

            EpisTransitionPair availablePair = TransitionRelation.Find(x => x.Equals(newPair));
            if (availablePair==null)
            {
                TransitionRelation.Add(newPair);
            }
            else
            {
                if (unionTagsIfAlreadyAPair)
                    availablePair.TagedAgents.Union(tags);
            }
        }

        public void CopyFrom(ModelConfiguration modelConfiguration)
        {
            Name = modelConfiguration.Name;
            EpisState[] StateArray = new EpisState[modelConfiguration.States.Count];
            EpisTransitionPair[] TransArray = new EpisTransitionPair[modelConfiguration.TransitionRelation.Count];

            modelConfiguration.States.CopyTo(StateArray);
            modelConfiguration.TransitionRelation.CopyTo(TransArray);

            States = StateArray.ToList();
            TransitionRelation = TransArray.ToList();
        }
    }
}
