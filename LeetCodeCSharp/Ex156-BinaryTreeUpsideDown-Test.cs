using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex156Test
    {
        [TestMethod]
        public void LeetCode_Ex156_Test_UpsideDownBinaryTree1()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(3),
                ll = new TreeNode(4),
                lr = new TreeNode(5);
            root.Left = l;
            root.Right = r;
            l.Left = ll;
            l.Right = lr;

            TreeNode result = Ex156.UpsideDownBinaryTree(root);
            Assert.AreEqual(4, result.Val);
            Assert.AreEqual(5, result.Left.Val);
            Assert.AreEqual(2, result.Right.Val);
            Assert.AreEqual(3, result.Right.Left.Val);
            Assert.AreEqual(1, result.Right.Right.Val);
        }
    };
}