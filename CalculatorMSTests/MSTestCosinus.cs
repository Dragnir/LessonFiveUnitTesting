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
        public void CheckCos180()
        {
            Assert.AreEqual(-1, calculator.Cos(180));
        }

        [TestMethod]
        public void CheckCos360String()
        {
            Assert.AreEqual(1, calculator.Cos(Convert.ToDouble("360")));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
