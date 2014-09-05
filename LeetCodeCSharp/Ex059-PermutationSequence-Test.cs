using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex059Test
    {
        [TestMethod]
        public void LeetCode_Ex059_Test_GetPermutation1()
        {
            string r = Ex059.GetPermutation(4, 5);
            Assert.AreEqual("1423", r);
        }

        [TestMethod]
        public void LeetCode_Ex059_Test_GetPermutation2()
        {
            string r = Ex059.GetPermutation(1, 1);
            Assert.AreEqual("1", r);
        }

        [TestMethod]
        public void LeetCode_Ex059_Test_GetPermutation3()
        {
            string r = Ex059.GetPermutation(2, 1);
            Assert.AreEqual("12", r);
        }
    };
}