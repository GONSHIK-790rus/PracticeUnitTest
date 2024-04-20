using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppForUnitTest;

namespace UnitTestFor_ConsoleAppForUnitTest {
    [TestClass]
    public class UnitTest {
        
        [TestMethod]
        public void Sum_130and170_returned300() {
            // Arrange
            int firstNum = 130;
            int secondNum = 170;
            int result = 300;

            // Act
            Calculator calculator = new Calculator();
            int actual = calculator.Sum(firstNum, secondNum);

            // Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Subtract_130and130_returned0() {
            // Arrange
            int firstNum = 130;
            int secondNum = 130;
            int result = 0;

            // Act
            Calculator calculator = new Calculator();
            int actual = calculator.Subtract(firstNum, secondNum);

            // Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Multiply_25and25_returned625() {
            // Arrange
            int firstNum = 25;
            int secondNum = 25;
            int result = 625;

            // Act
            Calculator calculator = new Calculator();
            int actual = calculator.Multiply(firstNum, secondNum);

            // Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Divide_49and7_returned7() {
            // Arrange
            int firstNum = 49;
            int secondNum = 7;
            int result = 7;

            // Act
            Calculator calculator = new Calculator();
            int actual = calculator.Divide(firstNum, secondNum);

            // Assert
            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        public void Remainder_25and10_returned5() {
            // Arrange
            int firstNum = 25;
            int secondNum = 10;
            int result = 5;

            // Act
            Calculator calculator = new Calculator();
            int actual = calculator.Remainder(firstNum, secondNum);

            // Assert
            Assert.AreEqual(result, actual);
        }
    }
}
