using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class ReplaceWholeWord
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual("O rato comeu a roupa", StringHelpers.ReplaceWholeWord("O rato roeu a roupa", "roeu", "comeu", false));
            Assert.AreEqual("O rato Roeu a roupa", StringHelpers.ReplaceWholeWord("O rato Roeu a roupa", "roeu", "comeu", false));
            Assert.AreEqual("O rato comeu a roupa", StringHelpers.ReplaceWholeWord("O rato Roeu a roupa", "roeu", "comeu", true));
            Assert.AreEqual("_ rato Roeu a roupa", StringHelpers.ReplaceWholeWord("O rato Roeu a roupa", "O", "_", false));
            Assert.AreEqual("O rato Roeu a _", StringHelpers.ReplaceWholeWord("O rato Roeu a roupa", "roupa", "_", false));
            Assert.AreEqual("Oratoroeuaroupa", StringHelpers.ReplaceWholeWord("Oratoroeuaroupa", "eua", "_", false));
            Assert.AreEqual("O\r\nrato\r\ncomeu\r\na\r\nroupa", StringHelpers.ReplaceWholeWord("O\r\nrato\r\nroeu\r\na\r\nroupa", "roeu", "comeu", false));
            Assert.AreEqual("O\trato\tcomeu\ta\troupa", StringHelpers.ReplaceWholeWord("O\trato\troeu\ta\troupa", "roeu", "comeu", false));
            Assert.AreEqual(null, StringHelpers.ReplaceWholeWord(null, "roeu", "comeu", false));
            Assert.AreEqual("", StringHelpers.ReplaceWholeWord("", "roeu", "comeu", false));
            Assert.Throws<ArgumentNullException>(() => StringHelpers.ReplaceWholeWord(null, null, "comeu", false));
            Assert.Throws<ArgumentNullException>(() => StringHelpers.ReplaceWholeWord(null, "sdaf", null, false));
        }
    }
}
