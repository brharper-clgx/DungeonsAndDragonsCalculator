namespace DndCalculator.Domain.Models
{
    public class CalculatorInput
    {
        private bool withAdvantage;
        private bool withDisadvantage;

        public CalculatorInput() {}

        public CalculatorInput(int chance, int mod)
        {
            ChanceOfSuccessPercentage = chance;
            Modifier = mod;
        }

        public CalculatorInput(
            int chance, 
            int mod, 
            bool withAdvantage = false, 
            bool withDisadvantage = false)
        {
            ChanceOfSuccessPercentage = chance;
            Modifier = mod;
            WithAdvantage = withAdvantage;
            WithDisadvantage = withDisadvantage;
        }

        public int ChanceOfSuccessPercentage { get; set; }
        public int Modifier { get; set; }
        

        public bool WithAdvantage
        {
            get { return withAdvantage && !withDisadvantage; }
            set { withAdvantage = value; }
        }

        public bool WithDisadvantage
        {
            get { return withDisadvantage && !withAdvantage; }
            set { withDisadvantage = value; }
        }
    }
}
