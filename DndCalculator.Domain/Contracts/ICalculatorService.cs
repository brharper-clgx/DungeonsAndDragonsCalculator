using DndCalculator.Domain.Models;

namespace DndCalculator.Domain.Contracts
{
    public interface ICalculatorService
    {
        int GetDifficultyClass(int successPercentage, int modifierPlusProficiency, bool withAdvantage = false, bool withDisadvantage = false);
        decimal GetExpectedValue(decimal numberOfDice, decimal sidesOfDice, decimal modifier);
    }
}
