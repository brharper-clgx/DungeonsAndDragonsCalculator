using System;
using System.Collections.Generic;
using System.Text;

namespace DndCalculator.Domain.Contracts
{
    public interface ICalculatorInput
    {
        int ChanceOfSuccessPercentage { get; set; }
        int NumberOfDice { get; set; }
        int NumberOfSides { get; set; }
        int Modifier { get; set; }
        int ProficiencyBonus { get; set; }
        bool IsProficient { get; set; }
        bool WithAdvantage { get; set; }
        bool WithDisadvantage { get; set; }
    }
}
