using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTesting.test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        // There is a standard way to run unit tests. The three A's of unit testing.
        // Arrange
        // Here we do any setuup
        // Act
        // Assert
        public void TestAddNumbers()
        {
            //Arrange
            var calc = new Calculator();

            //Act - run the method you want to test
            var result = calc.AddNumbers(0,0);

            //Assert
            Assert.AreEqual(0, result);
        }
    }
}
