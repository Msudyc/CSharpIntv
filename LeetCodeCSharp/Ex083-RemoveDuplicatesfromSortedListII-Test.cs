using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex083Test
    {
        [TestMethod]
        public void LeetCode_Ex083_Test_DeleteDuplicates1()
        {
            ListNode l1 = new ListNode(1), 
                l2 = new ListNode(2), 
                l3 = new ListNode(2), 
                l4 = new ListNode(4);
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4;
            ListNode r = Ex083.DeleteDuplicates(l1);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.AreEqual(4, r.Val); r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex083_Test_DeleteDuplicates2()
        {
            ListNode l1 = new ListNode(2), 
                l2 = new ListNode(2), 
                l3 = new ListNode(2), 
                l4 = new ListNode(4);
            l1.Next = l2;
            l2.Next = l3;
            l3.Next = l4;
            ListNode r = Ex083.DeleteDuplicates(l1);
            Assert.AreEqual(4, r.Val); r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex083_Test_DeleteDuplicates3()
        {
            ListNode l1 = new ListNode(1);
            ListNode r = Ex083.DeleteDuplicates(l1);
            Assert.AreEqual(1, r.Val); r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex083_Test_DeleteDuplicates4()
        {
            ListNode l1 = new ListNode(2), 
                l2 = new ListNode(2), 
                l3 = new ListNode(2), 
                l4 = new ListNode(2);
            l1.Next = l2;
            l2.Next = l3; 
            l3.Next = l4;
            ListNode r = Ex083.DeleteDuplicates(l1);
            Assert.IsNull(r);
        }
    };
}