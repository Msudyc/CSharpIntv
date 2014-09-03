using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex034Test
    {
        [TestMethod]
        public void LeetCode_Ex034_Test_SearchInsert1()
        {
            int[] t = {1, 3, 5, 6};
            Assert.AreEqual(1, Ex034.SearchInsert(t, 2));
        }

        [TestMethod]
        public void LeetCode_Ex034_Test_SearchInsert2()
        {
            int[] t = {1, 3, 5, 6};
            Assert.AreEqual(2, Ex034.SearchInsert(t, 5));
        }

        [TestMethod]
        public void LeetCode_Ex034_Test_SearchInsert3()
        {
            int[] t = {1, 3, 5, 6};
            Assert.AreEqual(4, Ex034.SearchInsert(t, 8));
        }

        [TestMethod]
        public void LeetCode_Ex034_Test_SearchInsert4()
        {
            int[] t = {2, 3, 5, 6};
            Assert.AreEqual(0, Ex034.SearchInsert(t, 1));
        }
    };
}