using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q06Test
    {
        [TestMethod]
        public void CRCup_CH18_06_FindRank1()
        {
            int[] test = { 3, 2, 4, 6, 5, 1, 7, 8, 9, 0 };
            Assert.AreEqual(6, Chapter18_Q06.FindRank(test, 6));
        }

        [TestMethod]
        public void CRCup_CH18_06_FindRank2()
        {
            int[] test = { 3, 2, 4, 6, 5, 1, 7, 8, 9, 0 };
            Assert.AreEqual(9, Chapter18_Q06.FindRank(test, 9));
        }

        [TestMethod]
        public void CRCup_CH18_06_FindRank3()
        {
            int[] test = { 3, 2, 4, 6, 5, 1, 7, 8, 9, 0 };
            Assert.AreEqual(1, Chapter18_Q06.FindRank(test, 1));
        }

        [TestMethod]
        public void CRCup_CH18_06_FindRank4()
        {
            int[] test = { 3, 2, 4, 6, 5, 1, 7, 8, 9, 0 };
            Assert.AreEqual(9, Chapter18_Q06.FindRank(test, 9));
        }
    }
}
