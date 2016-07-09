using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkAreaForTaskTwo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkAreaForTaskTwo.Tests
{
    [TestClass]
    public class CustomersFormatterTests
    {
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestOfICustomFormatterFormat_NotAllowedFormat_ShouldThrowFormatException()
        {
            // arrange

            // act
            Customer customer = new Customer("artem", "+4464546", 10);
            string.Format(new CustomersFormatter(), "{0:T}", customer);

            // assert is handled by ExpectedException
        }

        [TestMethod]
        public void TestOfICustomFormatterFormat_AllowedFormat_ShouldPass()
        {
            // arrange

            // act
            Customer customer = new Customer("artem", "+4464546", 10);
            string actual = string.Format(new CustomersFormatter(), "{0:OTHERREPRESENTATIONS}", customer);
            string expected = "OtherRepresentationOfThisObject";

            // assert is handled by ExpectedException
            Assert.AreEqual(expected, actual);
        }
    }
}