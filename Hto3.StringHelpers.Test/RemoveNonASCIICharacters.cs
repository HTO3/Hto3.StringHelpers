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
            Assert.AreEqual(Helpers.RemoveNonASCIICharacters("jäspion("), "jspion(");
            Assert.AreEqual(Helpers.RemoveNonASCIICharacters("App-le"), "App-le");
            Assert.AreEqual(Helpers.RemoveNonASCIICharacters("私は日本語がわからない"), "");
            Assert.AreEqual(Helpers.RemoveNonASCIICharacters(""), "");
            Assert.AreEqual(Helpers.RemoveNonASCIICharacters(null), null);
        }
    }
}
