/*
Given two binary trees, write a function to check if they 
are equal or not. 

Two binary trees are considered equal if they are structurally
identical and the nodes have the same value. 

class Solution {
public:
    bool isSameTree(TreeNode *p, TreeNode *q) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex100
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) 
                return true;

            else if (p == null || q == null) 
                return false;

            else if (p.Val != q.Val) 
                return false;

            else
                return IsSameTree(p.Left, q.Left) && IsSameTree(p.Right, q.Right);
        }
    }
}