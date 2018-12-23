using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class TryGetFirstName
    {
        [TestMethod]
        public void NormalUse()
        {
            String test1 = null;
            Assert.AreEqual(StringHelpers.TryGetFirstName("John Doe", out test1), true);
            Assert.AreEqual(test1, "John");

            String test2 = null;
            Assert.AreEqual(StringHelpers.TryGetFirstName("John", out test2), false);
            Assert.AreEqual(test2, null);

            String test3 = null;
            Assert.AreEqual(StringHelpers.TryGetFirstName("JohnDoe", out test3), false);
            Assert.AreEqual(test3, null);

            String test4 = null;
            Assert.AreEqual(StringHelpers.TryGetFirstName("John Doe Master", out test4), true);
            Assert.AreEqual(test4, "John");

            String test5 = null;
            Assert.AreEqual(StringHelpers.TryGetFirstName(null, out test5), false);
            Assert.AreEqual(test5, null);

            String test6 = null;
            Assert.AreEqual(StringHelpers.TryGetFirstName("", out test6), false);
            Assert.AreEqual(test6, null);
        }
    }
}
