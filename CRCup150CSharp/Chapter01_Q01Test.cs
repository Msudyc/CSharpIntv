using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter01_Q01Test
    {
        [TestMethod]
        public void CRCup_CH01_01_IsUniqueCharacters1()
        {
            Assert.IsTrue(Chapter01_Q01.IsUniqueCharacters("a12vbdxse"));
        }

        [TestMethod]
        public void CRCup_CH01_01_IsUniqueCharacters2()
        {
            Assert.IsFalse(Chapter01_Q01.IsUniqueCharacters("a12vbdaxse"));
        }

        [TestMethod]
        public void CRCup_CH01_01_IsUniqueCharacters3()
        {
            Assert.IsTrue(Chapter01_Q01.IsUniqueCharacters2("a12vbdxse"));
        }

        [TestMethod]
        public void CRCup_CH01_01_IsUniqueCharacters4()
        {
            Assert.IsFalse(Chapter01_Q01.IsUniqueCharacters2("a12vbdaxse"));
        }
    }
}
