using System.Collections.Generic;
using System.Linq;
using Ciloci.Flee;

namespace EpistemicProcessChain.Models
{
    public class EpisState
    {
        private readonly ExpressionContext _expressionContext;  
        private readonly Dictionary<Atomic, bool> _status = null;

        public EpisState(Atomic[] atomicsName, bool[] atomicsPositivity)
        {
            _expressionContext = new ExpressionContext(this);
            if (atomicsName.Count() == atomicsPositivity.Count())
            {
                _status = new Dictionary<Atomic, bool>();
                for (int i = 0; i < atomicsName.Count(); i++)
                {
                    _status.Add(atomicsName[i] , atomicsPositivity[i]);
                }
            }
        }

        public bool SatisfiesFormula(Formula formula)
        {
            VariableCollection variable = _expressionContext.Variables;
            foreach (var statu in _status)
            {
                variable.Add(statu.Key.ToString() , statu.Value);
            }
            bool eval = _expressionContext.CompileGeneric<bool>(formula.Expression).Evaluate();
            variable.Clear();
            return eval;
        }
    }
}
