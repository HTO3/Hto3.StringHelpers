using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class ToAlphanumeric
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(Helpers.ToAlphanumeric("azAZ09"), "azAZ09");
            Assert.AreEqual(Helpers.ToAlphanumeric("-"), "");
            Assert.AreEqual(Helpers.ToAlphanumeric(""), "");
            Assert.AreEqual(Helpers.ToAlphanumeric(null), null);
        }
    }
}
