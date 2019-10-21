using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class NormalizePathSlashes
    {
        [TestMethod]
        public void NormalUse()
        {
            Assert.AreEqual("/var/lib/file.txt".NormalizePathSlashes(), "\\var\\lib\\file.txt");
        }
    }
}
