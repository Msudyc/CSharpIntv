using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex168Test
    {
        [TestMethod]
        public void LeetCode_Ex168_Test_ConvertToTitle1()
        {
            Assert.AreEqual("AB", Ex168.ConvertToTitle(28));
            Assert.AreEqual("BAA", Ex168.ConvertToTitle(1379));
        }

        [TestMethod]
        public void LeetCode_Ex168_Test_ConvertToTitle2()
        {
            Assert.AreEqual("C", Ex168.ConvertToTitleFromZero(2));
        }

        [TestMethod]
        public void LeetCode_Ex168_Test_ConvertToTitle3()
        {
            Assert.AreEqual("AC", Ex168.ConvertToTitleFromZero(28));
        }

        [TestMethod]
        public void LeetCode_Ex168_Test_ConvertToTitle4()
        {
            Assert.AreEqual("BAB", Ex168.ConvertToTitleFromZero(1379));
        }
    };
}