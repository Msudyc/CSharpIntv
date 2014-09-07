/*
Clone an undirected graph. Each node in the graph contains 
a label and a list of its neighbors. 

OJ's undirected graph serialization: 
Nodes are labeled uniquely. We use # as a separator for each
node, and , as a separator for node label and each neighbor 
of the node.

As an example, consider the serialized graph {0,1,2#1,2#2,2}. 

The graph has a total of three nodes, and therefore contains 
three parts as separated by #. 
1.First node is labeled as 0. Connect node 0 to both nodes 1
  and 2.
2.Second node is labeled as 1. Connect node 1 to node 2.
3.Third node is labeled as 2. Connect node 2 to node 2 (itself),
  thus forming a self-cycle.

Visually, the graph looks like the following: 

       1
      / \
     /   \
    0 --- 2
         / \
         \_/

Definition for undirected graph.
struct UndirectedGraphNode 
{
    int label;
    List<UndirectedGraphNode *> neighbors;
    UndirectedGraphNode(int x) : label(x) {};
};

class Solution {
public:
    UndirectedGraphNode *cloneGraph(UndirectedGraphNode *node) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex133
    {
        public static UndirectedGraphNode CloneGraph(UndirectedGraphNode node)
        {
            if (node == null) 
                return null;

            Queue<UndirectedGraphNode> q = new Queue<UndirectedGraphNode>();
            UndirectedGraphNode ret = new UndirectedGraphNode(node.Label);
            ret.Neighbors = node.Neighbors;
            Dictionary<int, UndirectedGraphNode> umap = new Dictionary<int,UndirectedGraphNode>();
            umap[ret.Label] = ret;

            q.Enqueue(ret);
            while (q.Count != 0)
            {
                List<UndirectedGraphNode> v = new List<UndirectedGraphNode>();
                UndirectedGraphNode n = q.Dequeue();
                foreach (UndirectedGraphNode k in n.Neighbors)
                {
                    if (umap.ContainsKey(k.Label))
                        v.Add(umap[k.Label]);
                    else
                    {
                        UndirectedGraphNode a = new UndirectedGraphNode(k.Label);
                        a.Neighbors = k.Neighbors;
                        v.Add(a);
                        q.Enqueue(a);
                        umap[a.Label] = a;
                    }
                }

                n.Neighbors = v;
            }

            return ret;
        }
    }
}