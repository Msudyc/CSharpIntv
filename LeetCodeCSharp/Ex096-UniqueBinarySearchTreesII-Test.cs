using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeCSharp
{
    [TestClass]
    public class Ex096Test
    {
        [TestMethod]
        public void LeetCode_Ex096_Test_GenerateTrees1()
        {
            List<TreeNode> r = Ex096.GenerateTrees(3);
            Assert.AreEqual(5, r.Count);
        }

        [TestMethod]
        public void LeetCode_Ex096_Test_GenerateTrees2()
        {
            List<TreeNode> r = Ex096.GenerateTrees(1);
            Assert.AreEqual(1, r.Count);
            Assert.IsNotNull(r[0]);
        }

        [TestMethod]
        public void LeetCode_Ex096_Test_GenerateTrees3()
        {
            List<TreeNode> r = Ex096.GenerateTrees(0);
            Assert.AreEqual(1, r.Count);
            Assert.IsNull(r[0]);
        }

        [TestMethod]
        public void LeetCode_Ex096_Test_GenerateTrees4()
        {
            List<TreeNode> r = Ex096.GenerateTrees(4);
            Assert.AreEqual(14, r.Count);
        }
    };
}