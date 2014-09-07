using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex129Test
    {
        [TestMethod]
        public void LeetCode_Ex129_Test_SumNumbers1()
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
            Assert.AreEqual(281, Ex129.SumNumbers(root));
        }

        [TestMethod]
        public void LeetCode_Ex129_Test_SumNumbers2()
        {
            TreeNode root = new TreeNode(1), 
                l = new TreeNode(2), 
                r = new TreeNode(3);
            root.Left = l; 
            root.Right = r;
            Assert.AreEqual(25, Ex129.SumNumbers(root));
        }

        [TestMethod]
        public void LeetCode_Ex129_Test_SumNumbers3()
        {
            TreeNode root = new TreeNode(1);
            Assert.AreEqual(1, Ex129.SumNumbers(root));
        }
    };
}