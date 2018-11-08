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
            Assert.AreEqual(Helpers.IsAlphanumeric("azAZ09"), true);
            Assert.AreEqual(Helpers.IsAlphanumeric("-,"), false);
            Assert.AreEqual(Helpers.IsAlphanumeric(""), false);
            Assert.AreEqual(Helpers.IsAlphanumeric(null), false);
        }
    }
}
