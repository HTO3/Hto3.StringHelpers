using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class ReplaceNonASCIICharactersWith
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual("jäspion-".ReplaceNonASCIICharactersWith('?'), "j?spion-");
        }
    }
}
