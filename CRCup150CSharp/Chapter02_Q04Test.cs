using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter02_Q04Test
    {
        [TestMethod]
        public void CRCup_CH02_04_Partition1()
        {
            ListNode<int> n1 = new ListNode<int>(5);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(4);
            ListNode<int> n4 = new ListNode<int>(3);
            ListNode<int> n5 = new ListNode<int>(1);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            ListNode<int> r = Chapter02_Q04.Partition(n1, 3);
            Assert.AreEqual(2, r.Data);
            r = r.Next;
            Assert.AreEqual(1, r.Data);
            r = r.Next;
            Assert.AreEqual(5, r.Data);
            r = r.Next;
            Assert.AreEqual(4, r.Data);
            r = r.Next;
            Assert.AreEqual(3, r.Data);
            r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void CRCup_CH02_04_Partition2()
        {
            ListNode<int> n1 = new ListNode<int>(5);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(4);
            ListNode<int> n4 = new ListNode<int>(3);
            ListNode<int> n5 = new ListNode<int>(1);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            ListNode<int> r = Chapter02_Q04.Partition(n1, 0);
            Assert.AreEqual(5, r.Data);
            r = r.Next;
            Assert.AreEqual(2, r.Data);
            r = r.Next;
            Assert.AreEqual(4, r.Data);
            r = r.Next;
            Assert.AreEqual(3, r.Data);
            r = r.Next;
            Assert.AreEqual(1, r.Data);
            r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void CRCup_CH02_04_Partition3()
        {
            ListNode<int> n1 = new ListNode<int>(5);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(4);
            ListNode<int> n4 = new ListNode<int>(3);
            ListNode<int> n5 = new ListNode<int>(1);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            ListNode<int> r = Chapter02_Q04.Partition(n1, 6);
            Assert.AreEqual(5, r.Data);
            r = r.Next;
            Assert.AreEqual(2, r.Data);
            r = r.Next;
            Assert.AreEqual(4, r.Data);
            r = r.Next;
            Assert.AreEqual(3, r.Data);
            r = r.Next;
            Assert.AreEqual(1, r.Data);
            r = r.Next;
            Assert.IsNull(r);
        }
    }
}
