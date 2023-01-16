namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class MSTestSinus
    {
        private Calculator calculator;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void CheckSin180()
        {
            Assert.AreEqual(0, calculator.Sin(180));
        }

        [TestMethod]
        public void CheckSin360String()
        {
            Assert.AreEqual(0, calculator.Cos(Convert.ToDouble("360")));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
