using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter01_Q03Test
    {
        [TestMethod]
        public void CRCup_CH01_03_Permutation1()
        {
            Assert.IsTrue(Chapter01_Q03.Permutation("abcdd", "ddbca"));
            Assert.IsTrue(Chapter01_Q03.Permutation2("abcdd", "ddbca"));
        }

        [TestMethod]
        public void CRCup_CH01_03_Permutation2()
        {
            Assert.IsFalse(Chapter01_Q03.Permutation("abcde", "ddbca"));
            Assert.IsFalse(Chapter01_Q03.Permutation2("abcde", "ddbca"));
        }

        [TestMethod]
        public void CRCup_CH01_03_Permutation3()
        {
            Assert.IsFalse(Chapter01_Q03.Permutation("abcdek", "ddbca"));
            Assert.IsFalse(Chapter01_Q03.Permutation2("abcdek", "ddbca"));
        }
    }
}
