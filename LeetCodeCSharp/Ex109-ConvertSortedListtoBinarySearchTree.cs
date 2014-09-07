/*
Given a singly linked list where elements are sorted in 
ascending order, convert it to a height balanced BST.

class Solution {
public:
    TreeNode *sortedListToBST(ListNode *head) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex109
    {
        private static ListNode H;

        public static TreeNode SortedListToBST(ListNode head)
        {
            if (null == head)
                return null;

            H = head;

            int n = 0;
            ListNode t = head;
            while (t != null) 
            { 
                n++; 
                t = t.Next; 
            }

            return SortedListToBST(0, n - 1);
        }

        private static TreeNode SortedListToBST(int start, int end)
        {
            if (start > end) 
                return null;
            // same as (start+end)/2, avoids overflow
            int mid = start + (end - start) / 2;
            TreeNode leftChild = SortedListToBST(start, mid - 1);
            TreeNode parent = new TreeNode(H.Val);
            parent.Left = leftChild;
            H = H.Next; // critical, also change list pointer
            parent.Right = SortedListToBST(mid + 1, end);
            return parent;
        }
    }
}