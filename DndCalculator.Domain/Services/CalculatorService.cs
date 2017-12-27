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

        public int GetDifficultyClass(int successPercentage, int modifierPlusProficiency, bool withAdvantage = false, bool withDisadvantage = false)
        {
            if(withAdvantage && !withDisadvantage)
            {
                return AdvantageCheck(successPercentage, modifierPlusProficiency);
            }
            else if (withDisadvantage && !withAdvantage)
            {
                return DisadvantageCheck(successPercentage, modifierPlusProficiency);
            }
            return PlainCheck(successPercentage, modifierPlusProficiency);
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
