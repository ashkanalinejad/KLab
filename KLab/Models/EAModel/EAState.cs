using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KLab.Models.ActionModels;

namespace KLab.Models.EAModel
{
    public class EAState
    {
        public EpisState ModelState;
        public ActionState ActionState;

        public EAState(EpisState modelState, ActionState actionState)
        {
            ModelState = modelState;
            ActionState = actionState;
        }

        public bool Equals(EAState other)
        {
            return ModelState == other.ModelState && ActionState == other.ActionState;
        }
    }
}
