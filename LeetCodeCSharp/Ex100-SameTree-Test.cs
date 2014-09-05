using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex100Test
    {
        [TestMethod]
        public void LeetCode_Ex100_Test_IsSameTree1()
        {
            TreeNode root = new TreeNode(1), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Right = r; 
            r.Right = rr;
            TreeNode root1 = new TreeNode(1), 
                r1 = new TreeNode(2), 
                rr1 = new TreeNode(3);
            root1.Right = r1; 
            r1.Right = rr1;
            Assert.IsTrue(Ex100.IsSameTree(root, root1));
        }

        [TestMethod]
        public void LeetCode_Ex100_Test_IsSameTree2()
        {
            TreeNode root = new TreeNode(1), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Right = r; 
            r.Right = rr;
            TreeNode root1 = new TreeNode(1), 
                r1 = new TreeNode(2);
            root1.Right = r1;
            Assert.IsFalse(Ex100.IsSameTree(root, root1));
        }

        [TestMethod]
        public void LeetCode_Ex100_Test_IsSameTree3()
        {
            TreeNode root = new TreeNode(4), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Right = r; 
            r.Right = rr;
            TreeNode root1 = new TreeNode(1), 
                r1 = new TreeNode(2), 
                rr1 = new TreeNode(3);
            root1.Right = r1; 
            r1.Right = rr1;
            Assert.IsFalse(Ex100.IsSameTree(root, root1));
        }

        [TestMethod]
        public void LeetCode_Ex100_Test_IsSameTree4()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                r = new TreeNode(3);
            root.Left = l; 
            root.Right = r;
            TreeNode root1 = new TreeNode(1), 
                l1 = new TreeNode(2), 
                r1 = new TreeNode(3);
            root1.Left = l1; root1.Right = r1;
            Assert.IsTrue(Ex100.IsSameTree(root, root1));
        }
    };
}