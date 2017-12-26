using DndCalculator.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCalculator.Domain.Models
{
    public class CalculatorInput
    {
        public CalculatorInput()
        {
            ChanceOfSuccessPercentage = 50;
            NumberOfDice = 1;
            NumberOfSides = 20;
        }

        public int ChanceOfSuccessPercentage { get; set; }
        public int NumberOfDice { get; set; }
        public int NumberOfSides { get; set; }
        public int Modifier { get; set; }
        public int ProficiencyBonus { get; set; }
        public bool IsProficient { get; set; }
        public bool WithAdvantage { get; set; }
        public bool WithDisadvantage { get; set; }
    }
}
