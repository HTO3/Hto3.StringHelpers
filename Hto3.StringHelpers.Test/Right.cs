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
            Assert.AreEqual(Helpers.Right("Apple", 3, true), "...ple");
            Assert.AreEqual(Helpers.Right("Apple", 5, true), "Apple");
            Assert.AreEqual(Helpers.Right("Apple", 0, true), "...");
            Assert.AreEqual(Helpers.Right("Apple", 0, false), "");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Assert.AreEqual(Helpers.Right("Apple", -5, true), "Apple");
            });
            Assert.AreEqual(Helpers.Right("Apple", 6, true), "Apple");
            Assert.AreEqual(Helpers.Right("Apple", 3, false), "ple");
            Assert.AreEqual(Helpers.Right("Apple", 5, false), "Apple");
            Assert.AreEqual(Helpers.Right("", 3, false), "");
            Assert.AreEqual(Helpers.Right(null, 3, false), null);
        }
    }
}
