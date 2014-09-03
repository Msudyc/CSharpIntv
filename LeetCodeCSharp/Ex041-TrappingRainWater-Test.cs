using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex041Test
    {
        [TestMethod]
        public void LeetCode_Ex041_Test_Trap1()
        {
            int[] A = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Assert.AreEqual(6, Ex041.Trap(A));
        }

        [TestMethod]
        public void LeetCode_Ex041_Test_Trap2()
        {
            int[] A = { 0, 1 };
            Assert.AreEqual(0, Ex041.Trap(A));
        }

        [TestMethod]
        public void LeetCode_Ex041_Test_Trap3()
        {
            int[] A = { 1 };
            Assert.AreEqual(0, Ex041.Trap(A));
        }

        [TestMethod]
        public void LeetCode_Ex041_Test_Trap4()
        {
            int[] A = { 0, 1, 1, 2, 1 };
            Assert.AreEqual(0, Ex041.Trap(A));
        }

        [TestMethod]
        public void LeetCode_Ex041_Test_Trap5()
        {
            int[] A = { 0, 1, 0, 0, 1, 0 };
            Assert.AreEqual(2, Ex041.Trap(A));
        }
    };
}