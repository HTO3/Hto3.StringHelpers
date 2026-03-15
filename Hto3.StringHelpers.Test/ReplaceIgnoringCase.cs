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
            Assert.AreEqual("O ubber já chegou", StringHelpers.ReplaceIgnoringCase("O ônibus já chegou", "Ônibus", "ubber"));
            Assert.AreEqual("D5\r\n\t4¨8d(f&_edu", StringHelpers.ReplaceIgnoringCase("D5\r\n\t4¨8d(f&$Eedu", "$e", "_"));
            Assert.AreEqual(null, StringHelpers.ReplaceIgnoringCase(null, "e", "_"));
            Assert.Throws<ArgumentNullException>(() => StringHelpers.ReplaceIgnoringCase(null, null, "_"));
            Assert.Throws<ArgumentNullException>(() => StringHelpers.ReplaceIgnoringCase("sdfasgJKker", "", null));
        }
    }
}
