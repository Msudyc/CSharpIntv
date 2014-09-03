using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex024Test
    {
        [TestMethod]
        public void LeetCode_Ex024_Test_ReverseKGroup1()
        {
            ListNode a1 = new ListNode(1), 
                a2 = new ListNode(2), 
                a3 = new ListNode(3), 
                a4 = new ListNode(4), 
                a5 = new ListNode(5), 
                a6 = new ListNode(6), 
                a7 = new ListNode(7);

            a1.Next = a2; 
            a2.Next = a3; 
            a3.Next = a4; 
            a4.Next = a5; 
            a5.Next = a6; 
            a6.Next = a7;
            ListNode r = Ex024.ReverseKGroup(a1, 3);
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(6, r.Val); r = r.Next;
            Assert.AreEqual(5, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
            Assert.AreEqual(7, r.Val); r = r.Next;
        }

        [TestMethod]
        public void LeetCode_Ex024_Test_ReverseKGroup2()
        {
            ListNode a1 = new ListNode(1),
                a2 = new ListNode(2),
                a3 = new ListNode(3),
                a4 = new ListNode(4),
                a5 = new ListNode(5),
                a6 = new ListNode(6),
                a7 = new ListNode(7);

            a1.Next = a2; 
            a2.Next = a3; 
            a3.Next = a4; 
            a4.Next = a5; 
            a5.Next = a6; 
            a6.Next = a7;

            ListNode r = Ex024.ReverseKGroup(a1, 10);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
            Assert.AreEqual(5, r.Val); r = r.Next;
            Assert.AreEqual(6, r.Val); r = r.Next;
            Assert.AreEqual(7, r.Val); r = r.Next;
        }
    };
}