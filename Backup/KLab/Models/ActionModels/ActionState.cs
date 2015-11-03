using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KLab.Models.ActionModels
{
    public class ActionState : Token
    {
        public Formula Precondition = new Formula();

        public ActionState(string name) : base(name)
        {
        }
    }
}
