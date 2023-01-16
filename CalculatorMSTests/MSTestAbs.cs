namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class MSTestAbs

    {
        private Calculator calculator;
        private static TestContext testContextInstance;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void CheckABSWithDouble()
        {
            Assert.AreEqual(4, calculator.Abs(Convert.ToDouble(-4.0)));
        }

        [TestMethod]
        public void CheckABSWithInt()
        {
            Assert.AreEqual(4, calculator.Abs(Convert.ToDouble(-4)));
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
