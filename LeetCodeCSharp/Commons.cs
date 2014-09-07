using System.Collections.Generic;

namespace LeetCodeCSharp
{
    public class ListNode 
    {
        public int Val { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int x)
        {
            this.Val = x;
        }
    }
    
    public class Interval 
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Interval(int s, int e)
        {
            this.Start = s;
            this.End = e;
        }
    };

    public class TreeNode 
    {
        public int Val { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int x)
        {
            this.Val = x;
        }
    };

    public class TreeLinkNode 
    {
        public int Val { get; set; }
        public TreeLinkNode Left { get; set; }
        public TreeLinkNode Right { get; set; }
        public TreeLinkNode Next { get; set; }

        public TreeLinkNode(int x)
        {
            this.Val = x;
        }
    };

    public class UndirectedGraphNode 
    {
        public int Label { get; set; }
        public List<UndirectedGraphNode> Neighbors { get; set; }

        public UndirectedGraphNode(int x)
        {
            this.Label = x;
            this.Neighbors = new List<UndirectedGraphNode>();
        }
    };

    public class RandomListNode 
    {
        public int Label { get; set; }
        public RandomListNode Next { get; set; }
        public RandomListNode Random { get; set; }

        public RandomListNode(int x)
        {
            this.Label = x;
        }
    };

    public class Point 
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int a, int b)
        {
            this.X = a;
            this.Y = b;
        }
    };
}