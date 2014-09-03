using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex002Test
    {
        [TestMethod]
        public void LeetCode_Ex002_Test_FindMedianSortedArrays1()
		{
            int[] A = {1, 3, 5, 7};
            int[] B = {2, 4, 6};
            double result = Ex002.FindMedianSortedArrays(A, 4, B, 3);
            Assert.AreEqual(4.0, result);
        }
        
        [TestMethod]
        public void LeetCode_Ex002_Test_FindMedianSortedArrays2()
		{
            int[] A = {1, 3};
            int[] B = {2};
            double result = Ex002.FindMedianSortedArrays(A, 2, B, 1);
            Assert.AreEqual(2.0, result);
        }
        
        [TestMethod]
        public void LeetCode_Ex002_Test_FindMedianSortedArrays3()
		{
            int[] A = {1, 4};
            int[] B = {2, 3};
            double result = Ex002.FindMedianSortedArrays(A, 2, B, 2);
            Assert.AreEqual(2.5, result);
        }
    };
}