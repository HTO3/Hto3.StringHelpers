using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class IsAlphanumeric
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.IsAlphanumeric("azAZ09"), true);
            Assert.AreEqual(StringHelpers.IsAlphanumeric("-,"), false);
            Assert.AreEqual(StringHelpers.IsAlphanumeric(""), false);
            Assert.AreEqual(StringHelpers.IsAlphanumeric(null), false);
        }
    }
}
