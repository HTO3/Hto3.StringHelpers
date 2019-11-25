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

        [TestMethod]
        public void With_Empty_String()
        {
            Assert.AreEqual(String.Empty, StringHelpers.ToCsvSafe(String.Empty));
        }
    }
}
