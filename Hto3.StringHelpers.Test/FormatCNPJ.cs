using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class FormatCNPJ
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual("11.111.111/1111-11", StringHelpers.FormatCNPJ("11111111111111"));
            Assert.AreEqual(null, StringHelpers.FormatCNPJ("111111de111111"));
            Assert.AreEqual(null, StringHelpers.FormatCNPJ("11111"));
            Assert.AreEqual("11.111.111/1111-11", StringHelpers.FormatCNPJ("11.111.111/1111-11"));
            Assert.AreEqual(null, StringHelpers.FormatCNPJ(""));
            Assert.AreEqual(null, StringHelpers.FormatCEP(null));
        }
    }
}
