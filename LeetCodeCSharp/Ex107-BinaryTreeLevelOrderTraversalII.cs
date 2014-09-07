/*
Given a binary tree, return the bottom-up level order 
traversal of its nodes' values. (ie, from left to right, 
level by level from leaf to root).

For example:
 Given binary tree {3,9,20,#,#,15,7},

    3
   / \
  9  20
    /  \
   15   7

return its bottom-up level order traversal as:

[
  [15,7]
  [9,20],
  [3],
]

class Solution {
public:
    List<List<int> > levelOrderBottom(TreeNode *root) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex107
    {
        public static List<List<int>> LevelOrderBottom(TreeNode root)
        {
            List<List<int>> result = new List<List<int>>();
            Traverse(root, 1, result);
            result.Reverse();
            return result;
        }

        private static void Traverse(TreeNode root, int level, List<List<int>> result)
        {
            if (root == null) 
                return;
            if (level > result.Count)
            {
                List<int> temp = new List<int>();
                result.Add(temp);
            }

            result[level - 1].Add(root.Val);
            Traverse(root.Left, level + 1, result);
            Traverse(root.Right, level + 1, result);
        }
    }
}