using EpistemicProcessChain.Models.ActionModels;

namespace EpistemicProcessChain.Models.EAModel
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
