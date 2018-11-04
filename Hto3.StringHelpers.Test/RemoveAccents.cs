using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class RemoveAccents
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual(Helpers.RemoveAccents("jäspion("), "jaspion(");
            Assert.AreEqual(Helpers.RemoveAccents("jáspìôn"), "jaspion");
            Assert.AreEqual(Helpers.RemoveAccents(""), "");
            Assert.AreEqual(Helpers.RemoveAccents(null), null);
        }
    }
}
