namespace MSTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CSharpCalculator;
    using System;

    [TestClass]
	public class MSTestSubTest
	{

        private Calculator calculator;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
		public void CheckSubWithDouble()
		{
            Assert.AreEqual(330.0, calculator.Sub(352.1, 22.1));
		}

        [TestMethod]
        [DataRow(10, 2, 8)]
        [DataRow(-3, -2, -1)]
        public void DataDrivenSubWithInt(int a, int b, int expectedValue)
        {
            Assert.AreEqual(expectedValue, calculator.Sub(Convert.ToDouble(a), Convert.ToDouble(b)));
        }

        [TestMethod]
        public void CheckSubWithString()
        {
            string a = "5";
            double b = 1;

            Assert.AreEqual(4, calculator.Sub(Convert.ToDouble(a), b));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}