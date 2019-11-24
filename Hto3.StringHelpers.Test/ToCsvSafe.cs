using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class ToCsvSafe
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual("\"a\"\"bcd123;\"\"\"", StringHelpers.ToCsvSafe("a\"bcd123;\""));
        }
    }
}
