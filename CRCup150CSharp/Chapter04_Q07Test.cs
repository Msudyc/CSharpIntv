using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter04_Q07Test
    {
        [TestMethod]
        public void CRCup_CH04_07_CommonAncestor1()
        {
            TreeNode<int> n0 = new TreeNode<int>(0);
            TreeNode<int> n1 = new TreeNode<int>(1);
            TreeNode<int> n2 = new TreeNode<int>(2);
            TreeNode<int> n3 = new TreeNode<int>(3);
            TreeNode<int> n4 = new TreeNode<int>(4);
            TreeNode<int> n5 = new TreeNode<int>(5);
            TreeNode<int> n6 = new TreeNode<int>(6);

            n0.Left = n1;
            n0.Right = n2;

            n1.Left = n3;
            n1.Right = n4;

            n2.Left = n5;
            n2.Right = n6;

            TreeNode<int> result = Chapter04_Q07.CommonAncestor<int>(n0, n3, n5);
            Assert.AreEqual(0, result.Data);
        }

        [TestMethod]
        public void CRCup_CH04_07_CommonAncestor2()
        {
            TreeNode<int> n0 = new TreeNode<int>(0);
            TreeNode<int> n1 = new TreeNode<int>(1);
            TreeNode<int> n2 = new TreeNode<int>(2);
            TreeNode<int> n3 = new TreeNode<int>(3);
            TreeNode<int> n4 = new TreeNode<int>(4);
            TreeNode<int> n5 = new TreeNode<int>(5);
            TreeNode<int> n6 = new TreeNode<int>(6);

            n0.Left = n1;
            n0.Right = n2;

            n1.Left = n3;
            n1.Right = n4;

            n2.Left = n5;
            n2.Right = n6;

            TreeNode<int> result = Chapter04_Q07.CommonAncestor<int>(n0, n3, n3);
            Assert.AreEqual(3, result.Data);
        }

        [TestMethod]
        public void CRCup_CH04_07_CommonAncestor3()
        {
            TreeNode<int> n0 = new TreeNode<int>(0);
            TreeNode<int> n1 = new TreeNode<int>(1);
            TreeNode<int> n2 = new TreeNode<int>(2);
            TreeNode<int> n3 = new TreeNode<int>(3);
            TreeNode<int> n4 = new TreeNode<int>(4);
            TreeNode<int> n5 = new TreeNode<int>(5);
            TreeNode<int> n6 = new TreeNode<int>(6);
            TreeNode<int> n7 = new TreeNode<int>(7);

            n0.Left = n1;
            n0.Right = n2;

            n1.Left = n3;
            n1.Right = n4;

            n2.Left = n5;
            n2.Right = n6;

            TreeNode<int> result = Chapter04_Q07.CommonAncestor<int>(n0, n3, n7);
            Assert.IsNull(result);
        }
    }
}
