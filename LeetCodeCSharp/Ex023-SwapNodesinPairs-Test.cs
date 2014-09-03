using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex023Test
    {
        [TestMethod]
        public void LeetCode_Ex023_Test_SwapPairs1()
        {
            ListNode h1 = new ListNode(1);  
            ListNode h2 = new ListNode(2); 
            ListNode h3 = new ListNode(3);
            ListNode h4 = new ListNode(4);  
            ListNode h5 = new ListNode(5); 
            ListNode h6 = new ListNode(6);
            ListNode h7 = new ListNode(7); 
            ListNode h8 = new ListNode(8); 
            ListNode h9 = new ListNode(9);

            h1.Next = h2; 
            h2.Next = h3;
            h3.Next = h4; 
            h4.Next = h5;
            h5.Next = h6; 
            h6.Next = h7;
            h7.Next = h8; 
            h8.Next = h9;

            ListNode  r = Ex023.SwapPairs(h1);
            Assert.AreEqual(2, r.Val);
            r = r.Next;
            Assert.AreEqual(1, r.Val);
            r = r.Next;
            Assert.AreEqual(4, r.Val);
            r = r.Next;
            Assert.AreEqual(3, r.Val);
            r = r.Next;
            Assert.AreEqual(6, r.Val);
            r = r.Next;
            Assert.AreEqual(5, r.Val);
            r = r.Next;
            Assert.AreEqual(8, r.Val);
            r = r.Next;
            Assert.AreEqual(7, r.Val);
            r = r.Next;
            Assert.AreEqual(9, r.Val);
            r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex023_Test_SwapPairs2()
        {
            ListNode h1 = new ListNode(1);
            ListNode  r = Ex023.SwapPairs(h1);
            Assert.AreEqual(1, r.Val);
            r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex023_Test_SwapPairs3()
        {
            ListNode h1 = new ListNode(1);  
            ListNode h2 = new ListNode(2);
            h1.Next = h2;

            ListNode  r = Ex023.SwapPairs(h1);
            Assert.AreEqual(2, r.Val);
            r = r.Next;
            Assert.AreEqual(1, r.Val);
            r = r.Next;
            Assert.IsNull(r);
        }
    };
}