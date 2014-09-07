using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex112Test
    {
        [TestMethod]
        public void LeetCode_Ex112_Test_HasPathSum1()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(3),
                rl = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l;
            root.Right = r;
            r.Left = rl;
            r.Right = rr;
            Assert.IsTrue(Ex112.HasPathSum(root, 8));
        }

        [TestMethod]
        public void LeetCode_Ex112_Test_HasPathSum2()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(3),
                rl = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l;
            root.Right = r;
            r.Left = rl;
            r.Right = rr;
            Assert.IsFalse(Ex112.HasPathSum(root, 10));
        }

        [TestMethod]
        public void LeetCode_Ex112_Test_HasPathSum3()
        {
            TreeNode root = new TreeNode(1);
            Assert.IsTrue(Ex112.HasPathSum(root, 1));
        }

        [TestMethod]
        public void LeetCode_Ex112_Test_HasPathSum4()
        {
            TreeNode root = new TreeNode(1);
            Assert.IsFalse(Ex112.HasPathSum(root, 2));
        }
    };
}