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
            Assert.AreEqual("elppA", StringHelpers.Reverse("Apple"));
            Assert.AreEqual("", StringHelpers.Reverse(""));
            Assert.AreEqual(null, StringHelpers.Reverse(null));
        }
    }
}
