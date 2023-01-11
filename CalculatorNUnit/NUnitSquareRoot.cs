using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
    public class NUnitSquareRoot
    {
        private Calculator calculator;

        [SetUp]
        public void SetUpData()
        {
            calculator = new Calculator();
        }

        [Test]
        public void CheckSQRTDouble()
        {
            Assert.AreEqual(2, calculator.Sqrt(4));
        }

        [Test]
        public void CheckSQRTString()
        {
            string a = "25";
            Assert.AreEqual(5, calculator.Sqrt(Convert.ToDouble(a)));
        }

        [OneTimeTearDown]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
