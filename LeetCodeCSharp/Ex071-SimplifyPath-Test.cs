using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex071Test
    {
        [TestMethod]
        public void LeetCode_Ex071_Test_SimplifyPath1()
        {
            Assert.AreEqual("/home", Ex071.SimplifyPath("/home/"));
        }

        [TestMethod]
        public void LeetCode_Ex071_Test_SimplifyPath2()
        {
            Assert.AreEqual("/c", Ex071.SimplifyPath("/a/./b/../../c/"));
        }

        [TestMethod]
        public void LeetCode_Ex071_Test_SimplifyPath3()
        {
            Assert.AreEqual("/home/foo", Ex071.SimplifyPath("/home//foo/"));
        }

        [TestMethod]
        public void LeetCode_Ex071_Test_SimplifyPath4()
        {
            Assert.AreEqual("/home", Ex071.SimplifyPath("/home"));
        }
    };
}