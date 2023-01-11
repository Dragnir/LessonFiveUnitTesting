using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
    public class NUnitPowTest
    {
        private Calculator calculator;

        [SetUp]
        public void SetUpData()
        {
            calculator = new Calculator();
        }

        [Test]
        // Seems a Defect with method Pow
        public void PowWithDouble()
        {
            int a = 5;
            double b = 2;
            Assert.AreEqual(25.0, calculator.Pow(a, b));
        }

        [TestCase(2, "2", 4)]
        [TestCase(3, "3", 27)]
        public void PowWithString(int a, string b, int expectedValue)
        {
            Assert.AreEqual(expectedValue, calculator.Pow(a, Convert.ToDouble(b)));
        }

        [OneTimeTearDown]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
