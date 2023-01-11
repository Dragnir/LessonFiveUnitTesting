using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
    [Parallelizable]
    public class NUnitAbsTest
    {
        private Calculator calculator;

        [SetUp]
        public void SetUpData()
        {
            calculator = new Calculator();
        }

        [Test]
        public void CheckABSWithDouble()
        {
            Assert.AreEqual(4, calculator.Abs(-4));
        }

        [Test]
        public void CheckABSWithString()
        {
            Assert.AreEqual(4, calculator.Abs(Convert.ToDouble("-4")));
        }

        [OneTimeTearDown]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
