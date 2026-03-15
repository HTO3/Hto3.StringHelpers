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
            Assert.AreEqual("App...", StringHelpers.Left("Apple", 3, true));
            Assert.AreEqual("Apple", StringHelpers.Left("Apple", 5, true));
            Assert.AreEqual("...", StringHelpers.Left("Apple", 0, true));
            Assert.AreEqual("", StringHelpers.Left("Apple", 0, false));
            Assert.Throws<ArgumentOutOfRangeException>(() => StringHelpers.Left("Apple", -5, true));
            Assert.AreEqual("Apple", StringHelpers.Left("Apple", 6, true));
            Assert.AreEqual("App", StringHelpers.Left("Apple", 3, false));
            Assert.AreEqual("Apple", StringHelpers.Left("Apple", 5, false));
            Assert.AreEqual("", StringHelpers.Left("", 3, false));
            Assert.AreEqual(null, StringHelpers.Left(null, 3, false));
        }
    }
}
