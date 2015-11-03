namespace EpistemicProcessChain.Models.EAModel
{
    class EAStatePair
    {
        private readonly EAState _left;
        private readonly EAState _right;

        public AssossiativeSet<Agent> TagedAgents = new AssossiativeSet<Agent>(100);

        public EAStatePair(EAState left, EAState right)
        {
            _left = left;
            _right = right;
        }

        public EAState Right
        {
            get { return _right; }    
        }

        public EAState Left
        {
            get { return _left; }
        }

        public bool Equals(EAStatePair other)
        {
            if (other != null)
            {
                return Right.Equals(other.Right) && Left.Equals(other.Left);
            }
            return false;
        }
    }
}
