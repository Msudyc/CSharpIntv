using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex027Test
    {
        [TestMethod]
        public void LeetCode_Ex027_Test_StrStr1()
        {
            string s = "abcdefghijklmopq";
            string t = "jkl";
            Assert.AreEqual("jklmopq", Ex027.StrStr(s, t));
        }

        [TestMethod]
        public void LeetCode_Ex027_Test_StrStr2()
        {
            string s = "";
            string t = "";
            Assert.AreEqual("", Ex027.StrStr(s, t));
        }

        [TestMethod]
        public void LeetCode_Ex027_Test_StrStr3()
        {
            string s = "abcdefghaabmopq";
            string t = "aab";
            Assert.AreEqual("aabmopq", Ex027.StrStr(s, t));
        }

        [TestMethod]
        public void LeetCode_Ex027_Test_StrStr4()
        {
            string s = "abcdefghaabmopq";
            string t = "bab";
            Assert.IsNull(Ex027.StrStr(s, t));
        }
    };
}