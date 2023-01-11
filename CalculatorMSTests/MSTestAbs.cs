namespace MSTests
{
    using CSharpCalculator;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class MSTestAbs

    {
        private Calculator calculator;
        private static TestContext testContextInstance;

        [TestInitialize]
        public void SetUpTest()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "AbsDataset.xml", "CheckABSWithDouble", DataAccessMethod.Sequential)]
        [DeploymentItem("Dataset")]
        public void CheckABSWithDouble()
        {
            double inputData = Convert.ToDouble(testContextInstance.DataRow["InputParameter"]);
            double expectedResult = Convert.ToDouble(testContextInstance.DataRow["Result"]);
            double actualResult = calculator.Abs(inputData);

            Assert.AreEqual(expectedResult, actualResult, $"Absorption current value of double '{inputData} is incorrect");
        }

        [TestMethod]
        public void CheckABSWithString()
        {
            Assert.AreEqual(4, calculator.Abs(Convert.ToDouble("-4")));
        }

        [TestCleanup]
        public void CleanUpTest()
        {
            calculator = null;

        }
    }
}
