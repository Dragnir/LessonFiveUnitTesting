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
            int a = 355589;
            double b = 5.1;

            Assert.AreEqual(69723.333, calculator.Divide(Convert.ToDouble(a), b), 0.001);
        }

        [TestMethod]
        [DataRow(6, "2", 3)]
        [DataRow(15, "3", 5)]
        public void DivideIntStringDataDriven(int a, string b, int expectedValue)
        {
            Assert.AreEqual(expectedValue, calculator.Divide(Convert.ToDouble(a), Convert.ToDouble(b)));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
