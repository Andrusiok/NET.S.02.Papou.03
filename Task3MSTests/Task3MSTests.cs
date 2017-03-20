using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;

namespace Task3MSTests
{
    [TestClass]
    public class BinaryOperationsTests
    {
        public TestContext TestContext { get; set; }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\DDTSource.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Task3MSTests\\DDTSource.xml")]
        [TestMethod]
        public void Insert_Positive()
        {
            var destination = Convert.ToInt32(TestContext.DataRow["Destination"]);
            var source = Convert.ToInt32(TestContext.DataRow["Source"]);
            var startIndex = Convert.ToInt32(TestContext.DataRow["StartIndex"]);
            var endIndex = Convert.ToInt32(TestContext.DataRow["EndIndex"]);

            var expected = Convert.ToInt32(TestContext.DataRow["ExpectedResult"]);
            var actual = BinaryOperations.Insert(destination, source, startIndex, endIndex);
            Assert.AreEqual(expected, actual);
        }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\DDTSourceArgumentException.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Task3MSTests\\DDTSourceArgumentException.xml")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Insert_ArgumentException()
        {
            var destination = Convert.ToInt32(TestContext.DataRow["Destination"]);
            var source = Convert.ToInt32(TestContext.DataRow["Source"]);
            var startIndex = Convert.ToInt32(TestContext.DataRow["StartIndex"]);
            var endIndex = Convert.ToInt32(TestContext.DataRow["EndIndex"]);

            BinaryOperations.Insert(destination, source, startIndex, endIndex);
        }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\DDTSourceOutOfRange.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("Task3MSTests\\DDTSourceOutOfRange.xml")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Insert_ArgumentOutOfRangeException()
        {
            var destination = Convert.ToInt32(TestContext.DataRow["Destination"]);
            var source = Convert.ToInt32(TestContext.DataRow["Source"]);
            var startIndex = Convert.ToInt32(TestContext.DataRow["StartIndex"]);
            var endIndex = Convert.ToInt32(TestContext.DataRow["EndIndex"]);

            BinaryOperations.Insert(destination, source, startIndex, endIndex);
        }
    }
}
