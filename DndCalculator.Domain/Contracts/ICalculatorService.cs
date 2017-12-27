using DndCalculator.Domain.Models;

namespace DndCalculator.Domain.Contracts
{
    public interface ICalculatorService
    {
        int GetDifficultyClass(int successPercentage, int modifierPlusProficiency, bool withAdvantage = false, bool withDisadvantage = false);
        //int GetExpectedValue(CalculatorInput input);
    }
}
