using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class LettersOnly
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.LettersOnly("df89é#dKf"), "dfédKf");
            Assert.AreEqual(StringHelpers.LettersOnly("dfklKidue"), "dfklKidue");
            Assert.AreEqual(StringHelpers.LettersOnly(""), "");
            Assert.AreEqual(StringHelpers.LettersOnly("0025478874"), "");
            Assert.AreEqual(StringHelpers.LettersOnly(null), null);
        }
    }
}
