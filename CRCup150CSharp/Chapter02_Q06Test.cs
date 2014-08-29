using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter02_Q06Test
    {
        [TestMethod]
        public void CRCup_CH02_06_FindBeginning1()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(3);
            ListNode<int> n4 = new ListNode<int>(4);
            ListNode<int> n5 = new ListNode<int>(5);
            ListNode<int> n6 = new ListNode<int>(6);
            ListNode<int> n7 = new ListNode<int>(7);
            ListNode<int> n8 = new ListNode<int>(8);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;
            n5.Next = n6;
            n6.Next = n7;
            n7.Next = n8;
            n8.Next = n3;

            ListNode<int> r = Chapter02_Q06.FindBeginning(n1);
            Assert.AreEqual(3, r.Data);
        }

        [TestMethod]
        public void CRCup_CH02_06_FindBeginning2()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(3);
            ListNode<int> n4 = new ListNode<int>(4);
            ListNode<int> n5 = new ListNode<int>(5);
            ListNode<int> n6 = new ListNode<int>(6);
            ListNode<int> n7 = new ListNode<int>(7);
            ListNode<int> n8 = new ListNode<int>(8);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;
            n5.Next = n6;
            n6.Next = n7;
            n7.Next = n8;

            ListNode<int> r = Chapter02_Q06.FindBeginning(n1);
            Assert.IsNull(r);
        }
    }
}
