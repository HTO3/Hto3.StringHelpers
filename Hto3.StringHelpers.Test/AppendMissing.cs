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
            Assert.AreEqual(StringHelpers.AppendMissing(@"C:\Program Files (x86)\Java", "\\"), @"C:\Program Files (x86)\Java\");
            Assert.AreEqual(StringHelpers.AppendMissing("", "-"), "-");
            Assert.AreEqual(StringHelpers.AppendMissing(null, "n"), "n");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Without_Should_End_With()
        {
            StringHelpers.AppendMissing(@"C:\Program Files (x86)\Java", null);
        }
    }
}
