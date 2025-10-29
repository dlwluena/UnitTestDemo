using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CalculatorApp; 

namespace CalculatorApp.Tests 
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_ShouldReturnSum_AndCallLog()
        {
            // Arrange
            var mockLog = new Mock<ILogService>();
            var calculator = new Calculator(mockLog.Object); 

            // Act
            int result = calculator.Add(2, 3);

            // Assert
            Assert.AreEqual(5, result);
            mockLog.Verify(l => l.Log("Add: 2 + 3 = 5"), Times.Once);
        }

        [TestMethod]
        public void Subtract_ShouldReturnDifference_AndCallLog()
        {
            // Arrange
            var mockLog = new Mock<ILogService>();
            var calculator = new Calculator(mockLog.Object);

            // Act
            int result = calculator.Subtract(5, 3);

            // Assert
            Assert.AreEqual(2, result);
            mockLog.Verify(l => l.Log("Subtract: 5 - 3 = 2"), Times.Once);
        }
    }
}

