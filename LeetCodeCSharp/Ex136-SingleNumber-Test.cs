using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex136Test
    {
        [TestMethod]
        public void LeetCode_Ex136_Test_SingleNumber1()
        {
            int[] t = { 1, 3, 2, 4, 2, 1, 3 };
            Assert.AreEqual(4, Ex136.SingleNumber(t));
        }

        [TestMethod]
        public void LeetCode_Ex136_Test_SingleNumber2()
        {
            int[] t = { 1 };
            Assert.AreEqual(1, Ex136.SingleNumber(t));
        }
    };
}