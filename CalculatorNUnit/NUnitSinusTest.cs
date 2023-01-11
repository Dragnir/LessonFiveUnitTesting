using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
    [Parallelizable]
    public class NUnitSinusTest
    {
        private Calculator calculator;

        [SetUp]
        public void SetUpData()
        {
            calculator = new Calculator();
        }

        [Test]
        public void CheckSin180Double()
        {
            Assert.AreEqual(-0.8, calculator.Sin(180), 0.1);
        }

        [Test]
        public void CheckSin360String()
        {
            string a = "360";
            Assert.AreEqual(-0.284, calculator.Cos(Convert.ToDouble(a)), 0.001);
        }

        [OneTimeTearDown]
        public void CleanUpTest()
        {
            calculator = null;
        }
    }
}
