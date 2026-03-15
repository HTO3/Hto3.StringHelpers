using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class TryGetLastName
    {
        [TestMethod]
        public void NormalUse()
        {
            String test1 = null;
            Assert.AreEqual(true, StringHelpers.TryGetLastName("John Doe", out test1));
            Assert.AreEqual("Doe", test1);

            String test2 = null;
            Assert.AreEqual(false, StringHelpers.TryGetLastName("John", out test2));
            Assert.AreEqual(null, test2);

            String test3 = null;
            Assert.AreEqual(false, StringHelpers.TryGetLastName("JohnDoe", out test3));
            Assert.AreEqual(null, test3);

            String test4 = null;
            Assert.AreEqual(true, StringHelpers.TryGetLastName("John Doe Master", out test4));
            Assert.AreEqual("Master", test4);

            String test5 = null;
            Assert.AreEqual(false, StringHelpers.TryGetLastName(null, out test5));
            Assert.AreEqual(null, test5);

            String test6 = null;
            Assert.AreEqual(false, StringHelpers.TryGetLastName("", out test6));
            Assert.AreEqual(null, test6);
        }
    }
}
