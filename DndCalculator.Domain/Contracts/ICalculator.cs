using DndCalculator.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCalculator.Domain.Contracts
{
    public interface ICalculator
    {
        int GetDC(CalculatorInput input);
        int GetExpectedValue(CalculatorInput input);
    }
}
