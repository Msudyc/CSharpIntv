/* Question 4.3
 
Given a sorted (increasing order) array, write an algorithm to create a 
binary search tree with minimal height. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter04_Q03
    {
        public static TreeNode<int> CreateMinimalBST(int[] arr)
        {
            return CreateMinimalBST(arr, 0, arr.Length - 1);
        }

        private static TreeNode<int> CreateMinimalBST(int[] arr, int start, int end)
        {
            if (end < start)
                return null;

            int mid = (start + end) / 2;
            TreeNode<int> n = new TreeNode<int>(arr[mid]);
            n.Left = CreateMinimalBST(arr, start, mid - 1);
            n.Right = CreateMinimalBST(arr, mid + 1, end);
            return n;
        }
    }
}
