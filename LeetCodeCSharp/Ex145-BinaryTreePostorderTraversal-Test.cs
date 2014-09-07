using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex145Test
    {
        [TestMethod]
        public void LeetCode_Ex145_Test_PostorderTraversal1()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                ll = new TreeNode(3),
                r = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l;
            root.Right = r;
            l.Left = ll;
            r.Right = rr;
            List<int> res = Ex145.PostorderTraversal(root);
            Assert.AreEqual(3, res[0]);
            Assert.AreEqual(2, res[1]);
            Assert.AreEqual(5, res[2]);
            Assert.AreEqual(4, res[3]);
            Assert.AreEqual(1, res[4]);
        }

        [TestMethod]
        public void LeetCode_Ex145_Test_PostorderTraversal2()
        {
            TreeNode root = new TreeNode(1),
                l = new TreeNode(2),
                r = new TreeNode(4),
                rr = new TreeNode(5);
            root.Left = l;
            root.Right = r;
            r.Right = rr;
            List<int> res = Ex145.PostorderTraversal(root);
            Assert.AreEqual(2, res[0]);
            Assert.AreEqual(5, res[1]);
            Assert.AreEqual(4, res[2]);
            Assert.AreEqual(1, res[3]);
        }
    };
}