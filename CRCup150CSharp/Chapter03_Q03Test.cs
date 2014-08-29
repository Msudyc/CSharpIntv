using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter03_Q03Test
    {
        [TestMethod]
        public void CRCup_CH03_03_SetOfStacks1()
        {
            Chapter03_Q03.SetOfStacks stacks = new Chapter03_Q03.SetOfStacks();
            stacks.Push(1);
            stacks.Push(2);
            stacks.Push(3);
            stacks.Push(4);
            stacks.Push(5);
            stacks.Push(6);
            stacks.Push(7);

            Assert.AreEqual(7, stacks.Pop());
            Assert.AreEqual(6, stacks.Pop());
            Assert.AreEqual(5, stacks.Pop());
            Assert.AreEqual(4, stacks.Pop());
            Assert.AreEqual(3, stacks.Pop());
            Assert.AreEqual(2, stacks.Pop());
            Assert.AreEqual(1, stacks.Pop());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException ))]
        public void CRCup_CH03_03_SetOfStacks2()
        {
            Chapter03_Q03.SetOfStacks stacks = new Chapter03_Q03.SetOfStacks();
            stacks.Push(1);
            stacks.Push(2);
            stacks.Push(3);
            
            Assert.AreEqual(3, stacks.Pop());
            Assert.AreEqual(2, stacks.Pop());
            Assert.AreEqual(1, stacks.Pop());
            stacks.Pop();
        }
    }
}
