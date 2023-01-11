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
        public void CheckSin180Double()
        {
            Assert.AreEqual(-0.8, calculator.Sin(180), 0.1);
        }

        [TestMethod]
        public void CheckSin360String()
        {
            string a = "360";
            Assert.AreEqual(-0.284, calculator.Cos(Convert.ToDouble(a)), 0.001);
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
