using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex086Test
    {
        [TestMethod]
        public void LeetCode_Ex086_Test_Partition1()
        {
            ListNode l1 = new ListNode(1), 
                l2 = new ListNode(3), 
                l3 = new ListNode(2), 
                l4 = new ListNode(5), 
                l5 = new ListNode(2);
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4; 
            l4.Next = l5;
            ListNode r = Ex086.Partition(l1, 3);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(5, r.Val); r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex086_Test_Partition2()
        {
            ListNode l1 = new ListNode(1);
            ListNode r = Ex086.Partition(l1, 1);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex086_Test_Partition3()
        {
            ListNode r = Ex086.Partition(null, 3);
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex086_Test_Partition4()
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
            ListNode  r = Ex086.Partition(l1, 3);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
            Assert.AreEqual(5, r.Val); r = r.Next;
            Assert.IsNull(r);
        }
    };
}