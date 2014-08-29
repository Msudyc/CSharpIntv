using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter02_Q05Test
    {
        [TestMethod]
        public void CRCup_CH02_05_AddLists1()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(3);
            ListNode<int> n4 = new ListNode<int>(4);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;

            ListNode<int> m1 = new ListNode<int>(1);
            ListNode<int> m2 = new ListNode<int>(2);
            ListNode<int> m3 = new ListNode<int>(3);
            ListNode<int> m4 = new ListNode<int>(4);
            ListNode<int> m5 = new ListNode<int>(5);

            m1.Next = m2;
            m2.Next = m3;
            m3.Next = m4;
            m4.Next = m5;

            ListNode<int> r = Chapter02_Q05.AddLists(n1, m1);
            Assert.AreEqual(2, r.Data);
            r = r.Next;
            Assert.AreEqual(4, r.Data);
            r = r.Next;
            Assert.AreEqual(6, r.Data);
            r = r.Next;
            Assert.AreEqual(8, r.Data);
            r = r.Next;
            Assert.AreEqual(5, r.Data);
            r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void CRCup_CH02_05_AddLists2()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(3);
            ListNode<int> n4 = new ListNode<int>(6);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;

            ListNode<int> m1 = new ListNode<int>(1);
            ListNode<int> m2 = new ListNode<int>(2);
            ListNode<int> m3 = new ListNode<int>(3);
            ListNode<int> m4 = new ListNode<int>(4);
            ListNode<int> m5 = new ListNode<int>(9);
            ListNode<int> m6 = new ListNode<int>(9);
            ListNode<int> m7 = new ListNode<int>(9);

            m1.Next = m2;
            m2.Next = m3;
            m3.Next = m4;
            m4.Next = m5;
            m5.Next = m6;
            m6.Next = m7;

            ListNode<int> r = Chapter02_Q05.AddLists(n1, m1);
            Assert.AreEqual(2, r.Data);
            r = r.Next;
            Assert.AreEqual(4, r.Data);
            r = r.Next;
            Assert.AreEqual(6, r.Data);
            r = r.Next;
            Assert.AreEqual(0, r.Data);
            r = r.Next;
            Assert.AreEqual(0, r.Data);
            r = r.Next;
            Assert.AreEqual(0, r.Data);
            r = r.Next;
            Assert.AreEqual(0, r.Data);
            r = r.Next;
            Assert.AreEqual(1, r.Data);
            r = r.Next;
            Assert.IsNull(r);
        }
    }
}
