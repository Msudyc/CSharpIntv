using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter04_Q03Test
    {
        [TestMethod]
        public void CRCup_CH04_02_Search1()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6};
            TreeNode<int> root = Chapter04_Q03.CreateMinimalBST(arr);

            Assert.AreEqual(3, root.Data);
            Assert.AreEqual(1, root.Left.Data);
            Assert.AreEqual(5, root.Right.Data);

            Assert.AreEqual(0, root.Left.Left.Data);
            Assert.AreEqual(2, root.Left.Right.Data);

            Assert.AreEqual(4, root.Right.Left.Data);
            Assert.AreEqual(6, root.Right.Right.Data);
        }
    }
}
