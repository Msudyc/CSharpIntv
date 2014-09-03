using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex022Test
    {
        [TestMethod]
        public void LeetCode_Ex022_Test_MergeKLists1()
        {
            List<ListNode> t = new List<ListNode>();
            ListNode h1 = new ListNode(1);  
            ListNode h2 = new ListNode(2); 
            ListNode h3 = new ListNode(3);
            ListNode h4 = new ListNode(4);  
            ListNode h5 = new ListNode(5); 
            ListNode h6 = new ListNode(6);
            ListNode h7 = new ListNode(7); 
            ListNode h8 = new ListNode(8); 
            ListNode h9 = new ListNode(9);

            h1.Next = h4; 
            h4.Next = h7;
            h2.Next = h5; 
            h5.Next = h8;
            h3.Next = h6; 
            h6.Next = h9;

            t.Add(h1);
            t.Add(h2);
            t.Add(h3);

            ListNode r = Ex022.MergeKLists(t);

            Assert.AreEqual(1, r.Val);
            r = r.Next;
            Assert.AreEqual(2, r.Val);
            r = r.Next;
            Assert.AreEqual(3, r.Val);
            r = r.Next;
            Assert.AreEqual(4, r.Val);
            r = r.Next;
            Assert.AreEqual(5, r.Val);
            r = r.Next;
            Assert.AreEqual(6, r.Val);
            r = r.Next;
            Assert.AreEqual(7, r.Val);
            r = r.Next;
            Assert.AreEqual(8, r.Val);
            r = r.Next;
            Assert.AreEqual(9, r.Val);
            r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex022_Test_MergeKLists2()
        {
            List<ListNode > t = new List<ListNode>();
            ListNode h1 = new ListNode(1);  
            ListNode h2 = new ListNode(2); 
            ListNode h3 = new ListNode(3);
            ListNode h4 = new ListNode(4);  
            ListNode h5 = new ListNode(5); 
            ListNode h6 = new ListNode(6);
            ListNode h7 = new ListNode(7); 
            ListNode h8 = new ListNode(8); 
            ListNode h9 = new ListNode(9);

            h1.Next = h4; 
            h4.Next = h7; 
            h7.Next = h8;
            h2.Next = h5;
            h3.Next = h6; 
            h6.Next = h9;

            t.Add(h1);
            t.Add(h2);
            t.Add(h3);

            ListNode r = Ex022.MergeKLists(t);

            Assert.AreEqual(1, r.Val);
            r = r.Next;
            Assert.AreEqual(2, r.Val);
            r = r.Next;
            Assert.AreEqual(3, r.Val);
            r = r.Next;
            Assert.AreEqual(4, r.Val);
            r = r.Next;
            Assert.AreEqual(5, r.Val);
            r = r.Next;
            Assert.AreEqual(6, r.Val);
            r = r.Next;
            Assert.AreEqual(7, r.Val);
            r = r.Next;
            Assert.AreEqual(8, r.Val);
            r = r.Next;
            Assert.AreEqual(9, r.Val);
            r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void LeetCode_Ex022_Test_MergeKLists3()
        {
            List<ListNode> t = new List<ListNode>();
            ListNode h1 = new ListNode(1);
            ListNode h2 = new ListNode(2);
            ListNode h3 = new ListNode(3);
            ListNode h4 = new ListNode(4);
            ListNode h5 = new ListNode(5);
            ListNode h6 = new ListNode(6);
            ListNode h7 = new ListNode(7);
            ListNode h8 = new ListNode(8);
            ListNode h9 = new ListNode(9);
            
            h2.Next = h4; 
            h4.Next = h5; 
            h5.Next = h7; 
            h7.Next = h8;
            h3.Next = h6; 
            h6.Next = h9;

            t.Add(h1);
            t.Add(h2);
            t.Add(h3);

            ListNode r = Ex022.MergeKLists(t);

            Assert.AreEqual(1, r.Val);
            r = r.Next;
            Assert.AreEqual(2, r.Val);
            r = r.Next;
            Assert.AreEqual(3, r.Val);
            r = r.Next;
            Assert.AreEqual(4, r.Val);
            r = r.Next;
            Assert.AreEqual(5, r.Val);
            r = r.Next;
            Assert.AreEqual(6, r.Val);
            r = r.Next;
            Assert.AreEqual(7, r.Val);
            r = r.Next;
            Assert.AreEqual(8, r.Val);
            r = r.Next;
            Assert.AreEqual(9, r.Val);
            r = r.Next;
            Assert.IsNull(r);
        }
    };
}