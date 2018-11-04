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
            Assert.AreEqual(Helpers.ExceptNumbers("df89e#dKf"), "dfe#dKf");
            Assert.AreEqual(Helpers.ExceptNumbers("dfklKidue"), "dfklKidue");
            Assert.AreEqual(Helpers.ExceptNumbers(""), "");
            Assert.AreEqual(Helpers.ExceptNumbers("0025478874"), "");
            Assert.AreEqual(Helpers.ExceptNumbers(null), null);
        }
    }
}
