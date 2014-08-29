using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter02_Q03Test
    {
        [TestMethod]
        public void CRCup_CH02_03_DeleteNode1()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(3);
            ListNode<int> n4 = new ListNode<int>(4);
            ListNode<int> n5 = new ListNode<int>(5);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            Chapter02_Q03.DeleteNode<int>(n3);

            ListNode<int> r = n1;
            Assert.AreEqual(1, r.Data);
            r = r.Next;
            Assert.AreEqual(2, r.Data);
            r = r.Next;
            Assert.AreEqual(4, r.Data);
            r = r.Next;
            Assert.AreEqual(5, r.Data);
            r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void CRCup_CH02_03_DeleteNode2()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(3);
            ListNode<int> n4 = new ListNode<int>(4);
            ListNode<int> n5 = new ListNode<int>(5);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            Chapter02_Q03.DeleteNode<int>(n1);

            ListNode<int> r = n1;
            Assert.AreEqual(2, r.Data);
            r = r.Next;
            Assert.AreEqual(3, r.Data);
            r = r.Next;
            Assert.AreEqual(4, r.Data);
            r = r.Next;
            Assert.AreEqual(5, r.Data);
            r = r.Next;
            Assert.IsNull(r);
        }

        [TestMethod]
        public void CRCup_CH02_03_DeleteNode3()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(3);
            ListNode<int> n4 = new ListNode<int>(4);
            ListNode<int> n5 = new ListNode<int>(5);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            Chapter02_Q03.DeleteNode<int>(n4);

            ListNode<int> r = n1;
            Assert.AreEqual(1, r.Data);
            r = r.Next;
            Assert.AreEqual(2, r.Data);
            r = r.Next;
            Assert.AreEqual(3, r.Data);
            r = r.Next;
            Assert.AreEqual(5, r.Data);
            r = r.Next;
            Assert.IsNull(r);
        }
    }
}
