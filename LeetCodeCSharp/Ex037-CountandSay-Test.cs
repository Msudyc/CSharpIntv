using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex037Test
    {
        [TestMethod]
        public void LeetCode_Ex037_Test_CountAndSay1()
        {
            Assert.AreEqual("1113213211", Ex037.CountAndSay(8));
        }

        [TestMethod]
        public void LeetCode_Ex037_Test_CountAndSay2()
        {
            Assert.AreEqual("1", Ex037.CountAndSay(1));
        }

        [TestMethod]
        public void LeetCode_Ex037_Test_CountAndSay3()
        {
            Assert.AreEqual("11", Ex037.CountAndSay(2));
        }

        [TestMethod]
        public void LeetCode_Ex037_Test_CountAndSay4()
        {
            Assert.AreEqual("21", Ex037.CountAndSay(3));
        }

        [TestMethod]
        public void LeetCode_Ex037_Test_CountAndSay5()
        {
            Assert.AreEqual("1211", Ex037.CountAndSay(4));
        }
    };
}