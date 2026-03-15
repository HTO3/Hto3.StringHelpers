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
            Assert.AreEqual("111.111.111-11", StringHelpers.FormatCPF("11111111111"));
            Assert.AreEqual(null, StringHelpers.FormatCPF("111111111ab"));
            Assert.AreEqual(null, StringHelpers.FormatCPF("11111"));
            Assert.AreEqual("111.111.111-11", StringHelpers.FormatCPF("111.111.111-11"));
            Assert.AreEqual(null, StringHelpers.FormatCPF(""));
            Assert.AreEqual(null, StringHelpers.FormatCEP(null));
        }
    }
}
