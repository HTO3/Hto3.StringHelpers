using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class NullIf
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.NullIf("", ""), null);
            Assert.AreEqual(StringHelpers.NullIf("null", ""), "null");
            Assert.AreEqual(StringHelpers.NullIf(null, "r"), null);
            Assert.AreEqual(StringHelpers.NullIf(null, null), null);
        }
    }
}
