using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex131Test
    {
        [TestMethod]
        public void LeetCode_Ex131_Test_Partition1()
        {
            List<List<string>> res = Ex131.Partition("aab");
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex131_Test_Partition2()
        {
            List<List<string>> res = Ex131.Partition("aa");
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex131_Test_Partition3()
        {
            List<List<string>> res = Ex131.Partition("a");
            Assert.AreEqual(1, res.Count);
        }

        [TestMethod]
        public void LeetCode_Ex131_Test_Partition4()
        {
            List<List<string>> res = Ex131.Partition("");
            Assert.AreEqual(1, res.Count);
        }
    };
}