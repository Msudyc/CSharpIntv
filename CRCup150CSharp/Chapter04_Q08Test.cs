using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter04_Q08Test
    {
        [TestMethod]
        public void CRCup_CH04_08_ContainsTree1()
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
            
            TreeNode<int> m2 = new TreeNode<int>(2);
            TreeNode<int> m5 = new TreeNode<int>(5);
            TreeNode<int> m6 = new TreeNode<int>(6);

            m2.Left = m5;
            m2.Right = m6;

            Assert.IsTrue(Chapter04_Q08.ContainsTree(n0, m2));
        }

        [TestMethod]
        public void CRCup_CH04_08_ContainsTree2()
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

            TreeNode<int> m2 = new TreeNode<int>(2);
            TreeNode<int> m5 = new TreeNode<int>(5);
            TreeNode<int> m7 = new TreeNode<int>(7);

            m2.Left = m5;
            m2.Right = m7;

            Assert.IsFalse(Chapter04_Q08.ContainsTree(n0, m2));
        }
    }
}
