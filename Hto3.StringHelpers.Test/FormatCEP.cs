using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class FormatCEP
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.FormatCEP("11111111"), "11111-111");
            Assert.AreEqual(StringHelpers.FormatCEP("111111de"), "11111-100");
            Assert.AreEqual(StringHelpers.FormatCEP("11111"), "11111-000");
            Assert.AreEqual(StringHelpers.FormatCEP("111"), null);
            Assert.AreEqual(StringHelpers.FormatCEP("11111111111111"), null);
            Assert.AreEqual(StringHelpers.FormatCEP(""), null);
            Assert.AreEqual(StringHelpers.FormatCEP(null), null);
        }
    }
}
