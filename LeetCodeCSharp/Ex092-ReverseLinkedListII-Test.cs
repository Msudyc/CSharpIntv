using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex092Test
    {
        [TestMethod]
        public void LeetCode_Ex092_Test_ReverseBetween1()
        {
            ListNode l1 = new ListNode(1),
                l2 = new ListNode(2),
                l3 = new ListNode(3),
                l4 = new ListNode(4),
                l5 = new ListNode(5);
            l1.Next = l2;
            l2.Next = l3;
            l3.Next = l4;
            l4.Next = l5;
            ListNode r = Ex092.ReverseBetween(l1, 2, 4);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(5, r.Val); r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex092_Test_ReverseBetween2()
        {
            ListNode l1 = new ListNode(1);
            ListNode r = Ex092.ReverseBetween(l1, 1, 1);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex092_Test_ReverseBetween3()
        {
            ListNode l1 = new ListNode(1),
                l2 = new ListNode(2),
                l3 = new ListNode(3),
                l4 = new ListNode(4),
                l5 = new ListNode(5);
            l1.Next = l2;
            l2.Next = l3;
            l3.Next = l4;
            l4.Next = l5;
            ListNode r = Ex092.ReverseBetween(l1, 1, 5);
            Assert.AreEqual(5, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex092_Test_ReverseBetween4()
        {
            ListNode l1 = new ListNode(1),
                l2 = new ListNode(2),
                l3 = new ListNode(3),
                l4 = new ListNode(4),
                l5 = new ListNode(5);
            l1.Next = l2;
            l2.Next = l3;
            l3.Next = l4;
            l4.Next = l5;
            ListNode r = Ex092.ReverseBetween(l1, 5, 5);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
            Assert.AreEqual(5, r.Val); r = r.Next;
            Assert.IsNull(r);
        }
    };
}