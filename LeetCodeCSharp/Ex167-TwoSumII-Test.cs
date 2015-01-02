using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex167Test
    {
        [TestMethod]
        public void LeetCode_Ex167_Test_TwoSum1()
        {
            int[] test = {1, 3, 4, 5, 7, 8};
            List<int> result = Ex167.TwoSum(test, 10);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(5, result[1]);
        }
    };
}