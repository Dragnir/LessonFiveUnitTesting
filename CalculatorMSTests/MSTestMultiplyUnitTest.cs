namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class MSTestMultiplyUnitTest
    {

        private Calculator calculator;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void MultiplyWithDouble()
        {
            Assert.AreEqual(1, calculator.Multiply(5.0, 0.2));
        }

        [TestMethod]
        [DataRow(0.5, "2.0", 1.0)]
        [DataRow(15.0, "3.0", 45.0)]
        //Seems a defect with method Multiply
        public void MultiplyWithString(double a, string b, double expectedValue)
        {
            Assert.AreEqual(expectedValue, calculator.Multiply(a, Convert.ToDouble(b)));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
