/*
Given n, generate all structurally unique BST's 
(binary search trees) that store values 1...n.

For example,
 Given n = 3, your program should return all 5 unique 
 BST's shown below. 

   1         3     3      2      1
    \       /     /      / \      \
     3     2     1      1   3      2
    /     /       \                 \
   2     1         2                 3

Definition for binary tree
struct TreeNode {
     int Val;
     TreeNode *left;
     TreeNode *right;
     TreeNode(int x) : Val(x), left(null), right(null) {}
 };
class Solution {
public:
    List<TreeNode *> generateTrees(int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex096
    {
        public static List<TreeNode> GenerateTrees(int n)
        {
            return GenerateTrees(1, n);
        }

        private static List<TreeNode> GenerateTrees(int start, int end)
        {
            List<TreeNode> ret = new List<TreeNode>();
            if (start > end) 
            { 
                ret.Add(null); 
                return ret; 
            }
            for (int i = start; i <= end; i++)
            {
                List<TreeNode> left = GenerateTrees(start, i - 1);
                List<TreeNode> right = GenerateTrees(i + 1, end);
                TreeNode root;
                for (int j = 0; j < left.Count; j++)
                    for (int k = 0; k < right.Count; k++)
                    {
                        root = new TreeNode(i);
                        root.Left = left[j];
                        root.Right = right[k];
                        ret.Add(root);
                    }
            }

            return ret;
        }
    }
}