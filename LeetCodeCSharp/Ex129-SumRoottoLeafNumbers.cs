/*
Given a binary tree containing digits from 0-9 only, each
root-to-leaf path could represent a number.

An example is the root-to-leaf path 1.2.3 which represents
the number 123.

Find the total sum of all root-to-leaf numbers.

For example, 
    1
   / \
  2   3

The root-to-leaf path 1.2 represents the number 12.
The root-to-leaf path 1.3 represents the number 13. 

Return the sum = 12 + 13 = 25. 

class Solution {
public:
    int sumNumbers(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex129
    {
        public static int SumNumbers(TreeNode root)
        {
            return SumNumbers(root, 0);
        }

        private static int SumNumbers(TreeNode node, int prefix)
        {
            if (node == null) 
                return 0;

            int ourSum = prefix * 10 + node.Val;
            if (node.Left == null && node.Right == null) 
                return ourSum;

            return SumNumbers(node.Left, ourSum) + SumNumbers(node.Right, ourSum);
        }
    }
}