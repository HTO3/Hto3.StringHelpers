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
            Assert.AreEqual(null, StringHelpers.NullIf("", ""));
            Assert.AreEqual("null", StringHelpers.NullIf("null", ""));
            Assert.AreEqual(null, StringHelpers.NullIf(null, "r"));
            Assert.AreEqual(null, StringHelpers.NullIf(null, null));
        }
    }
}
