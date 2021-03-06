using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex057Test
    {
        [TestMethod]
        public void LeetCode_Ex057_Test_LengthOfLastWord1()
        {
            Assert.AreEqual(5, Ex057.LengthOfLastWord("abc aaaaa"));
        }

        [TestMethod]
        public void LeetCode_Ex057_Test_LengthOfLastWord2()
        {
            Assert.AreEqual(3, Ex057.LengthOfLastWord(" abc"));
        }

        [TestMethod]
        public void LeetCode_Ex057_Test_LengthOfLastWord3()
        {
            Assert.AreEqual(1, Ex057.LengthOfLastWord(" abc ss vv a "));
        }

        [TestMethod]
        public void LeetCode_Ex057_Test_LengthOfLastWord4()
        {
            Assert.AreEqual(5, Ex057.LengthOfLastWord2("abc aaaaa"));
        }

        [TestMethod]
        public void LeetCode_Ex057_Test_LengthOfLastWord5()
        {
            Assert.AreEqual(3, Ex057.LengthOfLastWord2(" abc"));
        }

        [TestMethod]
        public void LeetCode_Ex057_Test_LengthOfLastWord6()
        {
            Assert.AreEqual(1, Ex057.LengthOfLastWord2(" abc ss vv a "));
        }
    };
}