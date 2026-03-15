using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class RandomString
    {
        [TestMethod]
        public void NormalUse()
        {
            var randomString1 = StringHelpers.RandomString(6);
            Assert.IsNotNull(randomString1);
            Assert.AreEqual(6, randomString1.Length);

            var randomString2 = StringHelpers.RandomString(0);
            Assert.IsNotNull(randomString2);
            Assert.AreEqual(0, randomString2.Length);

            var randomString3 = StringHelpers.RandomString(40);
            Assert.IsNotNull(randomString3);
            Assert.AreEqual(40, randomString3.Length);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                StringHelpers.RandomString(-10);
            });
        }
    }
}
