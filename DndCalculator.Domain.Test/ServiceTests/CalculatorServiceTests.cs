using DndCalculator.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DndCalculator.Domain.Test.ServiceTests
{
    [TestClass]
    public class CalculatorServiceTests
    {
        [DataTestMethod]
        [DataRow(100, 4)]
        [DataRow(32, 18)]
        [DataRow(0, 24)]
        public void CalculatorService_GetDifficultyClass_PlainCheck(int percentage, int expectedResult)
        {
            // Arrange 
            var modifier = 3; // Expected results depend on this value.
            var target = new CalculatorService();

            // Act
            var result = target.GetDifficultyClass(percentage, modifier);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CalculatorService_GetDifficultyClass_WithAdvantage()
        {
            // Arrange
            var percentage = 32;
            var modifier = 3;
            var target = new CalculatorService();

            // Act
            var result = target.GetDifficultyClass(percentage, modifier, true);

            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void CalculatorService_GetDifficultyClass_WithDisadvantage()
        {
            // Arrange
            var percentage = 32;
            var modifier = 3;
            var target = new CalculatorService();

            // Act
            var result = target.GetDifficultyClass(percentage, modifier, false, true);

            // Assert
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void CalculatorService_GetDifficultyClass_AdvantageAndDisadvantageCancel()
        {
            // Arrange
            var percentage = 32;
            var modifier = 3;
            var target = new CalculatorService();

            // Act
            var result = target.GetDifficultyClass(percentage, modifier, true, true);

            // Assert
            Assert.AreEqual(18, result);
        }

        [DataTestMethod]
        [DataRow(1, 20, 0, 10.5f)]
        [DataRow(4, 6, 2, 16.0f)]
        [DataRow(5, 8, -1, 21.5f)]
        public void CalculatorService_GetExpectedValue_ShouldReturnExpectedValue(int numDice, int numSides, int mod, float expectedResult)
        {
            // Arrange
            var target = new CalculatorService();

            // Act
            var result = target.GetExpectedValue(numDice, numSides, mod);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
