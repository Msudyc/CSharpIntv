/*
Merge two sorted linked lists and return it as a new list. 
The new list should be made by splicing together the nodes 
of the first two lists.

class Solution {
public:
    ListNode *mergeTwoLists(ListNode *l1, ListNode *l2) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex064
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode cur = head;
            while (l1 != null && l2 != null) 
            {
                if (l1.Val <= l2.Val) 
                { 
                    cur.Next = l1; 
                    l1 = l1.Next;  
                } 
                else 
                { 
                    cur.Next = l2; 
                    l2 = l2.Next; 
                }  
                cur = cur.Next;
            }
        
            if (l1 != null) 
                cur.Next = l1; 
            else if (l2 != null) 
                cur.Next = l2;

            return head.Next;
        }
    }
}