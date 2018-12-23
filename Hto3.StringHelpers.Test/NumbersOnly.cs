using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class NumbersOnly
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.NumbersOnly("df89e#dKf"), "89");
            Assert.AreEqual(StringHelpers.NumbersOnly("dfklKidue"), "");
            Assert.AreEqual(StringHelpers.NumbersOnly(""), "");
            Assert.AreEqual(StringHelpers.NumbersOnly("0025478874"), "0025478874");
            Assert.AreEqual(StringHelpers.NumbersOnly(null), null);
        }
    }
}
