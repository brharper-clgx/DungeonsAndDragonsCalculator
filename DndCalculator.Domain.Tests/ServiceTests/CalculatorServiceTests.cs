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

            // Act
            var result = target.GetDifficultyClass(percentage, modifier);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CalculatorService_GetDifficultyClass_WithAdvantage()
        {
            // Arrange
            var percentage = 32;
            var modifier = 3;
            var target = new CalculatorService();

            // Act
            var result = target.GetDifficultyClass(percentage, modifier, true);

            // Assert
            Assert.Equal(20, result);
        }

        [Fact]
        public void CalculatorService_GetDifficultyClass_WithDisadvantage()
        {
            // Arrange
            var percentage = 32;
            var modifier = 3;
            var target = new CalculatorService();

            // Act
            var result = target.GetDifficultyClass(percentage, modifier, false, true);

            // Assert
            Assert.Equal(13, result);
        }

        [Fact]
        public void CalculatorService_GetDifficultyClass_AdvantageAndDisadvantageCancel()
        {
            // Arrange
            var percentage = 32;
            var modifier = 3;
            var target = new CalculatorService();

            // Act
            var result = target.GetDifficultyClass(percentage, modifier, true, true);

            // Assert
            Assert.Equal(18, result);
        }
    }
}
