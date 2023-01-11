using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
    public class NUnitDividedTest
    {
        private Calculator calculator;

        [SetUp]
        public void SetUpData()
        {
            calculator = new Calculator();
        }

        [Test]
        public void DivideWithDoubleAndInt()
        {
            int a = 355589;
            double b = 5.1;

            Assert.AreEqual(69723.333, calculator.Divide(Convert.ToDouble(a), b), 0.001);
        }

        [Test]
        [TestCase(6, "2", 3)]
        [TestCase(15, "3", 5)]
        public void DivideIntStringDataDriven(int a, string b, int expectedValue)
        {
            Assert.AreEqual(expectedValue, calculator.Divide(Convert.ToDouble(a), Convert.ToDouble(b)));
        }

        [OneTimeTearDown]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
