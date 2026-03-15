using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class RemoveNonASCIICharacters
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual("jspion(", StringHelpers.RemoveNonASCIICharacters("jäspion("));
            Assert.AreEqual("App-le", StringHelpers.RemoveNonASCIICharacters("App-le"));
            Assert.AreEqual("", StringHelpers.RemoveNonASCIICharacters("私は日本語がわからない"));
            Assert.AreEqual("", StringHelpers.RemoveNonASCIICharacters(""));
            Assert.AreEqual(null, StringHelpers.RemoveNonASCIICharacters(null));
        }
    }
}
