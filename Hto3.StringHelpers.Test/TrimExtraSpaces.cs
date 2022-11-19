using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class TrimExtraSpaces
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(null, StringHelpers.TrimExtraSpaces(null));
            Assert.AreEqual("abc abc", StringHelpers.TrimExtraSpaces("abc  abc"));
            Assert.AreEqual("abc abc", StringHelpers.TrimExtraSpaces(" abc  abc "));
            Assert.AreEqual("abc u abc t", StringHelpers.TrimExtraSpaces(" abc  u  abc         t"));
        }
    }
}
