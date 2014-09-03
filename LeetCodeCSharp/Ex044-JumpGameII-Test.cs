using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex044Test
    {
        [TestMethod]
        public void LeetCode_Ex044_Test_Jump1()
        {
            int[] A = {2,3,1,1,4};
            Assert.AreEqual(2, Ex044.Jump(A));
        }

        [TestMethod]
        public void LeetCode_Ex044_Test_Jump2()
        {
            int[] A = {1,1,1,1,1};
            Assert.AreEqual(4, Ex044.Jump(A));
        }

        [TestMethod]
        public void LeetCode_Ex044_Test_Jump3()
        {
            int[] A = {6,3,1,1,4};
            Assert.AreEqual(1, Ex044.Jump(A));
        }

        [TestMethod]
        public void LeetCode_Ex044_Test_Jump4()
        {
            int[] A = {2,1,1,1,4};
            Assert.AreEqual(3, Ex044.Jump(A));
        }
    };
}