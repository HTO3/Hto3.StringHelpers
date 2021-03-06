﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            Assert.AreEqual(StringHelpers.ReplaceWholeWord("O rato roeu a roupa", "roeu", "comeu", false), "O rato comeu a roupa");
            Assert.AreEqual(StringHelpers.ReplaceWholeWord("O rato Roeu a roupa", "roeu", "comeu", false), "O rato Roeu a roupa");
            Assert.AreEqual(StringHelpers.ReplaceWholeWord("O rato Roeu a roupa", "roeu", "comeu", true), "O rato comeu a roupa");
            Assert.AreEqual(StringHelpers.ReplaceWholeWord("O rato Roeu a roupa", "O", "_", false), "_ rato Roeu a roupa");
            Assert.AreEqual(StringHelpers.ReplaceWholeWord("O rato Roeu a roupa", "roupa", "_", false), "O rato Roeu a _");
            Assert.AreEqual(StringHelpers.ReplaceWholeWord("Oratoroeuaroupa", "eua", "_", false), "Oratoroeuaroupa");
            Assert.AreEqual(StringHelpers.ReplaceWholeWord("O\r\nrato\r\nroeu\r\na\r\nroupa", "roeu", "comeu", false), "O\r\nrato\r\ncomeu\r\na\r\nroupa");
            Assert.AreEqual(StringHelpers.ReplaceWholeWord("O\trato\troeu\ta\troupa", "roeu", "comeu", false), "O\trato\tcomeu\ta\troupa");
            Assert.AreEqual(StringHelpers.ReplaceWholeWord(null, "roeu", "comeu", false), null);
            Assert.AreEqual(StringHelpers.ReplaceWholeWord("", "roeu", "comeu", false), "");
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Assert.AreEqual(StringHelpers.ReplaceWholeWord(null, null, "comeu", false), null);
            });
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Assert.AreEqual(StringHelpers.ReplaceWholeWord(null, "sdaf", null, false), null);
            });
        }
    }
}
