using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter02_Q07Test
    {
        [TestMethod]
        public void CRCup_CH02_07_IsPalindrome1()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(3);
            ListNode<int> n4 = new ListNode<int>(4);
            ListNode<int> n5 = new ListNode<int>(4);
            ListNode<int> n6 = new ListNode<int>(3);
            ListNode<int> n7 = new ListNode<int>(2);
            ListNode<int> n8 = new ListNode<int>(1);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;
            n5.Next = n6;
            n6.Next = n7;
            n7.Next = n8;

            Assert.IsTrue(Chapter02_Q07.IsPalindrome(n1));
        }

        [TestMethod]
        public void CRCup_CH02_07_IsPalindrome2()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(3);
            ListNode<int> n4 = new ListNode<int>(4);
            ListNode<int> n5 = new ListNode<int>(5);
            ListNode<int> n6 = new ListNode<int>(4);
            ListNode<int> n7 = new ListNode<int>(3);
            ListNode<int> n8 = new ListNode<int>(2);
            ListNode<int> n9 = new ListNode<int>(1);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;
            n5.Next = n6;
            n6.Next = n7;
            n7.Next = n8;
            n8.Next = n9;

            Assert.IsTrue(Chapter02_Q07.IsPalindrome(n1));
        }

        [TestMethod]
        public void CRCup_CH02_07_IsPalindrome3()
        {
            ListNode<int> n1 = new ListNode<int>(1);
            ListNode<int> n2 = new ListNode<int>(2);
            ListNode<int> n3 = new ListNode<int>(3);
            ListNode<int> n4 = new ListNode<int>(4);
            ListNode<int> n5 = new ListNode<int>(5);
            ListNode<int> n6 = new ListNode<int>(4);
            ListNode<int> n7 = new ListNode<int>(3);
            ListNode<int> n8 = new ListNode<int>(1);
            ListNode<int> n9 = new ListNode<int>(1);

            n1.Next = n2;
            n2.Next = n3;
            n3.Next = n4;
            n4.Next = n5;
            n5.Next = n6;
            n6.Next = n7;
            n7.Next = n8;
            n8.Next = n9;

            Assert.IsFalse(Chapter02_Q07.IsPalindrome(n1));
        }
    }
}
