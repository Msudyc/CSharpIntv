using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex064Test
    {
        [TestMethod]
        public void LeetCode_Ex064_Test_MergeTwoLists1()
        {
            ListNode a0 = new ListNode(1), 
                a1 = new ListNode(2), 
                a2 = new ListNode(5);
            a0.Next = a1; 
            a1.Next = a2;

            ListNode b0 = new ListNode(3), 
                b1 = new ListNode(4), 
                b2 = new ListNode(6);
            b0.Next = b1; 
            b1.Next = b2;

            ListNode r = Ex064.MergeTwoLists(a0, b0);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
            Assert.AreEqual(5, r.Val); r = r.Next;
            Assert.AreEqual(6, r.Val); r = r.Next;
        }

        [TestMethod]
        public void LeetCode_Ex064_Test_MergeTwoLists2()
        {
            ListNode a0 = new ListNode(1);
            ListNode b0 = new ListNode(3);
            ListNode r = Ex064.MergeTwoLists(a0, b0);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
        }

        [TestMethod]
        public void LeetCode_Ex064_Test_MergeTwoLists3()
        {
            ListNode a0 = new ListNode(1), 
                a1 = new ListNode(2), 
                a2 = new ListNode(5);
            a0.Next = a1; 
            a1.Next = a2;

            ListNode r = Ex064.MergeTwoLists(a0, null);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(5, r.Val); r = r.Next;
        }

        [TestMethod]
        public void LeetCode_Ex064_Test_MergeTwoLists4()
        {
            ListNode a0 = new ListNode(1), 
                a1 = new ListNode(2), 
                a2 = new ListNode(5);
            a0.Next = a1; a1.Next = a2;

            ListNode r = Ex064.MergeTwoLists(null, a0);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(5, r.Val); r = r.Next;
        }
    };
}