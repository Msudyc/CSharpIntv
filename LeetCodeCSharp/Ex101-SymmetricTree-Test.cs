using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex101Test
    {
        [TestMethod]
        public void LeetCode_Ex101_Test_IsSymmetric1()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                ll = new TreeNode(3), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Left = l; 
            root.Right = r;
            l.Left = ll; 
            r.Right = rr;
            Assert.IsTrue(Ex101.IsSymmetric(root));
        }

        [TestMethod]
        public void LeetCode_Ex101_Test_IsSymmetric2()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                ll = new TreeNode(3), 
                r = new TreeNode(2), 
                rr = new TreeNode(4);
            root.Left = l; 
            root.Right = r;
            l.Left = ll; 
            r.Right = rr;
            Assert.IsFalse(Ex101.IsSymmetric(root));
        }

        [TestMethod]
        public void LeetCode_Ex101_Test_IsSymmetric3()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                ll = new TreeNode(3), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Left = l; 
            root.Right = r;
            l.Right = ll; 
            r.Right = rr;
            Assert.IsFalse(Ex101.IsSymmetric(root));
        }

        [TestMethod]
        public void LeetCode_Ex101_Test_IsSymmetric4()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                ll = new TreeNode(3), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Left = l; 
            root.Right = r;
            l.Right = ll; 
            r.Left = rr;
            Assert.IsTrue(Ex101.IsSymmetric(root));
        }
    };
}