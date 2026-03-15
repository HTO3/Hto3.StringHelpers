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
            Assert.AreEqual(true, StringHelpers.TryGetFirstName("John Doe", out test1));
            Assert.AreEqual("John", test1);

            String test2 = null;
            Assert.AreEqual(false, StringHelpers.TryGetFirstName("John", out test2));
            Assert.AreEqual(null, test2);

            String test3 = null;
            Assert.AreEqual(false, StringHelpers.TryGetFirstName("JohnDoe", out test3));
            Assert.AreEqual(null, test3);

            String test4 = null;
            Assert.AreEqual(true, StringHelpers.TryGetFirstName("John Doe Master", out test4));
            Assert.AreEqual("John", test4);

            String test5 = null;
            Assert.AreEqual(false, StringHelpers.TryGetFirstName(null, out test5));
            Assert.AreEqual(null, test5);

            String test6 = null;
            Assert.AreEqual(false, StringHelpers.TryGetFirstName("", out test6));
            Assert.AreEqual(null, test6);
        }
    }
}
