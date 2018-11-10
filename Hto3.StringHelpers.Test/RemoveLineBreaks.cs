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
            Assert.AreEqual(Helpers.RemoveLineBreaks("\r\ndfdfdfdf\r\n"), "dfdfdfdf");
            Assert.AreEqual(Helpers.RemoveLineBreaks("\ndd\n"), "dd");
            Assert.AreEqual(Helpers.RemoveLineBreaks(""), "");
            Assert.AreEqual(Helpers.RemoveLineBreaks(null), null);
        }
    }
}
