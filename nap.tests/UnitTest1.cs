using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nap.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string helloStr = Program.Test();
            Assert.AreEqual("Hello World!", helloStr);
        }
    }
}
