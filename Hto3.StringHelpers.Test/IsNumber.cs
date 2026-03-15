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
            Assert.AreEqual(true, StringHelpers.IsNumber("1111", false));
            Assert.AreEqual(true, StringHelpers.IsNumber("1111,87", false));
            Assert.AreEqual(false, StringHelpers.IsNumber("1111,87", true));
            Assert.AreEqual(false, StringHelpers.IsNumber("1rew1,87", false));
            Assert.AreEqual(false, StringHelpers.IsNumber("1rew187", true));    
            Assert.AreEqual(false, StringHelpers.IsNumber("", false));
            Assert.AreEqual(false, StringHelpers.IsNumber(null, false));
        }
    }
}
