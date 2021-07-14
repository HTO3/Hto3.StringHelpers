using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class TrySubstring
    {
        [TestMethod]
        public void NormalUse()
        {
            const string testcase = "What's a beautiful day!";
            Assert.AreEqual(StringHelpers.TrySubstring(testcase, testcase.Length + 1), testcase);
            Assert.AreEqual(StringHelpers.TrySubstring(testcase, testcase.Length - 5), testcase.Substring(0, testcase.Length - 5));
            Assert.AreEqual(StringHelpers.TrySubstring(testcase, 0), testcase);
            Assert.AreEqual(StringHelpers.TrySubstring(testcase, -1), testcase);
            Assert.AreEqual(StringHelpers.TrySubstring("", 10), "");
            Assert.AreEqual(StringHelpers.TrySubstring(null, 10), null);
        }
    }
}
