using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex171Test
    {
        [TestMethod]
        public void LeetCode_Ex171_Test_TitleToNumber1()
        {
            Assert.AreEqual(28, Ex171.TitleToNumber("AB"));
        }

        [TestMethod]
        public void LeetCode_Ex171_Test_TitleToNumber2()
        {
            Assert.AreEqual(27, Ex171.TitleToNumberFromZero("AB"));
        }

        [TestMethod]
        public void LeetCode_Ex171_Test_TitleToNumber3()
        {
            Assert.AreEqual(702, Ex171.TitleToNumberFromZero("AAA"));
        }

        [TestMethod]
        public void LeetCode_Ex171_Test_TitleToNumber4()
        {
            Assert.AreEqual(1379, Ex171.TitleToNumberFromZero("BAB"));
        }
    };
}