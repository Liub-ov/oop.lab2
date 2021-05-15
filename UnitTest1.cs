using ConsoleApp3;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cloud = new Cloud(4, "blue", "storm cloud", 500);
            var result = cloud.Clone();
            Assert.AreEqual(result.size, cloud.size);
            Assert.AreEqual(result.color, cloud.color);
            Assert.AreEqual(result.type, cloud.type);
            Assert.AreEqual(result.high, cloud.high);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var cloud = new Cloud(15, "white", "regular cloud", 1500);
            var result = cloud.Clone();
            Assert.AreEqual(result.size, cloud.size);
            Assert.AreEqual(result.color, cloud.color);
            Assert.AreEqual(result.type, cloud.type);
            Assert.AreEqual(result.high, cloud.high);
        }
    }
}
