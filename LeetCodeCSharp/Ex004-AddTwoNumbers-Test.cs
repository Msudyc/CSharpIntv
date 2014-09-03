using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex004Test
    {
        [TestMethod]
        public void LeetCode_Ex004_Test_AddTwoNumbers1()
        {
            ListNode l1 = null, l2 = null;
            Assert.IsNull(Ex004.AddTwoNumbers(l1, l2));
        }

        [TestMethod]
        public void LeetCode_Ex004_Test_AddTwoNumbers2()
        {
            ListNode l1 = new ListNode(5);
            ListNode l2 = new ListNode(5);
            ListNode r = Ex004.AddTwoNumbers(l1, l2);
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(1, r.Val);
        }

        [TestMethod]
        public void LeetCode_Ex004_Test_AddTwoNumbers3()
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(9);
            l2.Next = new ListNode(9);
            ListNode r = Ex004.AddTwoNumbers(l1, l2);
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(1, r.Val);
        }

        [TestMethod]
        public void LeetCode_Ex004_Test_AddTwoNumbers4()
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(9);
            l2.Next = new ListNode(9);
            l2.Next.Next = new ListNode(9);
            ListNode r = Ex004.AddTwoNumbers(l1, l2);
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(1, r.Val);
        }

        [TestMethod]
        public void LeetCode_Ex004_Test_AddTwoNumbers5()
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(9);
            l2.Next = new ListNode(8);
            ListNode r = Ex004.AddTwoNumbers(l1, l2);
            Assert.AreEqual(0, r.Val);
            r = r.Next;
            Assert.AreEqual(9, r.Val);
        }
    };
}