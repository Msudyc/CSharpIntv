using System;
using CRCup150CSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CRCup150CSharpTests
{
    [TestClass]
    public class Chapter17_Q13Test
    {
        [TestMethod]
        public void CRCup_CH17_13_Convert1()
        {
            Chapter17_Q13.BiNode node0 = new Chapter17_Q13.BiNode(0);
            Chapter17_Q13.BiNode node1 = new Chapter17_Q13.BiNode(1);
            Chapter17_Q13.BiNode node2 = new Chapter17_Q13.BiNode(2);
            Chapter17_Q13.BiNode node3 = new Chapter17_Q13.BiNode(3);
            Chapter17_Q13.BiNode node4 = new Chapter17_Q13.BiNode(4);
            Chapter17_Q13.BiNode node5 = new Chapter17_Q13.BiNode(5);
            Chapter17_Q13.BiNode node6 = new Chapter17_Q13.BiNode(6);

            node4.Node1 = node2;
            node4.Node2 = node5;

            node2.Node1 = node1;
            node2.Node2 = node3;

            node5.Node2 = node6;

            node1.Node1 = node0;

            Chapter17_Q13.BiNode result = Chapter17_Q13.Convert(node4);
            Assert.AreEqual(0, result.Data);
            result = result.Node2;
            Assert.AreEqual(1, result.Data);
            result = result.Node2;
            Assert.AreEqual(2, result.Data);
            result = result.Node2;
            Assert.AreEqual(3, result.Data);
            result = result.Node2;
            Assert.AreEqual(4, result.Data);
            result = result.Node2;
            Assert.AreEqual(5, result.Data);
            result = result.Node2;
            Assert.AreEqual(6, result.Data);
            result = result.Node2;
            Assert.IsNull(result);
        }
    }
}
