using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex060Test
    {
        [TestMethod]
        public void LeetCode_Ex060_Test_RotateRight1()
        {
            ListNode l1 = new ListNode(1); 
            ListNode l2 = new ListNode(2); 
            ListNode l3 = new ListNode(3); 
            ListNode l4 = new ListNode(4); 
            ListNode l5 = new ListNode(5); 
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4; 
            l4.Next = l5;

            ListNode r = Ex060.RotateRight(l1, 2);
            Assert.AreEqual(4, r.Val);
            r = r.Next;
            Assert.AreEqual(5, r.Val);
        }

        [TestMethod]
        public void LeetCode_Ex060_Test_RotateRight2()
        {
            ListNode l1 = new ListNode(1);

            ListNode r = Ex060.RotateRight(l1, 1);
            Assert.AreEqual(1, r.Val);
        }

        [TestMethod]
        public void LeetCode_Ex060_Test_RotateRight3()
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            ListNode l3 = new ListNode(3);
            ListNode l4 = new ListNode(4);
            ListNode l5 = new ListNode(5);
            l1.Next = l2;
            l2.Next = l3;
            l3.Next = l4;
            l4.Next = l5;

            ListNode r = Ex060.RotateRight(l1, 5);
            Assert.AreEqual(1, r.Val);
            r = r.Next;
            Assert.AreEqual(2, r.Val);
        }

        [TestMethod]
        public void LeetCode_Ex060_Test_RotateRight4()
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            ListNode l3 = new ListNode(3);
            ListNode l4 = new ListNode(4);
            ListNode l5 = new ListNode(5);
            l1.Next = l2;
            l2.Next = l3;
            l3.Next = l4;
            l4.Next = l5;

            ListNode r = Ex060.RotateRight(l1, 1);
            Assert.AreEqual(5, r.Val);
            r = r.Next;
            Assert.AreEqual(1, r.Val);
        }
    };
}