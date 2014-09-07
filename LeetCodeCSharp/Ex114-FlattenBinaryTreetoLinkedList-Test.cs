using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex114Test
    {
        [TestMethod]
        public void LeetCode_Ex114_Test_Flatten1()
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
            TreeNode res = root;
            Ex114.Flatten(res);
            Assert.AreEqual(1, res.Val);
            Assert.AreEqual(2, res.Right.Val);
            Assert.AreEqual(3, res.Right.Right.Val);
            Assert.AreEqual(4, res.Right.Right.Right.Val);
            Assert.AreEqual(5, res.Right.Right.Right.Right.Val);
        }

        [TestMethod]
        public void LeetCode_Ex114_Test_Flatten2()
        {
            TreeNode root = new TreeNode(1);
            TreeNode res = root;
            Ex114.Flatten(res);
            Assert.AreEqual(1, res.Val);
            Assert.IsNull(res.Right);
        }
    };
}