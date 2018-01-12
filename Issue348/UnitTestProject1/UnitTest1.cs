using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string value = System.Configuration.ConfigurationManager.AppSettings["FunKey"];
            Assert.AreEqual(value, "Dance");
        }
    }
}
