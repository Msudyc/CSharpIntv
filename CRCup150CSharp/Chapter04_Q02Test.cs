using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter04_Q02Test
    {
        [TestMethod]
        public void CRCup_CH04_02_Search1()
        {
            GraphNode<int> v0 = new GraphNode<int>(0);
            GraphNode<int> v1 = new GraphNode<int>(1);
            GraphNode<int> v2 = new GraphNode<int>(2);
            GraphNode<int> v3 = new GraphNode<int>(3);
            GraphNode<int> v4 = new GraphNode<int>(4);
            GraphNode<int> v5 = new GraphNode<int>(5);
            GraphNode<int> v6 = new GraphNode<int>(6);

            v0.Neighbors.Add(v1);

            v1.Neighbors.Add(v3);

            v2.Neighbors.Add(v1);
            v2.Neighbors.Add(v4);
            v2.Neighbors.Add(v5);
            v2.Neighbors.Add(v6);
            
            v3.Neighbors.Add(v4);
            v3.Neighbors.Add(v5);
            
            v4.Neighbors.Add(v6);

            Assert.IsTrue(Chapter04_Q02.Search<int>(v0, v6));
        }

        [TestMethod]
        public void CRCup_CH04_02_Search2()
        {
            GraphNode<int> v0 = new GraphNode<int>(0);
            GraphNode<int> v1 = new GraphNode<int>(1);
            GraphNode<int> v2 = new GraphNode<int>(2);
            GraphNode<int> v3 = new GraphNode<int>(3);
            GraphNode<int> v4 = new GraphNode<int>(4);
            GraphNode<int> v5 = new GraphNode<int>(5);
            GraphNode<int> v6 = new GraphNode<int>(6);

            v0.Neighbors.Add(v1);

            v1.Neighbors.Add(v3);

            v2.Neighbors.Add(v1);
            v2.Neighbors.Add(v4);
            v2.Neighbors.Add(v5);
            v2.Neighbors.Add(v6);

            v3.Neighbors.Add(v4);
            v3.Neighbors.Add(v5);

            v4.Neighbors.Add(v6);

            Assert.IsFalse(Chapter04_Q02.Search<int>(v0, v2));
        }
    }
}
