using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex006Test
    {
        [TestMethod]
        public void LeetCode_Ex006_Test_Convert1()
        {
            string s = "PAYPALISHIRING";
            string r = "PAHNAPLSIIGYIR";
            Assert.AreEqual(r, Ex006.Convert(s, 3));
        }

        [TestMethod]
        public void LeetCode_Ex006_Test_Convert2()
        {
            string s = "PAYPALISHIRING";
            string r = "PINALSIGYAHRPI";
            Assert.AreEqual(r, Ex006.Convert(s, 4));
        }

        [TestMethod]
        public void LeetCode_Ex006_Test_Convert3()
        {
            string s = "";
            string r = "";
            Assert.AreEqual(r, Ex006.Convert(s, 4));
        }

        [TestMethod]
        public void LeetCode_Ex006_Test_Convert4()
        {
            string s = "P";
            string r = "P";
            Assert.AreEqual(r, Ex006.Convert(s, 4));
        }
    };
}