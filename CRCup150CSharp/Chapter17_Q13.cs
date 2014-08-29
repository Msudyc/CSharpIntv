/* Question 17.13
 
Consider a simple node-like data structure called BiNode, which has pointers to two other nodes.
public class BiNode {
  public BiNode node1, node2;
  public int data;
}
The data structure BiNode could be used to represent both a binary tree (where node1 is the left 
node and node2 is the right node) or a doubly linked list (where node1 is the previous node and 
node2 is the next node). Implement a method to convert a binary search tree (implemented with BNode)
into a doubly linked list. The values should be kept in order and the operation should be performed
in place (that is, on the original data structure).
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q13
    {
        public static BiNode Convert(BiNode root)
        {
            return ConvertR(root).Head;
        }

        private static NodePair ConvertR(BiNode root)
        {
            if (root == null)
                return null;
            NodePair part1 = ConvertR(root.Node1);
            NodePair part2 = ConvertR(root.Node2);

            if (part1 != null)
                Concat(part1.Tail, root);
            if (part2 != null)
                Concat(root, part2.Head);

            return new NodePair(
                part1 == null ? root : part1.Head,
                part2 == null ? root : part2.Tail);
        }

        private static void Concat(BiNode x, BiNode y)
        {
            x.Node2 = y;
            y.Node1 = x;
        }

        private class NodePair
        {
            internal NodePair(BiNode head, BiNode tail)
            {
                this.Head = head;
                this.Tail = tail;
            }

            internal BiNode Head { get; set; }
            internal BiNode Tail { get; set; }
        }

        public class BiNode
        {
            public BiNode(int data)
            {
                this.Data = data;
            }

            public BiNode Node1 { get; set; }
            public BiNode Node2 { get; set; }
            public int Data { get; set; }
        }
    }
}
