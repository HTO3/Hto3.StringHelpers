using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class FormatCPF
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.FormatCPF("11111111111"), "111.111.111-11");
            Assert.AreEqual(StringHelpers.FormatCPF("111111111ab"), null);
            Assert.AreEqual(StringHelpers.FormatCPF("11111"), null);
            Assert.AreEqual(StringHelpers.FormatCPF("111.111.111-11"), "111.111.111-11");
            Assert.AreEqual(StringHelpers.FormatCPF(""), null);
            Assert.AreEqual(StringHelpers.FormatCEP(null), null);
        }
    }
}
