using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex132Test
    {
        [TestMethod]
        public void LeetCode_Ex132_Test_MinCut1()
        {
            Assert.AreEqual(1, Ex132.MinCut("aab"));
        }

        [TestMethod]
        public void LeetCode_Ex132_Test_MinCut2()
        {
            Assert.AreEqual(0, Ex132.MinCut("aa"));
        }

        [TestMethod]
        public void LeetCode_Ex132_Test_MinCut3()
        {
            Assert.AreEqual(0, Ex132.MinCut("b"));
        }
    };
}