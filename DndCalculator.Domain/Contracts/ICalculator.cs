using DndCalculator.Domain.Models;

namespace DndCalculator.Domain.Contracts
{
    public interface ICalculator
    {
        int GetDC(CalculatorInput input);
        int GetExpectedValue(CalculatorInput input);
    }
}
