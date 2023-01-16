using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTests
{

    [TestClass]
    public class MSTestSquareRoot
    {
        private Calculator calculator;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        public void CheckSQRTDouble()
        {
            Assert.AreEqual(2, calculator.Sqrt(4));
        }

        [TestMethod]
        public void CheckSQRTString()
        {
            Assert.AreEqual(5, calculator.Sqrt(Convert.ToDouble("25")));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
