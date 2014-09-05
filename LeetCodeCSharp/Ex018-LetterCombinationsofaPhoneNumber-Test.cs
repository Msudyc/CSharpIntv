using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex018Test
    {
        [TestMethod]
        public void LeetCode_Ex018_Test_LetterCombinations1()
        {
            List<string> r = Ex018.LetterCombinations("23");
            Assert.AreEqual(9, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex018_Test_LetterCombinations2()
        {
            List<string> r = Ex018.LetterCombinations("27");
            Assert.AreEqual(12, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex018_Test_LetterCombinations3()
        {
            List<string> r = Ex018.LetterCombinations("279");
            Assert.AreEqual(48, r.Count);
        }
    };
}