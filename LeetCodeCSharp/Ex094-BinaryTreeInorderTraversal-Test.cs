using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex094Test
    {
        [TestMethod]
        public void LeetCode_Ex094_Test_InorderTraversal1()
        {
            TreeNode root = new TreeNode(1), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Right = r; r.Left = rr;
            List<int> res = Ex094.InorderTraversal(root);
            Assert.AreEqual(1, res[0]);
            Assert.AreEqual(3, res[1]);
            Assert.AreEqual(2, res[2]);
        }

        [TestMethod]
        public void LeetCode_Ex094_Test_InorderTraversal2()
        {
            TreeNode root = new TreeNode(1);
            List<int> res = Ex094.InorderTraversal(root);
            Assert.AreEqual(1, res[0]);
        }

        [TestMethod]
        public void LeetCode_Ex094_Test_InorderTraversal3()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                r = new TreeNode(3), 
                rr = new TreeNode(4);
            root.Left = l; root.Right = r; r.Right = rr;
            List<int> res = Ex094.InorderTraversal(root);
            Assert.AreEqual(2, res[0]);
            Assert.AreEqual(1, res[1]);
            Assert.AreEqual(3, res[2]);
            Assert.AreEqual(4, res[3]);
        }

        [TestMethod]
        public void LeetCode_Ex094_Test_InorderTraversal4()
        {
            TreeNode root = new TreeNode(1), 
                r = new TreeNode(2);
            root.Right = r;
            List<int> res = Ex094.InorderTraversal(root);
            Assert.AreEqual(1, res[0]);
            Assert.AreEqual(2, res[1]);
        }
    };
}