using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class ExceptNumbers
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual("dfe#dKf", StringHelpers.ExceptNumbers("df89e#dKf"));
            Assert.AreEqual("dfklKidue", StringHelpers.ExceptNumbers("dfklKidue"));
            Assert.AreEqual("", StringHelpers.ExceptNumbers(""));
            Assert.AreEqual("", StringHelpers.ExceptNumbers("0025478874"));
            Assert.AreEqual(null, StringHelpers.ExceptNumbers(null));
        }
    }
}
