using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex117Test
    {
        [TestMethod]
        public void LeetCode_Ex117_Test_Connect1()
        {
            TreeLinkNode root = new TreeLinkNode(1),
                l = new TreeLinkNode(2),
                r = new TreeLinkNode(3),
                ll = new TreeLinkNode(4),
                lr = new TreeLinkNode(5),
                rr = new TreeLinkNode(7);
            root.Left = l;
            root.Right = r;
            l.Left = ll;
            l.Right = lr;
            r.Right = rr;
            Ex117.Connect(root);
            Assert.AreEqual(3, l.Next.Val);
            Assert.AreEqual(5, ll.Next.Val);
            Assert.AreEqual(7, lr.Next.Val);
        }
    };
}