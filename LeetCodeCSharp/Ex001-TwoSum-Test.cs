using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex001Test
    {
        [TestMethod]
        public void LeetCode_Ex001_Test_TwoSum1()
        {
            int[] test = {2, 7, 11, 15};
            Tuple<int, int> result = Ex001.TwoSum(test, 9);
            Assert.AreEqual(1, result.Item1);
            Assert.AreEqual(2, result.Item2);
        }

        [TestMethod]
        public void LeetCode_Ex001_Test_TwoSum2()
        {
            int[] test = { 3, 2, 4 };
            Tuple<int, int> result = Ex001.TwoSum(test, 6);
            Assert.AreEqual(2, result.Item1);
            Assert.AreEqual(3, result.Item2);
        }
    };
}