using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class ReplaceFirstOccurrence
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(Helpers.ReplaceFirstOccurrence("Carro carro carro carro", "carro", "ônibus"), "Carro ônibus carro carro");
            Assert.AreEqual(Helpers.ReplaceFirstOccurrence("kabuto", "ja", "mo"), "kabuto");
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Assert.AreEqual(Helpers.ReplaceFirstOccurrence(null, null, "comeu"), null);
            });
            Assert.ThrowsException<ArgumentNullException>(() =>
            {
                Assert.AreEqual(Helpers.ReplaceFirstOccurrence(null, "sdaf", null), null);
            });
        }
    }
}
