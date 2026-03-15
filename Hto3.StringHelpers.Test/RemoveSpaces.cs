using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class RemoveSpaces
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual("", StringHelpers.RemoveSpaces("     "));
            Assert.AreEqual("\tdd", StringHelpers.RemoveSpaces("\tdd"));
            Assert.AreEqual("Thebestchoice", StringHelpers.RemoveSpaces("The best choice"));
            Assert.AreEqual("", StringHelpers.RemoveSpaces(""));
            Assert.AreEqual(null, StringHelpers.RemoveSpaces(null));
        }
    }
}
