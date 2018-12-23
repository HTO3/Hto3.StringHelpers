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
            Assert.AreEqual(StringHelpers.RemoveLineBreaks("\r\ndfdfdfdf\r\n"), "dfdfdfdf");
            Assert.AreEqual(StringHelpers.RemoveLineBreaks("\ndd\n"), "dd");
            Assert.AreEqual(StringHelpers.RemoveLineBreaks(""), "");
            Assert.AreEqual(StringHelpers.RemoveLineBreaks(null), null);
        }
    }
}
