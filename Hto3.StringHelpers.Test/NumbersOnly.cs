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
            Assert.AreEqual("89", StringHelpers.NumbersOnly("df89e#dKf"));
            Assert.AreEqual("", StringHelpers.NumbersOnly("dfklKidue"));
            Assert.AreEqual("", StringHelpers.NumbersOnly(""));
            Assert.AreEqual("0025478874", StringHelpers.NumbersOnly("0025478874"));
            Assert.AreEqual(null, StringHelpers.NumbersOnly(null));
        }
    }
}
