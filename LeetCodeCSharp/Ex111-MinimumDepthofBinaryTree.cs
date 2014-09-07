/*
Given a binary tree, find its minimum depth.

The minimum depth is the number of nodes along the shortest
path from the root node down to the nearest leaf node.

class Solution {
public:
    int minDepth(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex111
    {
        public static int MinDepth(TreeNode root)
        {
            return MinDepthR(root, false);
        }

        private static int MinDepthR(TreeNode r, bool hasbrother)
        {
            if (null == r) 
                return hasbrother ? int.MaxValue : 0;

            int minl = MinDepthR(r.Left, r.Right != null);
            int minr = MinDepthR(r.Right, r.Left != null);
            return Math.Min(minl, minr) + 1;
        }
    }
}