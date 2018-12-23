using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class Reverse
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.Reverse("Apple"), "elppA");
            Assert.AreEqual(StringHelpers.Reverse(""), "");
            Assert.AreEqual(StringHelpers.Reverse(null), null);
        }
    }
}
