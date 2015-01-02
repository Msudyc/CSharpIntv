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
    };
}