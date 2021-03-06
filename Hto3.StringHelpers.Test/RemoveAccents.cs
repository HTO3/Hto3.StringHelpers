﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class RemoveAccents
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.RemoveAccents("jäspion("), "jaspion(");
            Assert.AreEqual(StringHelpers.RemoveAccents("jáspìôn"), "jaspion");
            Assert.AreEqual(StringHelpers.RemoveAccents(""), "");
            Assert.AreEqual(StringHelpers.RemoveAccents(null), null);
        }
    }
}
