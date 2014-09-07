/*
Given a binary tree and a sum, find all root-to-leaf paths 
where each path's sum equals the given sum. 

For example:
 Given the below binary tree and sum = 22,

              5
             / \
            4   8
           /   / \
          11  13  4
         /  \    / \
        7    2  5   1


return

[
   [5,4,11,2],
   [5,8,4,5]
]

class Solution {
public:
    List<List<int> > pathSum(TreeNode *root, int sum) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex113
    {
        public static List<List<int>> PathSum(TreeNode root, int sum)
        {
            List<List<int>> paths = new List<List<int>>();
            List<int> curPath = new List<int>();
            PathSumR(root, sum, paths, curPath);
            return paths;
        }

        private static void PathSumR(TreeNode root, int sum, List<List<int>> paths, List<int> curPath)
        {
            if (root == null) 
                return;

            curPath.Add(root.Val);
            sum -= root.Val;
            if (root.Left == null && root.Right == null && sum == 0)
                paths.Add(new List<int>(curPath));

            PathSumR(root.Left, sum, paths, curPath);
            PathSumR(root.Right, sum, paths, curPath);
            curPath.Remove(curPath.Count - 1);
        }
    }
}