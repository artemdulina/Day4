using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkAreaForTaskTwo;

namespace WorkAreaForTaskTwoTests
{
    [TestClass]
    public class CustomerTests
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\FormatTestsForCustomers.xml", "TestCase", DataAccessMethod.Sequential), DeploymentItem("FormatTestsForCustomers.xml")]
        [TestMethod]
        public void TestOfIFormattableToString_DataDrivenValues_AllShouldPass()
        {
            // arrange
            string name = Convert.ToString(TestContext.DataRow["Name"]);
            string phone = Convert.ToString(TestContext.DataRow["Phone"]);
            decimal revenue = Convert.ToDecimal(TestContext.DataRow["Revenue"]);
            string format = Convert.ToString(TestContext.DataRow["FormatString"]);
            string expected = Convert.ToString(TestContext.DataRow["ExpectedResult"]);

            //act
            Customer customer = new Customer(name, phone, revenue);
            string actual = string.Format(format, customer);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestOfIFormattableToString_NotAllowedFormat_ShouldThrowFormatException()
        {
            // arrange

            // act
            Customer customer = new Customer("artem", "+4464546", 10);
            string.Format("{0:T}", customer);

            // assert is handled by ExpectedException
        }
    }
}