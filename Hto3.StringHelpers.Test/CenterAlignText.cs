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
            Assert.AreEqual("             jos            ", StringHelpers.CenterAlignText("jos", 30));
            Assert.AreEqual("             4jos             ", StringHelpers.CenterAlignText("4jos", 30));
            Assert.AreEqual("4j", StringHelpers.CenterAlignText("4jos", 2));
            Assert.AreEqual("  ", StringHelpers.CenterAlignText(null, 2));
            Assert.AreEqual("  ", StringHelpers.CenterAlignText("", 2));
            Assert.AreEqual("", StringHelpers.CenterAlignText("a", 0));
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                Assert.AreEqual(null, StringHelpers.CenterAlignText("", -2));
            });
        }
    }
}
