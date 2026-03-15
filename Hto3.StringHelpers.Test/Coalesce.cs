using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class Coalesce
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual("6", StringHelpers.Coalesce(null, null, "6", "7"));
            Assert.AreEqual(null, StringHelpers.Coalesce(null, null));
            Assert.AreEqual("gg", StringHelpers.Coalesce("gg", null, null));
        }
    }
}
