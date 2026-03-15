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
            Assert.AreEqual("Carro ônibus carro carro", StringHelpers.ReplaceFirstOccurrence("Carro carro carro carro", "carro", "ônibus"));
            Assert.AreEqual("kabuto", StringHelpers.ReplaceFirstOccurrence("kabuto", "ja", "mo"));
            Assert.Throws<ArgumentNullException>(() => StringHelpers.ReplaceFirstOccurrence(null, null, "comeu"));
            Assert.Throws<ArgumentNullException>(() => StringHelpers.ReplaceFirstOccurrence(null, "sdaf", null));
            Assert.AreEqual(String.Empty, StringHelpers.ReplaceFirstOccurrence(String.Empty, "ma", "mo"));

        }
    }
}
