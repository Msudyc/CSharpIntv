using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex105Test
    {
        [TestMethod]
        public void LeetCode_Ex105_Test_BuildTree1()
        {
            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            a.Add(4);
            a.Add(3);
            List<int> b = new List<int>();
            b.Add(4);
            b.Add(2);
            b.Add(1);
            b.Add(3);
            TreeNode r = Ex105.BuildTree(a, b);
            Assert.AreEqual(1, r.Val);
            Assert.AreEqual(2, r.Left.Val);
            Assert.AreEqual(3, r.Right.Val);
            Assert.AreEqual(4, r.Left.Left.Val);
        }
    };
}