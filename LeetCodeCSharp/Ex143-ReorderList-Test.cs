using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex143Test
    {
        [TestMethod]
        public void LeetCode_Ex143_Test_ReorderList1()
        {
            ListNode l1 = new ListNode(1), 
                l2 = new ListNode(2), 
                l3 = new ListNode(3), 
                l4 = new ListNode(4);
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4;
            Ex143.ReorderList(l1);
            Assert.AreEqual(4, l1.Next.Val);
            Assert.AreEqual(2, l1.Next.Next.Val);
            Assert.AreEqual(3, l1.Next.Next.Next.Val);
        }

        [TestMethod]
        public void LeetCode_Ex143_Test_ReorderList2()
        {
            ListNode l1 = new ListNode(1);
            Ex143.ReorderList(l1);
            Assert.AreEqual(1, l1.Val);
        }

        [TestMethod]
        public void LeetCode_Ex143_Test_ReorderList3()
        {
            ListNode l1 = new ListNode(1), 
                l2 = new ListNode(2);
            l1.Next = l2;
            Ex143.ReorderList(l1);
            Assert.AreEqual(1, l1.Val);
            Assert.AreEqual(2, l1.Next.Val);
        }

        [TestMethod]
        public void LeetCode_Ex143_Test_ReorderList4()
        {
            ListNode l1 = new ListNode(1), 
                l2 = new ListNode(2), 
                l3 = new ListNode(3);
            l1.Next = l2; 
            l2.Next = l3;
            Ex143.ReorderList(l1);
            Assert.AreEqual(1, l1.Val);
            Assert.AreEqual(3, l1.Next.Val);
            Assert.AreEqual(2, l1.Next.Next.Val);
        }
    };
}