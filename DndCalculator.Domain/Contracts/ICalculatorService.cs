using DndCalculator.Domain.Models;

namespace DndCalculator.Domain.Contracts
{
    public interface ICalculatorService
    {
        int GetDifficultyClass(CalculatorInput input);
        //int GetExpectedValue(CalculatorInput input);
    }
}
