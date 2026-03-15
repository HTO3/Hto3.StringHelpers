using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class PrependMissing
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual("C:\\", StringHelpers.PrependMissing(":\\", "C"));
            Assert.AreEqual("C:\\", StringHelpers.PrependMissing("C:\\", "C"));
            Assert.AreEqual("C", StringHelpers.PrependMissing(null, "C"));
            Assert.Throws<ArgumentException>(() => StringHelpers.PrependMissing(null, null));
        }
    }
}
