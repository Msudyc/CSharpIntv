using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex159Test
    {
        [TestMethod]
        public void LeetCode_Ex159_Test_lengthOfLongestSubstringTwoDistinct1()
        {
            Assert.AreEqual(3, Ex159.lengthOfLongestSubstringTwoDistinct("eceba"));
        }
    };
}