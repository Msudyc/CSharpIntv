/* Question 4.2
 
Given a directed graph, design an algorithm to find out whether there is a route
between two nodes.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter04_Q02
    {
        public static bool Search<T>(GraphNode<T> start, GraphNode<T> end)
        {
            Dictionary<GraphNode<T>, bool> map = new Dictionary<GraphNode<T>, bool>();
            Queue<GraphNode<T>> q = new Queue<GraphNode<T>>();

            q.Enqueue(start);
            while (q.Count > 0)
            {
                GraphNode<T> u = q.Dequeue();
                map.Add(u, true);
                foreach (GraphNode<T> n in u.Neighbors)
                {
                    if (!map.ContainsKey(n))
                    {
                        if (n == end)
                            return true;
                        else
                            q.Enqueue(n);
                    }
                }
            }

            return false;
        }
    }
}
