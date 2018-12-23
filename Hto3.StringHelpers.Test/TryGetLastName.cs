using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class TryGetLastName
    {
        [TestMethod]
        public void NormalUse()
        {
            String test1 = null;
            Assert.AreEqual(StringHelpers.TryGetLastName("John Doe", out test1), true);
            Assert.AreEqual(test1, "Doe");

            String test2 = null;
            Assert.AreEqual(StringHelpers.TryGetLastName("John", out test2), false);
            Assert.AreEqual(test2, null);

            String test3 = null;
            Assert.AreEqual(StringHelpers.TryGetLastName("JohnDoe", out test3), false);
            Assert.AreEqual(test3, null);

            String test4 = null;
            Assert.AreEqual(StringHelpers.TryGetLastName("John Doe Master", out test4), true);
            Assert.AreEqual(test4, "Master");

            String test5 = null;
            Assert.AreEqual(StringHelpers.TryGetLastName(null, out test5), false);
            Assert.AreEqual(test5, null);

            String test6 = null;
            Assert.AreEqual(StringHelpers.TryGetLastName("", out test6), false);
            Assert.AreEqual(test6, null);
        }
    }
}
