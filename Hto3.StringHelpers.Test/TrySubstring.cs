using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class TrySubstring
    {
        [TestMethod]
        public void Success_with_zero_index()
        {
            //Arrange
            const string testcase = "abc";
            const string expected = "abc";

            //Act
            string result = null;
            var success = StringHelpers.TrySubstring(testcase, 0, out result);

            //Assert
            Assert.IsTrue(success);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Fail_because_out_of_range_index()
        {
            //Arrange
            const string testcase = "abc";
            const string expected = null;

            //Act
            string result = null;
            var success = StringHelpers.TrySubstring(testcase, 4, out result);

            //Assert
            Assert.IsFalse(success);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Fail_because_negative_index()
        {
            //Arrange
            const string testcase = "abc";
            const string expected = null;

            //Act
            string result = null;
            var success = StringHelpers.TrySubstring(testcase, -7, out result);

            //Assert
            Assert.IsFalse(success);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Fail_because_null_string()
        {
            //Arrange
            const string testcase = null;
            const string expected = null;

            //Act
            string result = null;
            var success = StringHelpers.TrySubstring(testcase, 0, out result);

            //Assert
            Assert.IsFalse(success);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Fail_because_out_of_range_length()
        {
            //Arrange
            const string testcase = "abc";
            const string expected = null;

            //Act
            string result = null;
            var success = StringHelpers.TrySubstring(testcase, 0, 5, out result);

            //Assert
            Assert.IsFalse(success);
            Assert.AreEqual(expected, result);
        }
    }
}
