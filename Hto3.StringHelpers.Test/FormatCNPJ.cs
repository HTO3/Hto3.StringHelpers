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
            Assert.AreEqual(Helpers.FormatCNPJ("11111111111111"), "11.111.111/1111-11");
            Assert.AreEqual(Helpers.FormatCNPJ("111111de111111"), null);
            Assert.AreEqual(Helpers.FormatCNPJ("11111"), null);
            Assert.AreEqual(Helpers.FormatCNPJ("11.111.111/1111-11"), "11.111.111/1111-11");
            Assert.AreEqual(Helpers.FormatCNPJ(""), null);
            Assert.AreEqual(Helpers.FormatCEP(null), null);
        }
    }
}
