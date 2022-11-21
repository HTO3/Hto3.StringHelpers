using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class CalcBase64SizeBytes
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(1, StringHelpers.CalcBase64SizeBytes("AA=="));
            Assert.AreEqual(2, StringHelpers.CalcBase64SizeBytes("AAA="));
            Assert.AreEqual(3, StringHelpers.CalcBase64SizeBytes("AAAA"));
            Assert.AreEqual(0, StringHelpers.CalcBase64SizeBytes(""));
        }
    }
}
