using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExtensionMethods.Tests
{
    [TestClass]
    public class DoubleExtensionsTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestsForExtensionsMethodsFloat.xml", "TestCase", DataAccessMethod.Sequential), DeploymentItem("TestsForExtensionsMethodsFloat.xml")]
        [TestMethod]
        public void GetBinaryTestFloat_DataDrivenValues_AllShouldPass()
        {
            // arrange
            float value = Convert.ToSingle(TestContext.DataRow["Value"]);
            string expected = Convert.ToString(TestContext.DataRow["ExpectedResult"]);

            //act            
            string actual = value.GetBinary();

            //assert
            Assert.AreEqual(expected, actual);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestsForExtensionsMethodsDouble.xml", "TestCase", DataAccessMethod.Sequential), DeploymentItem("TestsForExtensionsMethodsDouble.xml")]
        [TestMethod]
        public void GetBinaryTestDouble_DataDrivenValues_AllShouldPass()
        {
            // arrange
            double value = Convert.ToDouble(TestContext.DataRow["Value"]);
            string expected = Convert.ToString(TestContext.DataRow["ExpectedResult"]);

            //act            
            string actual = value.GetBinary();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}