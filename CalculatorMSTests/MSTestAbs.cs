namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class MSTestAbs

    {
        private Calculator calculator;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void CheckABSWithDouble()
        {
            Assert.AreEqual(4, calculator.Abs(-4));
        }

        [TestMethod]
        public void CheckABSWithString()
        {
            Assert.AreEqual(4, calculator.Abs(Convert.ToDouble("-4")));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;

        }
    }
}
