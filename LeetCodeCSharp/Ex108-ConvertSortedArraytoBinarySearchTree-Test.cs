using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex108Test
    {
        [TestMethod]
        public void LeetCode_Ex108_Test_SortedArrayToBST1()
        {
            int[] row0 = { 1, 2, 3 };
            TreeNode r = Ex108.SortedArrayToBST(row0);
            Assert.AreEqual(2, r.Val);
            Assert.AreEqual(1, r.Left.Val);
            Assert.AreEqual(3, r.Right.Val);
        }
    };
}