using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex054Test
    {
        [TestMethod]
        public void LeetCode_Ex054_Test_CanJump1()
        {
            int[] A = {2,3,1,1,4};
            Assert.IsTrue(Ex054.CanJump(A));

            int[] B = {3,2,1,0,4};
            Assert.IsFalse(Ex054.CanJump(B));
        }

        [TestMethod]
        public void LeetCode_Ex054_Test_CanJump2()
        {
            int[] A = {2};
            Assert.IsTrue(Ex054.CanJump(A));

            int[] B = {0,2,1,0,4};
            Assert.IsFalse(Ex054.CanJump(B));
        }
    };
}