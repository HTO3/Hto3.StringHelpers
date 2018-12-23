using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class RemoveCharactersAtEnd
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.RemoveCharactersAtEnd("Although", 2), "Althou");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                StringHelpers.RemoveCharactersAtEnd("Although", -2);
            });
            Assert.AreEqual(StringHelpers.RemoveCharactersAtEnd(null, 2), null);
            Assert.AreEqual(StringHelpers.RemoveCharactersAtEnd("Although", 20), "");
            Assert.AreEqual(StringHelpers.RemoveCharactersAtEnd("Although", 8), "");
        }
    }
}
