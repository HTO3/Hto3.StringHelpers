using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class RemoveCharactersAtBegining
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(StringHelpers.RemoveCharactersAtBegining("Although", 2), "though");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                StringHelpers.RemoveCharactersAtBegining("Although", -2);
            });
            Assert.AreEqual(StringHelpers.RemoveCharactersAtBegining(null, 2), null);
            Assert.AreEqual(StringHelpers.RemoveCharactersAtBegining("Although", 20), "");
            Assert.AreEqual(StringHelpers.RemoveCharactersAtBegining("Although", 8), "");
        }
    }
}
