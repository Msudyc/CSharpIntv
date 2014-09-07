using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex138Test
    {
        [TestMethod]
        public void LeetCode_Ex138_Test_CopyRandomList1()
        {
            RandomListNode l0 = new RandomListNode(0), 
                l1 = new RandomListNode(1), 
                l2 = new RandomListNode(2), 
                l3 = new RandomListNode(3),
                l4 = new RandomListNode(4);
            l0.Next = l1; 
            l1.Next = l2; 
            l2.Next = l3; 
            l3.Next = l4;
            l0.Random = l2; 
            l3.Random = l0;

            RandomListNode r = Ex138.CopyRandomList(l0);
            Assert.AreEqual(0, r.Label);
            Assert.AreEqual(2, r.Random.Label); r = r.Next;
            Assert.AreEqual(1, r.Label); r = r.Next;
            Assert.AreEqual(2, r.Label); r = r.Next;
            Assert.AreEqual(3, r.Label);
            Assert.AreEqual(0, r.Random.Label); r = r.Next;
            Assert.AreEqual(4, r.Label);
        }
    };
}