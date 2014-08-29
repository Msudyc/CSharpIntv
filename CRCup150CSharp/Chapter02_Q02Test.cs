using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter02_Q02Test
    {
        [TestMethod]
        public void CRCup_CH02_02_NthToLast1()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(2);
            ListNode<int> n4 = new ListNode<int>(3);
            ListNode<int> n5 = new ListNode<int>(4);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            ListNode<int> r = Chapter02_Q02.NthToLast<int>(n1, 3);
            Assert.AreEqual(2, r.Data);
        }

        [TestMethod]
        public void CRCup_CH02_02_NthToLast2()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(2);
            ListNode<int> n4 = new ListNode<int>(3);
            ListNode<int> n5 = new ListNode<int>(4);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            ListNode<int> r = Chapter02_Q02.NthToLast<int>(n1, 4);
            Assert.AreEqual(1, r.Data);
        }

        [TestMethod]
        public void CRCup_CH02_02_NthToLast3()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(2);
            ListNode<int> n4 = new ListNode<int>(3);
            ListNode<int> n5 = new ListNode<int>(4);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            ListNode<int> r = Chapter02_Q02.NthToLast<int>(n1, 5);
            Assert.IsNull(r);
        }

        [TestMethod]
        public void CRCup_CH02_02_NthToLast4()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(2);
            ListNode<int> n4 = new ListNode<int>(3);
            ListNode<int> n5 = new ListNode<int>(4);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;

            ListNode<int> r = Chapter02_Q02.NthToLast<int>(n1, 15);
            Assert.IsNull(r);
        }
    }
}
