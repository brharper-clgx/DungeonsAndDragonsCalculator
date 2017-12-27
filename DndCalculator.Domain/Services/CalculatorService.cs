using DndCalculator.Domain.Contracts;
using System;
using DndCalculator.Domain.Models;

namespace DndCalculator.Domain.Services
{
    public class CalculatorService : ICalculatorService
    {
        public CalculatorService()
        {
        }

        public int GetDifficultyClass(CalculatorInput input)
        {
            if(input.WithAdvantage)
            {
                return AdvantageCheck(input.ChanceOfSuccessPercentage, input.Modifier);
            }
            if (input.WithDisadvantage)
            {
                return DisadvantageCheck(input.ChanceOfSuccessPercentage, input.Modifier);
            }
            return PlainCheck(input.ChanceOfSuccessPercentage, input.Modifier);
        }

        private int PlainCheck(int chance, int mod)
        {
            return (int)Math.Round(21 + mod - 20 * ((float)chance / 100));
        }

        private int AdvantageCheck(int chance, int mod)
        {
            return (int)Math.Round(mod + 20*Math.Sqrt(1- ((float)chance / 100)) +1);
        }

        private int DisadvantageCheck(int chance, int mod)
        {
            return (int)Math.Round(mod - 20 * Math.Sqrt(((float)chance / 100)) + 21);
        }
    }
}
