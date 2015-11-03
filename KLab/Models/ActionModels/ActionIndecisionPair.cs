using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KLab.Models.ActionModels
{
    public class ActionIndecisionPair
    {
        private readonly ActionState _left;
        private readonly ActionState _right;

        public AssossiativeSet<Agent> TagedAgents = new AssossiativeSet<Agent>(100); 

        public ActionIndecisionPair(ActionState left, ActionState right)
        {
            _left = left;
            _right = right;
        }

        public ActionState Right
        {
            get { return _right; }
        }

        public ActionState Left
        {
            get { return _left; }
        }

        public bool Equals(ActionIndecisionPair other)
        {
            if (other != null)
            {
                return Right.Equals(other.Right) && Left.Equals(other.Left);
            }
            return false;
        }
    }
}
