/* Question 4.8
 
You have two very large binary trees: T1, with millions of nodes, and T2, with hundreds of nodes.
Create an algorithm to decide if T2 is a subtree of T1.
A tree T2 is a subtree of T1 if there exists a node n in T1 such that the subtree of n is identical 
to T2. That is, if you cut off the tree at node n, the two trees would be identical.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter04_Q08
    {
        public static bool ContainsTree(TreeNode<int> t1, TreeNode<int> t2)
        {
            if (t2 == null)
                return true;
            return SubTree(t1, t2);
        }

        private static bool SubTree(TreeNode<int> t1, TreeNode<int> t2)
        {
            if (t1 == null)
                return false;

            if (t1.Data == t2.Data && MatchTree(t1, t2))
                return true;

            return SubTree(t1.Left, t2) || SubTree(t1.Right, t2);
        }

        private static bool MatchTree(TreeNode<int> t1, TreeNode<int> t2)
        {
            if (t1 == null && t2 == null)
                return true;

            if (t1 == null || t2 == null)
                return false;

            if (t1.Data != t2.Data)
                return false;

            return MatchTree(t1.Left, t2.Left) && MatchTree(t1.Right, t2.Right);
        }
    }
}
