using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex077Test
    {
        [TestMethod]
        public void LeetCode_Ex077_Test_Combine1()
        {
            List<List<int>> ret = Ex077.Combine(4, 2);
            Assert.AreEqual(6, ret.Count);
        }

        [TestMethod]
        public void LeetCode_Ex077_Test_Combine2()
        {
            List<List<int>> ret = Ex077.Combine(2, 2);
            Assert.AreEqual(1, ret.Count);
        }

        [TestMethod]
        public void LeetCode_Ex077_Test_Combine3()
        {
            List<List<int>> ret = Ex077.Combine(5, 2);
            Assert.AreEqual(10, ret.Count);
        }

        [TestMethod]
        public void LeetCode_Ex077_Test_Combine4()
        {
            List<List<int>> ret = Ex077.Combine(7, 2);
            Assert.AreEqual(21, ret.Count);
        }

        [TestMethod]
        public void LeetCode_Ex077_Test_Combine5()
        {
            List<List<int>> ret = Ex077.CombineDFS(4, 2);
            Assert.AreEqual(6, ret.Count);
        }

        [TestMethod]
        public void LeetCode_Ex077_Test_Combine6()
        {
            List<List<int>> ret = Ex077.CombineDFS(2, 2);
            Assert.AreEqual(1, ret.Count);
        }

        [TestMethod]
        public void LeetCode_Ex077_Test_Combine7()
        {
            List<List<int>> ret = Ex077.CombineDFS(5, 2);
            Assert.AreEqual(10, ret.Count);
        }

        [TestMethod]
        public void LeetCode_Ex077_Test_Combine8()
        {
            List<List<int>> ret = Ex077.CombineDFS(7, 2);
            Assert.AreEqual(21, ret.Count);
        }
    };
}