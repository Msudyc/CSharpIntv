/*
Given a sorted linked list, delete all duplicates such 
that each element appear only once. 

For example,
 Given 1.1.2, return 1.2.
 Given 1.1.2.3.3, return 1.2.3. 

class Solution {
public:
    ListNode *deleteDuplicates(ListNode *head) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex082
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode p = head;
            if (p == null)
                return p;

            while (p.Next != null)
            {
                if (p.Next.Val == p.Val)
                    p.Next = p.Next.Next;
                else
                    p = p.Next;
            }

            return head;
        }
    }
}