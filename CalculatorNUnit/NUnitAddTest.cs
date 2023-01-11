using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
    public class NUnitAddTest
    {
        private Calculator calculator;

        [SetUp]
        public void SetUpData()
        {
            calculator = new Calculator();
        }

        [Test]
        public void CheckAddWithDouble()
        {
            Assert.AreEqual(375.3, calculator.Add(352.1, 23.2));
        }

        [Test]
        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        public void CheckDataDrivenAddWithInt(int a, int b, int expectedValue)
        {
            Assert.AreEqual(expectedValue, calculator.Add(Convert.ToDouble(a), Convert.ToDouble(b)));
        }

        [Test]
        public void CheckAddWithString()
        {
            string a = "3";
            double b = 2;

            Assert.AreEqual(5, calculator.Add(Convert.ToDouble(a), b));
        }

        [OneTimeTearDown]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
