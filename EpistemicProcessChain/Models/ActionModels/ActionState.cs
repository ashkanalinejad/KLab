namespace EpistemicProcessChain.Models.ActionModels
{
    public class ActionState : Token
    {
        public Formula Precondition = new Formula();

        public ActionState(string name) : base(name)
        {
        }
    }
}
