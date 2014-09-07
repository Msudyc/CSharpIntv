using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex124Test
    {
        [TestMethod]
        public void LeetCode_Ex124_Test_MaxPathSum1()
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

            Assert.AreEqual(12, Ex124.MaxPathSum(root));
        }

        [TestMethod]
        public void LeetCode_Ex124_Test_MaxPathSum2()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                r = new TreeNode(3);

            root.Left = l; 
            root.Right = r;
            Assert.AreEqual(6, Ex124.MaxPathSum(root));
        }

        [TestMethod]
        public void LeetCode_Ex124_Test_MaxPathSum3()
        {
            TreeNode root = new TreeNode(1);
            Assert.AreEqual(1, Ex124.MaxPathSum(root));
        }
    };
}