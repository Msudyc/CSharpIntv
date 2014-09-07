using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex128Test
    {
        [TestMethod]
        public void LeetCode_Ex128_Test_LongestConsecutive1()
        {
            int[] r0 = { 100, 4, 300, 2, 6, 1, 56, 3, 9, 30 };
            Assert.AreEqual(4, Ex128.LongestConsecutive(r0));
        }

        [TestMethod]
        public void LeetCode_Ex128_Test_LongestConsecutive2()
        {
            int[] r0 = { 100 };
            Assert.AreEqual(1, Ex128.LongestConsecutive(r0));
        }
    };
}