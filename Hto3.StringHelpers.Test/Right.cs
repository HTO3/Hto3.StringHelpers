using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class Right
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.Right("Apple", 3, true), "...ple");
            Assert.AreEqual(StringHelpers.Right("Apple", 5, true), "Apple");
            Assert.AreEqual(StringHelpers.Right("Apple", 0, true), "...");
            Assert.AreEqual(StringHelpers.Right("Apple", 0, false), "");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Assert.AreEqual(StringHelpers.Right("Apple", -5, true), "Apple");
            });
            Assert.AreEqual(StringHelpers.Right("Apple", 6, true), "Apple");
            Assert.AreEqual(StringHelpers.Right("Apple", 3, false), "ple");
            Assert.AreEqual(StringHelpers.Right("Apple", 5, false), "Apple");
            Assert.AreEqual(StringHelpers.Right("", 3, false), "");
            Assert.AreEqual(StringHelpers.Right(null, 3, false), null);
        }
    }
}
