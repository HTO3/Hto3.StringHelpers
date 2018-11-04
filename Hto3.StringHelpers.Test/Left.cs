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
            Assert.AreEqual(Helpers.Left("Apple", 3, true), "App...");
            Assert.AreEqual(Helpers.Left("Apple", 5, true), "Apple");
            Assert.AreEqual(Helpers.Left("Apple", 0, true), "...");
            Assert.AreEqual(Helpers.Left("Apple", 0, false), "");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Assert.AreEqual(Helpers.Left("Apple", -5, true), "Apple");
            });
            Assert.AreEqual(Helpers.Left("Apple", 6, true), "Apple");
            Assert.AreEqual(Helpers.Left("Apple", 3, false), "App");
            Assert.AreEqual(Helpers.Left("Apple", 5, false), "Apple");
            Assert.AreEqual(Helpers.Left("", 3, false), "");
            Assert.AreEqual(Helpers.Left(null, 3, false), null);
        }
    }
}
