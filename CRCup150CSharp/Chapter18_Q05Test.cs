using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter18_Q05Test
    {
        [TestMethod]
        public void CRCup_CH18_05_Shortest1()
        {
            string[] words = { "he", "it", "dog", "cat", "she", "good", "he", "it" };
            Assert.AreEqual(2, Chapter18_Q05.Shortest(words, "he", "she"));
        }

        [TestMethod]
        public void CRCup_CH18_05_Shortest2()
        {
            string[] words = { "he", "it", "dog", "cat", "she", "good", "he", "it" };
            Assert.AreEqual(1, Chapter18_Q05.Shortest(words, "he", "it"));
        }
    }
}
