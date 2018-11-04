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
            Assert.AreEqual(Helpers.CenterAlignText("jos", 30), "             jos            ");
            Assert.AreEqual(Helpers.CenterAlignText("4jos", 30), "             4jos             ");
            Assert.AreEqual(Helpers.CenterAlignText("4jos", 2), "4j");
            Assert.AreEqual(Helpers.CenterAlignText(null, 2), "  ");
            Assert.AreEqual(Helpers.CenterAlignText("", 2), "  ");
            Assert.AreEqual(Helpers.CenterAlignText("a", 0), "");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                Assert.AreEqual(Helpers.CenterAlignText("", -2), null);
            });
        }
    }
}
