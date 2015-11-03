namespace EpistemicProcessChain.Models
{
    public class Formula
    {
        private string _originalFormula;

        public Formula()
        {
            _originalFormula = "true";
        }

        public Formula(string s)
        {
            Expression = s;
        }

        public string Expression
        {
            set
            {
                _originalFormula = ConvertFormualToCleanNotation(value);
                CompileFormula(value);
            }
            get { return _originalFormula; }
        }

        private static void CompileFormula(string formulaText)
        {
            //TODO CompileFormula
        }

        private static string ConvertFormualToCleanNotation(string formula)
        {
            //TODO ConvertFormualToCleanNotation
            return formula;
        }
    }
}
