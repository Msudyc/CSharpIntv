using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex061Test
    {
        [TestMethod]
        public void LeetCode_Ex061_Test_UniquePaths1()
        {
            Assert.AreEqual(2, Ex061.UniquePaths(2, 2));
            Assert.AreEqual(28, Ex061.UniquePaths(3, 7));
        }

        [TestMethod]
        public void LeetCode_Ex061_Test_UniquePaths2()
        {
            Assert.AreEqual(3, Ex061.UniquePaths(3, 2));
        }

        [TestMethod]
        public void LeetCode_Ex061_Test_UniquePaths3()
        {
            Assert.AreEqual(1, Ex061.UniquePaths(1, 2));
        }

        [TestMethod]
        public void LeetCode_Ex061_Test_UniquePaths4()
        {
            Assert.AreEqual(1, Ex061.UniquePaths(1, 1));
        }
    };
}