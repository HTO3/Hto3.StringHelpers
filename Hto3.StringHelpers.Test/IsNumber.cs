using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class IsNumber
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.IsNumber("1111", false), true);
            Assert.AreEqual(StringHelpers.IsNumber("1111,87", false), true);
            Assert.AreEqual(StringHelpers.IsNumber("1111,87", true), false);
            Assert.AreEqual(StringHelpers.IsNumber("1rew1,87", false), false);
            Assert.AreEqual(StringHelpers.IsNumber("1rew187", true), false);
            Assert.AreEqual(StringHelpers.IsNumber("", false), false);
            Assert.AreEqual(StringHelpers.IsNumber(null, false), false);
        }
    }
}
