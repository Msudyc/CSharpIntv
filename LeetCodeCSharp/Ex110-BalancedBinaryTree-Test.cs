using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex110Test
    {
        [TestMethod]
        public void LeetCode_Ex110_Test_IsBalanced1()
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
            Assert.IsTrue(Ex110.IsBalanced(root));
        }

        [TestMethod]
        public void LeetCode_Ex110_Test_IsBalanced2()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(3),
                rl = new TreeNode(4),
                rr = new TreeNode(5),
                rrr = new TreeNode(6);
            root.Left = l;
            root.Right = r;
            r.Left = rl;
            r.Right = rr;
            rr.Right = rrr;
            Assert.IsFalse(Ex110.IsBalanced(root));
        }
    };
}