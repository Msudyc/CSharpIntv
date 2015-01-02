using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex158Test
    {
        [TestMethod]
        public void LeetCode_Ex158_Test_Read1()
        {
            char[] test = { '0', '1', '2', '3', '4', '5', '6' };
            char[] res = new char[5];
            Ex158 r = new Ex158(test);
            Assert.AreEqual(5, r.Read(res, 5));
            Assert.AreEqual('0', res[0]);
            Assert.AreEqual('1', res[1]);
            Assert.AreEqual('2', res[2]);
            Assert.AreEqual('3', res[3]);
            Assert.AreEqual('4', res[4]);

            Assert.AreEqual(2, r.Read(res, 5));
            Assert.AreEqual('5', res[0]);
            Assert.AreEqual('6', res[1]);
        }

        [TestMethod]
        public void LeetCode_Ex158_Test_Read2()
        {
            char[] test = { '0', '1', '2', '3', '4', '5', '6' };
            char[] res = new char[9];
            Ex158 r = new Ex158(test);
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