using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter03_Q05Test
    {
        [TestMethod]
        public void CRCup_CH03_05_MyQueue1()
        {
            Chapter03_Q05.MyQueue queue = new Chapter03_Q05.MyQueue();
            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);
            queue.Add(5);

            Assert.AreEqual(1, queue.Remove());
            Assert.AreEqual(2, queue.Remove());
            queue.Add(6);
            queue.Add(7);

            Assert.AreEqual(3, queue.Remove());
            Assert.AreEqual(4, queue.Remove());
            Assert.AreEqual(5, queue.Remove());
            Assert.AreEqual(6, queue.Remove());
            Assert.AreEqual(7, queue.Remove());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void CRCup_CH03_05_MyQueue2()
        {
            Chapter03_Q05.MyQueue queue = new Chapter03_Q05.MyQueue();
            queue.Add(1);
            queue.Add(2);
            queue.Add(3);
            queue.Add(4);
            queue.Add(5);

            Assert.AreEqual(1, queue.Remove());
            Assert.AreEqual(2, queue.Remove());
            queue.Add(6);
            queue.Add(7);

            Assert.AreEqual(3, queue.Remove());
            Assert.AreEqual(4, queue.Remove());
            Assert.AreEqual(5, queue.Remove());
            Assert.AreEqual(6, queue.Remove());
            Assert.AreEqual(7, queue.Remove());
            queue.Remove();
        }
    }
}
