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
            Assert.AreEqual(Helpers.ReplaceIgnoringCase("O ônibus já chegou", "Ônibus", "ubber"), "O ubber já chegou");
            Assert.AreEqual(Helpers.ReplaceIgnoringCase("D5\r\n\t4¨8d(f&$Eedu", "$e", "_"), "D5\r\n\t4¨8d(f&_edu");
            Assert.AreEqual(Helpers.ReplaceIgnoringCase(null, "e", "_"), null);
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Assert.AreEqual(Helpers.ReplaceIgnoringCase(null, null, "_"), null);
            });
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Assert.AreEqual(Helpers.ReplaceIgnoringCase("sdfasgJKker", "", null), null);
            });
        }
    }
}
