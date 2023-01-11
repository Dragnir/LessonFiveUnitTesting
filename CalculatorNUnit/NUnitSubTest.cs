using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
    public class NUnitSubTest
    {
        private Calculator calculator;

        [SetUp]
        public void SetUpData()
        {
            calculator = new Calculator();
        }

        [Test]
        public void CheckSubWithDouble()
        {
            Assert.AreEqual(330.0, calculator.Sub(352.1, 22.1));
        }

        [Test]
        [TestCase(10, 2, 8)]
        [TestCase(-3, -2, -1)]
        public void DataDrivenSubWithInt(int a, int b, int expectedValue)
        {
            Assert.AreEqual(expectedValue, calculator.Sub(Convert.ToDouble(a), Convert.ToDouble(b)));
        }

        [Test]
        public void CheckSubWithString()
        {
            string a = "5";
            double b = 1;

            Assert.AreEqual(4, calculator.Sub(Convert.ToDouble(a), b));
        }

        [OneTimeTearDown]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
