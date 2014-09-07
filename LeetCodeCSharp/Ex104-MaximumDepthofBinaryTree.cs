/*
Given a binary tree, find its maximum depth.

The maximum depth is the number of nodes along the longest
path from the root node down to the farthest leaf node.

class Solution {
public:
    int maxDepth(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex104
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null) 
                return 0;
            return 1 + Math.Max(MaxDepth(root.Left), MaxDepth(root.Right));
        }

        public static int MaxDepthNR(TreeNode root)
        {
            if (root == null) 
                return 0;

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            int nCnt = q.Count, nDepth = 0;
            while (q.Count != 0)
            {
                nCnt--;
                if (nCnt == 0) 
                    nDepth++;
                TreeNode p = q.Dequeue();
                if (p.Left != null) 
                    q.Enqueue(p.Left);
                if (p.Right != null) 
                    q.Enqueue(p.Right);
                if (nCnt == 0) 
                    nCnt = q.Count;
            }

            return nDepth;
        }
    }
}