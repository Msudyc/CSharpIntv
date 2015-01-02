using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex160Test
    {
        [TestMethod]
        public void LeetCode_Ex160_Test_GetIntersectionNode1()
        {
            ListNode h0 = new ListNode(0);
            ListNode h1 = new ListNode(1);
            ListNode h2 = new ListNode(2);
            ListNode h3 = new ListNode(3);
            ListNode h4 = new ListNode(4);
            ListNode h5 = new ListNode(5);

            h0.Next = h1;
            h1.Next = h4;
            h4.Next = h5;

            h2.Next = h3;
            h3.Next = h4;

            Assert.AreEqual(4, Ex160.GetIntersectionNode(h0, h2).Val);
        }

        [TestMethod]
        public void LeetCode_Ex160_Test_GetIntersectionNode2()
        {
            ListNode h0 = new ListNode(0);
            ListNode h1 = new ListNode(1);
            ListNode h3 = new ListNode(3);
            ListNode h4 = new ListNode(4);
            ListNode h5 = new ListNode(5);

            h0.Next = h1;
            h1.Next = h4;
            h4.Next = h5;

            h3.Next = h4;

            Assert.AreEqual(4, Ex160.GetIntersectionNode(h0, h3).Val);
        }

        [TestMethod]
        public void LeetCode_Ex160_Test_GetIntersectionNode3()
        {
            ListNode h0 = new ListNode(0);
            Assert.AreEqual(0, Ex160.GetIntersectionNode(h0, h0).Val);
        }
    };
}