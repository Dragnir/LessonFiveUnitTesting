namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class MSTestCosinus
    {
        private Calculator calculator;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void CheckCos180Double()
        {
            Assert.AreEqual(-0.6, calculator.Cos(180), 0.01);
        }

        [TestMethod]
        public void CheckCos360String()
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
