namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class MSTestPowUnitTest
    {

        private Calculator calculator;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        // Seems a Defect with method Pow
        public void PowWithDouble()
        {
            int a = 5;
            double b = 2;
            Assert.AreEqual(25.0, calculator.Pow(a, b));
        }

        [TestMethod]
        [DataRow(2, "2", 4)]
        [DataRow(3, "3", 27)]
        public void PowWithString(int a, string b, int expectedValue)
        {
            Assert.AreEqual(expectedValue, calculator.Pow(a, Convert.ToDouble(b)));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
