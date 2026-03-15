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
            Assert.AreEqual("azAZ09", StringHelpers.ToAlphanumeric("azAZ09"));
            Assert.AreEqual("", StringHelpers.ToAlphanumeric("-"));
            Assert.AreEqual("", StringHelpers.ToAlphanumeric(""));
            Assert.AreEqual(null, StringHelpers.ToAlphanumeric(null));
        }
    }
}
