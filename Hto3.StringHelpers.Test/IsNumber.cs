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
            Assert.AreEqual(Helpers.IsNumber("1111", false), true);
            Assert.AreEqual(Helpers.IsNumber("1111,87", false), true);
            Assert.AreEqual(Helpers.IsNumber("1111,87", true), false);
            Assert.AreEqual(Helpers.IsNumber("1rew1,87", false), false);
            Assert.AreEqual(Helpers.IsNumber("1rew187", true), false);
            Assert.AreEqual(Helpers.IsNumber("", false), false);
            Assert.AreEqual(Helpers.IsNumber(null, false), false);
        }
    }
}
