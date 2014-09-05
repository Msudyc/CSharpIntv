using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex079Test
    {
        [TestMethod]
        public void LeetCode_Ex079_Test_Exist1()
        {
            char[,] t = { { 'A', 'B', 'C', 'E' }, 
                          { 'S', 'F', 'C', 'S' }, 
                          { 'A', 'D', 'E', 'E' } };
            Assert.IsTrue(Ex079.Exist(t, "ABCCED"));
        }

        [TestMethod]
        public void LeetCode_Ex079_Test_Exist2()
        {
            char[,] t = { { 'A', 'B', 'C', 'E' }, 
                          { 'S', 'F', 'C', 'S' }, 
                          { 'A', 'D', 'E', 'E' } };
            Assert.IsTrue(Ex079.Exist(t, "ABC"));
        }

        [TestMethod]
        public void LeetCode_Ex079_Test_Exist3()
        {
            char[,] t = { { 'A', 'B', 'C', 'E' }, 
                          { 'S', 'F', 'C', 'S' }, 
                          { 'A', 'D', 'E', 'E' } };
            Assert.IsFalse(Ex079.Exist(t, "ABCB"));
        }

        [TestMethod]
        public void LeetCode_Ex079_Test_Exist4()
        {
            char[,] t = { { 'A', 'B', 'C', 'E' }, 
                          { 'S', 'F', 'C', 'S' }, 
                          { 'A', 'D', 'E', 'E' } };
            Assert.IsFalse(Ex079.Exist(t, "XYCZ"));
        }
    };
}