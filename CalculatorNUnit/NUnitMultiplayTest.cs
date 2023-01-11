using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
    [Parallelizable]
    public class NUnitMultiplayTest
    {
        private Calculator calculator;

        [SetUp]
        public void SetUpData()
        {
            calculator = new Calculator();
        }

        [Test]
        public void MultiplyWithDouble()
        {
            Assert.AreEqual(1, calculator.Multiply(5.0, 0.2));
        }

        [TestCase(0.5, "2.0", 1.0)]
        [TestCase(15.0, "3.0", 45.0)]
        //Seems a defect with method Multiply
        public void MultiplyWithString(double a, string b, double expectedValue)
        {
            Assert.AreEqual(expectedValue, calculator.Multiply(a, Convert.ToDouble(b)));
        }

        [OneTimeTearDown]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
