using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter01_Q04Test
    {
        [TestMethod]
        public void CRCup_CH01_04_ReplaceSpaces1()
        {
            char[] str = new char[100];
            str[0] = 'a';
            str[1] = ' ';
            str[2] = 'a';

            Chapter01_Q04.ReplaceSpaces(str, 3);
            Assert.AreEqual('a', str[0]);
            Assert.AreEqual('%', str[1]);
            Assert.AreEqual('2', str[2]);
            Assert.AreEqual('0', str[3]);
            Assert.AreEqual('a', str[4]);
        }

        [TestMethod]
        public void CRCup_CH01_04_ReplaceSpaces2()
        {
            char[] str = new char[100];
            str[0] = 'a';
            str[1] = 'a';
            str[2] = 'a';

            Chapter01_Q04.ReplaceSpaces(str, 3);
            Assert.AreEqual('a', str[0]);
            Assert.AreEqual('a', str[1]);
            Assert.AreEqual('a', str[2]);
        }

        [TestMethod]
        public void CRCup_CH01_04_ReplaceSpaces3()
        {
            char[] str = new char[100];
            str[0] = 'a';
            str[1] = ' ';
            str[2] = ' ';
            str[3] = 'a';

            Chapter01_Q04.ReplaceSpaces(str, 4);
            Assert.AreEqual('a', str[0]);
            Assert.AreEqual('%', str[1]);
            Assert.AreEqual('2', str[2]);
            Assert.AreEqual('0', str[3]);
            Assert.AreEqual('%', str[4]);
            Assert.AreEqual('2', str[5]);
            Assert.AreEqual('0', str[6]);
            Assert.AreEqual('a', str[7]);
        }
    }
}
