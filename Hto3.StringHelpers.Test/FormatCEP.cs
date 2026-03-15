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
            Assert.AreEqual("11111-111", StringHelpers.FormatCEP("11111111"));
            Assert.AreEqual("11111-100", StringHelpers.FormatCEP("111111de"));
            Assert.AreEqual("11111-000", StringHelpers.FormatCEP("11111"));
            Assert.AreEqual(null, StringHelpers.FormatCEP("111"));
            Assert.AreEqual(null, StringHelpers.FormatCEP("11111111111111"));
            Assert.AreEqual(null, StringHelpers.FormatCEP(""));
            Assert.AreEqual(null, StringHelpers.FormatCEP(null));
        }
    }
}
