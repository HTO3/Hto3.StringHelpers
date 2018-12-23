using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class PrependMissing
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.PrependMissing(":\\", "C"), "C:\\");
            Assert.AreEqual(StringHelpers.PrependMissing("C:\\", "C"), "C:\\");
            Assert.AreEqual(StringHelpers.PrependMissing(null, "C"), "C");
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Assert.AreEqual(StringHelpers.PrependMissing(null, null), null);
            });
        }
    }
}
