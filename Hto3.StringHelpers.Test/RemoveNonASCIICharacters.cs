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
            Assert.AreEqual(StringHelpers.RemoveNonASCIICharacters("jäspion("), "jspion(");
            Assert.AreEqual(StringHelpers.RemoveNonASCIICharacters("App-le"), "App-le");
            Assert.AreEqual(StringHelpers.RemoveNonASCIICharacters("私は日本語がわからない"), "");
            Assert.AreEqual(StringHelpers.RemoveNonASCIICharacters(""), "");
            Assert.AreEqual(StringHelpers.RemoveNonASCIICharacters(null), null);
        }
    }
}
