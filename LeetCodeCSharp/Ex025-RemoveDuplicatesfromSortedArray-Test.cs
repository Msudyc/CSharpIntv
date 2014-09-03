using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex025Test
    {
        [TestMethod]
        public void LeetCode_Ex025_Test_RemoveDuplicates1()
        {
            int[] t = {1, 1, 2};
            Assert.AreEqual(2, Ex025.RemoveDuplicates(t, 3));
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(2, t[1]);
        }

        [TestMethod]
        public void LeetCode_Ex025_Test_RemoveDuplicates2()
        {
            int[] t = {1, 2, 2, 3, 4, 5, 6, 6, 6};
            Assert.AreEqual(6, Ex025.RemoveDuplicates(t, 9));
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(2, t[1]);
            Assert.AreEqual(3, t[2]);
            Assert.AreEqual(4, t[3]);
            Assert.AreEqual(5, t[4]);
            Assert.AreEqual(6, t[5]);
        }

        [TestMethod]
        public void LeetCode_Ex025_Test_RemoveDuplicates3()
        {
            int[] t = {1};
            Assert.AreEqual(1, Ex025.RemoveDuplicates(t, 1));
            Assert.AreEqual(1, t[0]);
        }

        [TestMethod]
        public void LeetCode_Ex025_Test_RemoveDuplicates4()
        {
            int[] t = {1, 2};
            Assert.AreEqual(2, Ex025.RemoveDuplicates(t, 2));
            Assert.AreEqual(1, t[0]);
            Assert.AreEqual(2, t[1]);
        }

        [TestMethod]
        public void LeetCode_Ex025_Test_RemoveDuplicates5()
        {
            int[] t = {1, 1};
            Assert.AreEqual(1, Ex025.RemoveDuplicates(t, 2));
            Assert.AreEqual(1, t[0]);
        }
    };
}