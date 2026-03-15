using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class RemoveLineBreaks
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual("dfdfdfdf", StringHelpers.RemoveLineBreaks("\r\ndfdfdfdf\r\n"));
            Assert.AreEqual("dd", StringHelpers.RemoveLineBreaks("\ndd\n"));
            Assert.AreEqual("", StringHelpers.RemoveLineBreaks(""));
            Assert.AreEqual(null, StringHelpers.RemoveLineBreaks(null));
        }
    }
}
