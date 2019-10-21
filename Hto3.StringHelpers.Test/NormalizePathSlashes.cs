using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hto3.StringHelpers.Test
{
    [TestClass]
    public class NormalizePathSlashes
    {
        [TestMethod]
        public void NormalUse()
        {
            if (System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform.Windows))
                Assert.AreEqual("/var/lib/file.txt".NormalizePathSlashes(), "\\var\\lib\\file.txt");
            else
                Assert.AreEqual("/var/lib/file.txt".NormalizePathSlashes(), "/var/lib/file.txt");
        }
    }
}
