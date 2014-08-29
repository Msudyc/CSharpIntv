using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter01_Q08Test
    {
        [TestMethod]
        public void CRCup_CH01_08_IsRotation1()
        {
            Assert.IsTrue(Chapter01_Q08.IsRotation("abcdefg", "cdefgab"));
        }

        [TestMethod]
        public void CRCup_CH01_08_IsRotation2()
        {
            Assert.IsFalse(Chapter01_Q08.IsRotation("abcdefgj", "cdefgab"));
        }

        [TestMethod]
        public void CRCup_CH01_08_IsRotation3()
        {
            Assert.IsFalse(Chapter01_Q08.IsRotation("abcdefh", "cdefgab"));
        }
    }
}
