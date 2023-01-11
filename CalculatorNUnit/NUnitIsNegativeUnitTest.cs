using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
    public class NUnitIsNegativeUnitTest
    {
        private Calculator calculator;

        [SetUp]
        public void SetUpData()
        {
            calculator = new Calculator();
        }

        [Test]
	    public void IsNegativeWithDouble()
	    {
            Assert.AreEqual(true, calculator.isNegative(-1865));
        }

        [Test]
        public void IsNegativeWithtString()
        {
            Assert.IsTrue(calculator.isNegative(Convert.ToDouble("-25")));
        }

        [OneTimeTearDown]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
