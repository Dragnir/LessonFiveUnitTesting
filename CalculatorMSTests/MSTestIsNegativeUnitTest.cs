namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class MSTestIsNegativeUnitTest
    {
        private Calculator calculator;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void IsNegativeWithDouble()
        {
            double a = 90.987;
            Assert.IsFalse(calculator.isNegative(a));
        }

        [TestMethod]
        public void IsNegativeWithString()
        {
            Assert.IsTrue(calculator.isNegative(Convert.ToDouble("-26.35")));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
