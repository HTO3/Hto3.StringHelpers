using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class CenterAlignText
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.CenterAlignText("jos", 30), "             jos            ");
            Assert.AreEqual(StringHelpers.CenterAlignText("4jos", 30), "             4jos             ");
            Assert.AreEqual(StringHelpers.CenterAlignText("4jos", 2), "4j");
            Assert.AreEqual(StringHelpers.CenterAlignText(null, 2), "  ");
            Assert.AreEqual(StringHelpers.CenterAlignText("", 2), "  ");
            Assert.AreEqual(StringHelpers.CenterAlignText("a", 0), "");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Assert.AreEqual(StringHelpers.CenterAlignText("", -2), null);
            });
        }
    }
}
