using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod()
        {
            //Added a comment
            Assert.AreEqual("Hello World!!", Program.SendMessage());
        }

        [TestMethod]
        public void TestMethod0()
        {
            //Added a comment
            Assert.AreEqual("Hello World!", Program.SendMessage());
        }

        [TestMethod]
        public void TestMethod1()
        {
            //Added a comment
            Assert.AreEqual("Hello World!", Program.SendMessage());
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Added a comment
            Assert.AreEqual("Hello World!", Program.SendMessage());
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Added a comment
            Assert.AreEqual("Hello World!", Program.SendMessage());
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Added a comment
            Assert.AreEqual("Hello World!", Program.SendMessage());
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Added a comment
            Assert.AreEqual("Hello World!", Program.SendMessage());
        }


    }
}
