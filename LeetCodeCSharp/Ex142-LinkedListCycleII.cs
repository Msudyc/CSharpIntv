/*
Given a linked list, return the node where the cycle 
begins. If there is no cycle, return null. 

Follow up:
 Can you solve it without using extra space? 

class Solution {
public:
    ListNode *detectCycle(ListNode *head) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex142
    {
        public static ListNode DetectCycle(ListNode head)
        {
            if (null == head)
                return null;

            if (head.Next == head)
                return head;

            ListNode p = head, q = head;
            while (q != null && q.Next != null)
            {
                p = p.Next;
                q = q.Next.Next;
                if (p == q)
                    break;
            }

            if (q == null || q.Next == null)
                return null;

            p = head;
            while (p != q)
            {
                p = p.Next;
                q = q.Next;
            }

            return q;
        }
    }
}