using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex085Test
    {
        [TestMethod]
        public void LeetCode_Ex085_Test_MaximalRectangle1()
        {
            char[,] t = { { '0', '0', '0', '0' }, 
                          { '0', '0', '1', '1' }, 
                          { '0', '0', '1', '1' } };
            Assert.AreEqual(4, Ex085.MaximalRectangle(t));
        }

        [TestMethod]
        public void LeetCode_Ex085_Test_MaximalRectangle2()
        {
            char[,] t = { { '0', '0', '0', '0' }, 
                          { '0', '0', '0', '1' }, 
                          { '0', '0', '0', '1' } };
            Assert.AreEqual(2, Ex085.MaximalRectangle(t));
        }

        [TestMethod]
        public void LeetCode_Ex085_Test_MaximalRectangle3()
        {
            char[,] t = { { '0', '0', '0', '0' }, 
                          { '0', '0', '0', '0' }, 
                          { '0', '0', '0', '1' } };
            Assert.AreEqual(1, Ex085.MaximalRectangle(t));
        }

        [TestMethod]
        public void LeetCode_Ex085_Test_MaximalRectangle4()
        {
            char[,] t = { { '0', '0', '0' } };
            Assert.AreEqual(0, Ex085.MaximalRectangle(t));
        }

        [TestMethod]
        public void LeetCode_Ex085_Test_MaximalRectangle5()
        {
            char[,] t = new char[1, 1];
            Assert.AreEqual(0, Ex085.MaximalRectangle(t));
        }
    };
}