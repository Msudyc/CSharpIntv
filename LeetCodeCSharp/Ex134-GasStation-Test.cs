using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex134Test
    {
        [TestMethod]
        public void LeetCode_Ex134_Test_CanCompleteCircuit1()
        {
            int[] gas = { 1, 2, 1, 5 };
            int[] cost = { 1, 2, 2, 2 };
            Assert.AreEqual(3, Ex134.CanCompleteCircuit(gas, cost));
        }

        [TestMethod]
        public void LeetCode_Ex134_Test_CanCompleteCircuit2()
        {
            int[] gas = { 5, 2, 1, 1 };
            int[] cost = { 1, 2, 2, 2 };
            Assert.AreEqual(0, Ex134.CanCompleteCircuit(gas, cost));
        }

        [TestMethod]
        public void LeetCode_Ex134_Test_CanCompleteCircuit3()
        {
            int[] gas = { 1, 4, 1, 2 };
            int[] cost = { 1, 2, 2, 2 };
            Assert.AreEqual(0, Ex134.CanCompleteCircuit(gas, cost));
        }

        [TestMethod]
        public void LeetCode_Ex134_Test_CanCompleteCircuit4()
        {
            int[] gas = { 1, 2, 1, 2 };
            int[] cost = { 1, 2, 2, 2 };
            Assert.AreEqual(-1, Ex134.CanCompleteCircuit(gas, cost));
        }
    };
}