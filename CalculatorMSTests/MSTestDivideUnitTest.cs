namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class MSTestDivideUnitTest
    {

        private Calculator calculator;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void DivideWithDoubleAndInt()
        {
            Assert.AreEqual(69723.333, calculator.Divide(355589.0, 5.1));
        }

        [TestMethod]
        [DataRow(6, "2", 3)]
        [DataRow(15, "3", 5)]
        [DataRow(15, "0", 0)]
        public void DivideIntStringDataDriven(double a, string b, double expectedValue)
        {
            Assert.AreEqual(expectedValue, calculator.Divide(a, Convert.ToDouble(b)));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
