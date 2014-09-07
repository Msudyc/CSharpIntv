/*
Given a binary tree, find the maximum path sum. 

The path may start and end at any node in the tree. 

For example:
 Given the below binary tree, 

       1
      / \
     2   3

Return 6. 

class Solution {
public:
    int maxPathSum(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex124
    {
        public static int MaxPathSum(TreeNode root)
        {
            int csum = 0;
            int maxsum = int.MinValue;
            MaxPathSumHelper(root, ref csum, ref maxsum);
            return maxsum;
        }

        private static void MaxPathSumHelper(TreeNode node, ref int csum, ref int maxsum)
        {
            if (null == node) 
            { 
                csum = 0; 
                return; 
            }

            int lsum = 0, rsum = 0;
            MaxPathSumHelper(node.Left, ref lsum, ref maxsum);
            MaxPathSumHelper(node.Right, ref rsum, ref maxsum);
            csum = Math.Max(node.Val, Math.Max(node.Val + lsum, node.Val + rsum));
            maxsum = Math.Max(maxsum, Math.Max(csum, node.Val + lsum + rsum));
        }
    }
}