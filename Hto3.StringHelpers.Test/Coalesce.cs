﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class Coalesce
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(Helpers.Coalesce(null, null, "6", "7"), "6");
            Assert.AreEqual(Helpers.Coalesce(null, null), null);
            Assert.AreEqual(Helpers.Coalesce("gg", null, null), "gg");
        }
    }
}
