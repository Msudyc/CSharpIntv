using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter01_Q02Test
    {
        [TestMethod]
        public void CRCup_CH01_02_Reverse1()
        {
            char[] str = {'a','b','c','d','e'};
            Chapter01_Q02.Reverse(str);
            Assert.AreEqual('e', str[0]);
            Assert.AreEqual('d', str[1]);
            Assert.AreEqual('c', str[2]);
            Assert.AreEqual('b', str[3]);
            Assert.AreEqual('a', str[4]);
        }

        [TestMethod]
        public void CRCup_CH01_02_Reverse2()
        {
            char[] str = { 'a', 'b', 'c', 'd', 'e', 'f' };
            Chapter01_Q02.Reverse(str);
            Assert.AreEqual('f', str[0]);
            Assert.AreEqual('e', str[1]);
            Assert.AreEqual('d', str[2]);
            Assert.AreEqual('c', str[3]);
            Assert.AreEqual('b', str[4]);
            Assert.AreEqual('a', str[5]);
        }

        [TestMethod]
        public void CRCup_CH01_02_Reverse3()
        {
            char[] str = { 'a', 'b', 'c', 'd', 'e' };
            Chapter01_Q02.Reverse2(str);
            Assert.AreEqual('e', str[0]);
            Assert.AreEqual('d', str[1]);
            Assert.AreEqual('c', str[2]);
            Assert.AreEqual('b', str[3]);
            Assert.AreEqual('a', str[4]);
        }

        [TestMethod]
        public void CRCup_CH01_02_Reverse4()
        {
            char[] str = { 'a', 'b', 'c', 'd', 'e', 'f' };
            Chapter01_Q02.Reverse2(str);
            Assert.AreEqual('f', str[0]);
            Assert.AreEqual('e', str[1]);
            Assert.AreEqual('d', str[2]);
            Assert.AreEqual('c', str[3]);
            Assert.AreEqual('b', str[4]);
            Assert.AreEqual('a', str[5]);
        }
    }
}
