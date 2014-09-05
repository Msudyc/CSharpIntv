using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex099Test
    {
        [TestMethod]
        public void LeetCode_Ex099_Test_RecoverTree1()
        {
            TreeNode root = new TreeNode(1), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Right = rr; rr.Right = r;
            TreeNode t = root;
            Ex099.RecoverTree(t);
            Assert.AreEqual(2, t.Right.Val);
            Assert.AreEqual(3, t.Right.Right.Val);
        }

        [TestMethod]
        public void LeetCode_Ex099_Test_RecoverTree2()
        {
            TreeNode root = new TreeNode(2), 
                r = new TreeNode(1), 
                rr = new TreeNode(3);
            root.Right = r; 
            r.Right = rr;
            TreeNode t = root;
            Ex099.RecoverTree(t);
            Assert.AreEqual(1, t.Val);
            Assert.AreEqual(2, t.Right.Val);
            Assert.AreEqual(3, t.Right.Right.Val);
        }

        [TestMethod]
        public void LeetCode_Ex099_Test_RecoverTree3()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                r = new TreeNode(3);
            root.Left = l; 
            root.Right = r;
            TreeNode t = root;
            Ex099.RecoverTree(t);
            Assert.AreEqual(2, t.Val);
            Assert.AreEqual(1, t.Left.Val);
            Assert.AreEqual(3, t.Right.Val);
        }

        [TestMethod]
        public void LeetCode_Ex099_Test_RecoverTree4()
        {
            TreeNode root = new TreeNode(3), 
                l = new TreeNode(1), 
                r = new TreeNode(2);
            root.Left = l; 
            root.Right = r;
            TreeNode t = root;
            Ex099.RecoverTree(t);
            Assert.AreEqual(2, t.Val);
            Assert.AreEqual(1, t.Left.Val);
            Assert.AreEqual(3, t.Right.Val);
        }
    };
}