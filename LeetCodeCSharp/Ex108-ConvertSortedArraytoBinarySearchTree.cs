/*
Given an array where elements are sorted in ascending order, 
convert it to a height balanced BST.

class Solution {
public:
    TreeNode *sortedArrayToBST(List<int> &num) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex108
    {
        public static TreeNode SortedArrayToBST(int[] num)
        {
             return SortedArrayToBST(num, 0, num.Length - 1);
        }

        private static TreeNode SortedArrayToBST(int[] num, int start, int end)
        {
            if (start > end)
                return null;

            int mid = start + (end - start)/2;
            TreeNode root = new TreeNode(num[mid]);
            root.Left = SortedArrayToBST(num, start, mid - 1);
            root.Right = SortedArrayToBST(num, mid + 1, end);
            return root;
        }
    }
}