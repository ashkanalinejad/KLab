using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KLab.Models.ActionModels
{
    public class EpisTransitionPair
    {
        private readonly EpisState _left;
        private readonly EpisState _right;

        public AssossiativeSet<Agent> TagedAgents = new AssossiativeSet<Agent>(100); 

        public EpisTransitionPair(EpisState left, EpisState right)
        {
            _left = left;
            _right = right;
        }

        public EpisState Right
        {
            get { return _right; }    
        }

        public EpisState Left
        {
            get { return _left; }
        }

        public bool Equals(EpisTransitionPair other)
        {
            if (other != null)
            {
                return Right.Equals(other.Right) && Left.Equals(other.Left);
            }
            return false;
        }
    }
}
