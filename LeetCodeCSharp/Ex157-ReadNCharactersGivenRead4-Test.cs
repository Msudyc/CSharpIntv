using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex157Test
    {
        [TestMethod]
        public void LeetCode_Ex157_Test_Read1()
        {
            char[] test = { '0', '1', '2', '3', '4', '5', '6' };
            char[] res = new char[5];
            Ex157 r = new Ex157(test);
            Assert.AreEqual(5, r.Read(res, 5));
            Assert.AreEqual('0', res[0]);
            Assert.AreEqual('1', res[1]);
            Assert.AreEqual('2', res[2]);
            Assert.AreEqual('3', res[3]);
            Assert.AreEqual('4', res[4]);
        }

        [TestMethod]
        public void LeetCode_Ex157_Test_Read2()
        {
            char[] test = { '0', '1', '2', '3', '4', '5', '6' };
            char[] res = new char[9];
            Ex157 r = new Ex157(test);
            Assert.AreEqual(7, r.Read(res, 9));
            Assert.AreEqual('0', res[0]);
            Assert.AreEqual('1', res[1]);
            Assert.AreEqual('2', res[2]);
            Assert.AreEqual('3', res[3]);
            Assert.AreEqual('4', res[4]);
            Assert.AreEqual('5', res[5]);
            Assert.AreEqual('6', res[6]);
            Assert.AreEqual(0, res[7]);
        }
    };
}