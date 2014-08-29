using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter04_Q01Test
    {
        [TestMethod]
        public void CRCup_CH04_01_IsBalanced1()
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

            n3.Left = n7;

            Assert.IsTrue(Chapter04_Q01.IsBalanced<int>(n0));
        }

        [TestMethod]
        public void CRCup_CH04_01_IsBalanced2()
        {
            TreeNode<int> n0 = new TreeNode<int>(0);
            TreeNode<int> n1 = new TreeNode<int>(1);
            TreeNode<int> n2 = new TreeNode<int>(2);
            TreeNode<int> n3 = new TreeNode<int>(3);
            TreeNode<int> n4 = new TreeNode<int>(4);
            TreeNode<int> n5 = new TreeNode<int>(5);
            TreeNode<int> n6 = new TreeNode<int>(6);
            TreeNode<int> n7 = new TreeNode<int>(7);
            TreeNode<int> n8 = new TreeNode<int>(8);

            n0.Left = n1;
            n0.Right = n2;

            n1.Left = n3;
            n1.Right = n4;

            n2.Left = n5;
            n2.Right = n6;

            n3.Left = n7;
            n7.Right = n8;

            Assert.IsFalse(Chapter04_Q01.IsBalanced<int>(n0));
        }
    }
}
