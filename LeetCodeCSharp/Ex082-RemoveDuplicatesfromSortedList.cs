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
            ListNode p = head, q;
            if (p == null || p.Next == null) 
                return p;

            q = p.Next;
            // invariant: no duplication in range [head, p] && q == p.Next
            while (q != null)
            {
                if (q.Val != p.Val) 
                { 
                    p = p.Next; 
                    q = q.Next; 
                }
                else
                {
                    // find duplicated value, range [head,p] is not changed.
                    ListNode t = q;
                    q = q.Next;
                    p.Next = q;
                }
            }
        
            return head;
        }
    }
}