using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex095Test
    {
        [TestMethod]
        public void LeetCode_Ex095_Test_NumTrees1()
        {
            Assert.AreEqual(5, Ex095.NumTrees(3));
        }

        [TestMethod]
        public void LeetCode_Ex095_Test_NumTrees2()
        {
            Assert.AreEqual(1, Ex095.NumTrees(1));
        }

        [TestMethod]
        public void LeetCode_Ex095_Test_NumTrees3()
        {
            Assert.AreEqual(2, Ex095.NumTrees(2));
        }

        [TestMethod]
        public void LeetCode_Ex095_Test_NumTrees4()
        {
            Assert.AreEqual(132, Ex095.NumTrees(6));
        }
    };
}