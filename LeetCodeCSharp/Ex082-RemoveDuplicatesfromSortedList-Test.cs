using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex082Test
    {
        [TestMethod]
        public void LeetCode_Ex082_Test_DeleteDuplicates1()
        {
            ListNode l1 = new ListNode(1), 
                l2 = new ListNode(2), 
                l3 = new ListNode(2), 
                l4 = new ListNode(4);
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4;
            ListNode r = Ex082.DeleteDuplicates(l1);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
        }

        [TestMethod]
        public void LeetCode_Ex082_Test_DeleteDuplicates2()
        {
            ListNode l1 = new ListNode(1), 
                l2 = new ListNode(2), 
                l3 = new ListNode(3), 
                l4 = new ListNode(4);
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4;
            ListNode r = Ex082.DeleteDuplicates(l1);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.AreEqual(3, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
        }

        [TestMethod]
        public void LeetCode_Ex082_Test_DeleteDuplicates3()
        {
            ListNode l1 = new ListNode(1);
            ListNode r = Ex082.DeleteDuplicates(l1);
            Assert.AreEqual(1, r.Val); r = r.Next;
        }

        [TestMethod]
        public void LeetCode_Ex082_Test_DeleteDuplicates4()
        {
            ListNode l1 = new ListNode(2), 
                l2 = new ListNode(2), 
                l3 = new ListNode(2), 
                l4 = new ListNode(2);
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4;
            ListNode r = Ex082.DeleteDuplicates(l1);
            Assert.AreEqual(2, r.Val); r = r.Next;
            Assert.IsNull(r);
        }
    };
}