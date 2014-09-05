using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex084Test
    {
        [TestMethod]
        public void LeetCode_Ex084_Test_LargestRectangleArea1()
        {
            int[] row0 = {2, 3, 5, 8, 4, 3};
            List<int> t = new List<int>(row0);
            Assert.AreEqual(15, Ex084.LargestRectangleArea(t));
        }

        [TestMethod]
        public void LeetCode_Ex084_Test_LargestRectangleArea2()
        {
            int[] row0 = {2, 3};
            List<int> t = new List<int>(row0);
            Assert.AreEqual(4, Ex084.LargestRectangleArea(t));
        }

        [TestMethod]
        public void LeetCode_Ex084_Test_LargestRectangleArea3()
        {
            int[] row0 = {2};
            List<int> t = new List<int>(row0);
            Assert.AreEqual(2, Ex084.LargestRectangleArea(t));
        }

        [TestMethod]
        public void LeetCode_Ex084_Test_LargestRectangleArea4()
        {
            int[] row0 = {2, 3, 5};
            List<int> t = new List<int>(row0);
            Assert.AreEqual(6, Ex084.LargestRectangleArea(t));
        }

        [TestMethod]
        public void LeetCode_Ex084_Test_LargestRectangleArea5()
        {
            int[] row0 = {1, 1};
            List<int> t = new List<int>(row0);
            Assert.AreEqual(2, Ex084.LargestRectangleArea(t));
        }
    };
}