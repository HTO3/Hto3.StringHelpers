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
            Assert.AreEqual("...ple", StringHelpers.Right("Apple", 3, true));
            Assert.AreEqual("Apple", StringHelpers.Right("Apple", 5, true));
            Assert.AreEqual("...", StringHelpers.Right("Apple", 0, true));
            Assert.AreEqual("", StringHelpers.Right("Apple", 0, false));
            Assert.Throws<ArgumentOutOfRangeException>(() => StringHelpers.Right("Apple", -5, true));
            Assert.AreEqual("Apple", StringHelpers.Right("Apple", 6, true));
            Assert.AreEqual("ple", StringHelpers.Right("Apple", 3, false));
            Assert.AreEqual("Apple", StringHelpers.Right("Apple", 5, false));
            Assert.AreEqual("", StringHelpers.Right("", 3, false));
            Assert.AreEqual(null, StringHelpers.Right(null, 3, false));
        }
    }
}
