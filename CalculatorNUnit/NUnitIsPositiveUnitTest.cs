using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
    public class NUnitIsPositiveUnitTest
    {
        private Calculator calculator;

        [SetUp]
        public void SetUpData()
        {
            calculator = new Calculator();
        }

        [Test]
	    public void IsPositiveWithDouble()
	    {
            Assert.AreEqual(false, calculator.isPositive(-1865));
        }

        [Test]
        public void IsPositiveWithtString()
        {
            Assert.IsFalse(calculator.isPositive(Convert.ToDouble("-25")));
        }

        [OneTimeTearDown]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
