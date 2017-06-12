using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestPositiveScenario()
        {
            var testObject = new HelloWorld.HelloWorld();

            var actual = testObject.ReadString();
            var expected = "Hello World";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestNegativeScenario()
        {
            var testObject = new HelloWorld.HelloWorld();

            var actual = testObject.ReadString();
            var expected = "Not Equal";

            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestPositiveScenarioFile()
        {
            var testObject = new HelloWorld.ReadWriteFromFile();

            var actual = testObject.ReadString();
            var expected = "Hello World";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void NegativeScenarioFile()
        {
            var testObject = new HelloWorld.ReadWriteFromFile();

            var actual = testObject.ReadString();
            var expected = "Not Equal";

            Assert.AreNotEqual(expected, actual);
        }
    }
}
