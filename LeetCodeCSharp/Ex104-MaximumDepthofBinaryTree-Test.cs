using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex104Test
    {
        [TestMethod]
        public void LeetCode_Ex104_Test_MaxDepth1()
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
            Assert.AreEqual(4, Ex104.MaxDepth(root));
        }

        [TestMethod]
        public void LeetCode_Ex104_Test_MaxDepth2()
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
            Assert.AreEqual(3, Ex104.MaxDepth(root));
        }

        [TestMethod]
        public void LeetCode_Ex104_Test_MaxDepth3()
        {
            TreeNode root = new TreeNode(1);
            Assert.AreEqual(1, Ex104.MaxDepth(root));
        }

        [TestMethod]
        public void LeetCode_Ex104_Test_MaxDepth4()
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
            Assert.AreEqual(4, Ex104.MaxDepthNR(root));
        }

        [TestMethod]
        public void LeetCode_Ex104_Test_MaxDepth5()
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
            Assert.AreEqual(3, Ex104.MaxDepthNR(root));
        }

        [TestMethod]
        public void LeetCode_Ex104_Test_MaxDepth6()
        {
            TreeNode root = new TreeNode(1);
            Assert.AreEqual(1, Ex104.MaxDepthNR(root));
        }
    };
}