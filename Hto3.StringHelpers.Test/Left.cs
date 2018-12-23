using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class Left
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.Left("Apple", 3, true), "App...");
            Assert.AreEqual(StringHelpers.Left("Apple", 5, true), "Apple");
            Assert.AreEqual(StringHelpers.Left("Apple", 0, true), "...");
            Assert.AreEqual(StringHelpers.Left("Apple", 0, false), "");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Assert.AreEqual(StringHelpers.Left("Apple", -5, true), "Apple");
            });
            Assert.AreEqual(StringHelpers.Left("Apple", 6, true), "Apple");
            Assert.AreEqual(StringHelpers.Left("Apple", 3, false), "App");
            Assert.AreEqual(StringHelpers.Left("Apple", 5, false), "Apple");
            Assert.AreEqual(StringHelpers.Left("", 3, false), "");
            Assert.AreEqual(StringHelpers.Left(null, 3, false), null);
        }
    }
}
