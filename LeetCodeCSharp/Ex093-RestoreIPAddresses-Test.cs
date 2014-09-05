using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex093Test
    {
        [TestMethod]
        public void LeetCode_Ex093_Test_RestoreIpAddresses1()
        {
            List<string> r = Ex093.RestoreIpAddresses("25525511135");
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex093_Test_RestoreIpAddresses2()
        {
            List<string> r = Ex093.RestoreIpAddresses("26525511135");
            Assert.AreEqual(0, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex093_Test_RestoreIpAddresses3()
        {
            List<string> r = Ex093.RestoreIpAddresses("11125511135");
            Assert.AreEqual(2, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex093_Test_RestoreIpAddresses4()
        {
            List<string> r = Ex093.RestoreIpAddresses("5525511135");
            Assert.AreEqual(2, r.Count);
        }
    };
}