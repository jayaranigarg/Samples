using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Issue348
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string value = System.Configuration.ConfigurationManager.AppSettings["LifeKey"];
            Assert.AreEqual(value, "YOLO");
        }
    }
}
