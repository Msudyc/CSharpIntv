using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter03_Q01Test
    {
        [TestMethod]
        public void CRCup_CH03_01_FixedSizeStacks1()
        {
            Chapter03_Q01.FixedSizeStacks stacks = new Chapter03_Q01.FixedSizeStacks();
            stacks.Push(0, 1);
            stacks.Push(0, 2);
            stacks.Push(0, 3);

            stacks.Push(1, 4);
            stacks.Push(1, 5);
            stacks.Push(1, 6);

            stacks.Push(2, 7);
            stacks.Push(2, 8);
            stacks.Push(2, 9);

            Assert.AreEqual(3, stacks.Pop(0));
            Assert.AreEqual(6, stacks.Pop(1));
            Assert.AreEqual(9, stacks.Pop(2));

            Assert.AreEqual(2, stacks.Peek(0));
            Assert.AreEqual(5, stacks.Peek(1));
            Assert.AreEqual(8, stacks.Peek(2));

            Assert.IsFalse(stacks.IsEmpty(0));
            Assert.IsFalse(stacks.IsEmpty(1));
            Assert.IsFalse(stacks.IsEmpty(2));
        }
    }
}
