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
            Assert.AreEqual(Helpers.RemoveSpaces("     "), "");
            Assert.AreEqual(Helpers.RemoveSpaces("\tdd"), "\tdd");
            Assert.AreEqual(Helpers.RemoveSpaces("The best choice"), "Thebestchoice");
            Assert.AreEqual(Helpers.RemoveSpaces(""), "");
            Assert.AreEqual(Helpers.RemoveSpaces(null), null);
        }
    }
}
