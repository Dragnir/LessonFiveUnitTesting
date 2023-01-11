namespace MSTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CSharpCalculator;
    using System;

    [TestClass]
	public class MSTestAddTest
	{

        private Calculator calculator;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
		public void CheckAddWithDouble()
		{
            Assert.AreEqual(375.3, calculator.Add(352.1, 23.2));
		}

        [TestMethod]
        [DataRow(3, 2, 5)]
        [DataRow(-3, -2, -5)]
        public void CheckDataDrivenAddWithInt(int a, int b, int expectedValue)
        {
            Assert.AreEqual(expectedValue, calculator.Add(Convert.ToDouble(a), Convert.ToDouble(b)));
        }

        [TestMethod]
        public void CheckAddWithString()
        {
            string a = "3";
            double b = 2;

            Assert.AreEqual(5, calculator.Add(Convert.ToDouble(a), b));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}