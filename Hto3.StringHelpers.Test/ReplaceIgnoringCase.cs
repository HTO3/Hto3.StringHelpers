using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class ReplaceIgnoringCase
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.ReplaceIgnoringCase("O ônibus já chegou", "Ônibus", "ubber"), "O ubber já chegou");
            Assert.AreEqual(StringHelpers.ReplaceIgnoringCase("D5\r\n\t4¨8d(f&$Eedu", "$e", "_"), "D5\r\n\t4¨8d(f&_edu");
            Assert.AreEqual(StringHelpers.ReplaceIgnoringCase(null, "e", "_"), null);
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Assert.AreEqual(StringHelpers.ReplaceIgnoringCase(null, null, "_"), null);
            });
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Assert.AreEqual(StringHelpers.ReplaceIgnoringCase("sdfasgJKker", "", null), null);
            });
        }
    }
}
