using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class ReplaceNonANSICharactersWith
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual("jäspion-?", "jäspion-ﮝ".ReplaceNonANSICharactersWith('?'));
        }

        [TestMethod]
        public void Empty_String()
        {
            Assert.AreEqual(String.Empty, String.Empty.ReplaceNonANSICharactersWith('?'));
        }
    }
}
