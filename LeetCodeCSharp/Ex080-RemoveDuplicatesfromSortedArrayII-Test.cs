using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex080Test
    {
        [TestMethod]
        public void LeetCode_Ex080_Test_RemoveDuplicates1()
        {
            int[] t = {1,1,1,2,2,3};
            Assert.AreEqual(5, Ex080.RemoveDuplicates(t));
        }

        [TestMethod]
        public void LeetCode_Ex080_Test_RemoveDuplicates2()
        {
            int[] t = {1,1,2,2,3};
            Assert.AreEqual(5, Ex080.RemoveDuplicates(t));
        }

        [TestMethod]
        public void LeetCode_Ex080_Test_RemoveDuplicates3()
        {
            int[] t = {1,1,1,1,1,1,2,2,3};
            Assert.AreEqual(5, Ex080.RemoveDuplicates(t));
        }

        [TestMethod]
        public void LeetCode_Ex080_Test_RemoveDuplicates4()
        {
            int[] t = {1,2,3};
            Assert.AreEqual(3, Ex080.RemoveDuplicates(t));
        }
    };
}