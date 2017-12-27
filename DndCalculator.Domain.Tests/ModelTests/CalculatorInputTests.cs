using DndCalculator.Domain.Models;
using Xunit;

namespace DndCalculator.Domain.Tests.ModelTests
{
    public class CalculatorInputTests
    {
        [Theory]
        [InlineData(false, false, false, false)]
        [InlineData(false, true, false, true)]
        [InlineData(true, false, true, false)]
        [InlineData(true, true, false, false)]
        public void CalculatorInputTests_AdvantageDisadvantageLogic(bool ad, bool dis, bool nextAd, bool nextDis)
        {
            // Arrange & Act
            var target = new CalculatorInput
            {
                WithAdvantage = ad,
                WithDisadvantage = dis
            };

            // Assert
            Assert.Equal(nextAd, target.WithAdvantage);
            Assert.Equal(nextDis, target.WithDisadvantage);
        }
    }
}
