using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class AppendMissing
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(Helpers.AppendMissing(@"C:\Program Files (x86)\Java", "\\"), @"C:\Program Files (x86)\Java\");
            Assert.AreEqual(Helpers.AppendMissing("", "-"), "-");
            Assert.AreEqual(Helpers.AppendMissing(null, "n"), "n");
        }
    }
}
