using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex170Test
    {
        [TestMethod]
        public void LeetCode_Ex170_Test_TwoSum1()
        {
            Ex170.TwoSum test = new Ex170.TwoSum();
            test.Add(2);
            test.Add(3);
            test.Add(1);
            test.Add(6);
            Assert.IsTrue(test.Find(5));
            Assert.IsFalse(test.Find(20));
        }
    };
}