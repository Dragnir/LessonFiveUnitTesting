namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class MSTestIsPositiveUnitTest
    {
        private Calculator calculator;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void IsPositiveWithDouble()
        {
            double a = -90.987;
            Assert.IsFalse(calculator.isPositive(a));
        }

        [TestMethod]
        public void IsNegativeWithString()
        {
            Assert.IsTrue(calculator.isPositive(Convert.ToDouble("26.35")));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
