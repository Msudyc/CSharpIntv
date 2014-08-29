using System;
using CRCup150CSharp;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter03_Q06Test
    {
        [TestMethod]
        public void CRCup_CH03_06_Sort1()
        {
            Stack<int> test = new Stack<int>();
            test.Push(3);
            test.Push(2);
            test.Push(5);
            test.Push(6);
            test.Push(7);
            test.Push(4);
            test.Push(1);

            Stack<int> r = Chapter03_Q06.Sort(test);
            Assert.AreEqual(7, r.Pop());
            Assert.AreEqual(6, r.Pop());
            Assert.AreEqual(5, r.Pop());
            Assert.AreEqual(4, r.Pop());
            Assert.AreEqual(3, r.Pop());
            Assert.AreEqual(2, r.Pop());
            Assert.AreEqual(1, r.Pop());
        }
    }
}
