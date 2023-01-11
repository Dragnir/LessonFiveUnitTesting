using System;
using CSharpCalculator;
using NUnit.Framework;

namespace NUnit
{
	[TestFixture]
    [Parallelizable]
    public class NUnitCosinusTest
    {
        private Calculator calculator;

        [SetUp]
        public void SetUpData()
        {
            calculator = new Calculator();
        }

        [Test]
        public void CheckCos180Double()
        {
            Assert.AreEqual(-0.6, calculator.Cos(180), 0.01);
        }

        [Test]
        public void CheckCos360String()
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
