using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex098Test
    {
        [TestMethod]
        public void LeetCode_Ex098_Test_IsValidBST1()
        {
            TreeNode root = new TreeNode(1), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Right = r; 
            r.Right = rr;
            Assert.IsTrue(Ex098.IsValidBST(root));
        }

        [TestMethod]
        public void LeetCode_Ex098_Test_IsValidBST2()
        {
            TreeNode root = new TreeNode(1), 
                r = new TreeNode(2), 
                rr = new TreeNode(3);
            root.Right = r; 
            r.Left = rr;
            Assert.IsFalse(Ex098.IsValidBST(root));
        }

        [TestMethod]
        public void LeetCode_Ex098_Test_IsValidBST3()
        {
            TreeNode root = new TreeNode(1);
            Assert.IsTrue(Ex098.IsValidBST(root));
        }

        [TestMethod]
        public void LeetCode_Ex098_Test_IsValidBST4()
        {
            Assert.IsTrue(Ex098.IsValidBST(null));
        }
    };
}