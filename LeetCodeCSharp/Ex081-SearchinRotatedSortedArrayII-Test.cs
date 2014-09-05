using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex081Test
    {
        [TestMethod]
        public void LeetCode_Ex081_Test_Search1()
        {
            int[] t = { 7, 7, 8, 9, 9, 1, 1, 2, 3, 3, 4, 4, 5 };
            Assert.IsTrue(Ex081.Search(t, 13, 4));
        }

        [TestMethod]
        public void LeetCode_Ex081_Test_Search2()
        {
            int[] t = { 7, 7, 8, 9, 9, 1, 1, 2, 3, 3, 4, 4, 5 };
            Assert.IsFalse(Ex081.Search(t, 13, 6));
        }

        [TestMethod]
        public void LeetCode_Ex081_Test_Search3()
        {
            int[] t = {7};
            Assert.IsTrue(Ex081.Search(t, 1, 7));
        }

        [TestMethod]
        public void LeetCode_Ex081_Test_Search4()
        {
            int[] t = {7};
            Assert.IsFalse(Ex081.Search(t, 1, 4));
        }
    };
}