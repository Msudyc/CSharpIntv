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

            ListNode pre = head, p = head;
            do
            {
                if (p != null && p.Next != null && p.Next.Next != null)
                    p = p.Next.Next;
                else 
                    return null;
                pre = pre.Next;
            }

            while (pre != p);

            pre = head;
            while (pre != p)
            {
                pre = pre.Next;
                p = p.Next;
            }

            return pre;
        }
    }
}