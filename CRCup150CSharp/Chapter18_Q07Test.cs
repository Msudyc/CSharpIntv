using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q07Test
    {
        [TestMethod]
        public void CRCup_CH18_07_PrintLongestWord1()
        {
            string[] test = { "cat", "banana", "dog", "nana", "walk", "walker", "dogwalker" };
            Assert.AreEqual("dogwalker", Chapter18_Q07.PrintLongestWord(test));
        }
    }
}
