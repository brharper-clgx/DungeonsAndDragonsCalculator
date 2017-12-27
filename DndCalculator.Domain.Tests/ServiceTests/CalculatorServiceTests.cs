using DndCalculator.Domain.Models;
using DndCalculator.Domain.Services;
using Xunit;

namespace DndCalculator.Domain.Tests.ServiceTests
{
    public class CalculatorServiceTests
    {
        [Theory]
        [InlineData(100, 4)]
        [InlineData(32, 18)]
        [InlineData(0, 24)]
        public void CalculatorService_GetDifficultyClass_PlainCheck(int percentage, int expectedResult)
        {
            // Arrange 
            var modifier = 3; // Expected results depend on this value.
            var target = new CalculatorService();
            var input = new CalculatorInput(percentage, modifier);

            // Act
            var result = target.GetDifficultyClass(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CalculatorService_GetDifficultyClass_WithAdvantage()
        {
            // Arrange
            var target = new CalculatorService();
            var input = new CalculatorInput(32, 3, true);

            // Act
            var result = target.GetDifficultyClass(input);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void CalculatorService_GetDifficultyClass_WithDisadvantage()
        {
            // Arrange
            var target = new CalculatorService();
            var input = new CalculatorInput(32, 3, false, true);

            // Act
            var result = target.GetDifficultyClass(input);

            // Assert
            Assert.Equal(13, result);
        }
    }
}
