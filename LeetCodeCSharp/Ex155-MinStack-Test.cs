using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex155Test
    {
        [TestMethod]
        public void LeetCode_Ex155_Test_MinStack1()
        {
            Ex155.MinStack minStk = new Ex155.MinStack();
            minStk.Push(5);
            Assert.AreEqual(5, minStk.Top());
            Assert.AreEqual(5, minStk.GetMin());

            minStk.Push(3);
            Assert.AreEqual(3, minStk.Top());
            Assert.AreEqual(3, minStk.GetMin());

            minStk.Push(6);
            Assert.AreEqual(6, minStk.Top());
            Assert.AreEqual(3, minStk.GetMin());

            Assert.AreEqual(6, minStk.Pop());
            Assert.AreEqual(3, minStk.Top());
            Assert.AreEqual(3, minStk.GetMin());
        }
    };
}