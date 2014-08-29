using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter03_Q02Test
    {
        [TestMethod]
        public void CRCup_CH03_02_StackWithMin1()
        {
            Chapter03_Q02.StackWithMin stack = new Chapter03_Q02.StackWithMin();
            stack.Push(2);
            Assert.AreEqual(2, stack.Min());
            stack.Push(1);
            Assert.AreEqual(1, stack.Min());
            stack.Push(3);
            Assert.AreEqual(1, stack.Min());

            Assert.AreEqual(3, stack.Pop());
            Assert.AreEqual(1, stack.Min());
            Assert.AreEqual(1, stack.Pop());
            Assert.AreEqual(2, stack.Min());
        }
    }
}
