using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex070Test
    {
        [TestMethod]
        public void LeetCode_Ex070_Test_ClimbStairs1()
        {
            Assert.AreEqual(55, Ex070.ClimbStairs(9));
        }

        [TestMethod]
        public void LeetCode_Ex070_Test_ClimbStairs2()
        {
            Assert.AreEqual(1, Ex070.ClimbStairs(1));
        }

        [TestMethod]
        public void LeetCode_Ex070_Test_ClimbStairs3()
        {
            Assert.AreEqual(2, Ex070.ClimbStairs(2));
        }

        [TestMethod]
        public void LeetCode_Ex070_Test_ClimbStairs4()
        {
            Assert.AreEqual(5, Ex070.ClimbStairs(4));
        }

        [TestMethod]
        public void LeetCode_Ex070_Test_ClimbStairs5()
        {
            Assert.AreEqual(34, Ex070.ClimbStairs(8));
        }
    };
}