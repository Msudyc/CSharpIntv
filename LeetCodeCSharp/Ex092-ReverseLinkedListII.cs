/*
Reverse a linked list from position m to n. Do it 
in-place and in one-pass. 

For example:
 Given 1.2.3.4.5.null, m = 2 and n = 4, 

return 1.4.3.2.5.null. 

Note:
 Given m, n satisfy the following condition:
 1 ≤ m ≤ n ≤ length of list. 

class Solution {
public:
    ListNode *reverseBetween(ListNode *head, int m, int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex092
    {
        public static ListNode ReverseBetween(ListNode head, int m, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.Next = head;
            ListNode preM = null, pre = dummy;
            for (int i = 1; i <= n; ++i)
            {
                if (i == m) 
                    preM = pre;
                if (i > m && i <= n)
                {
                    pre.Next = head.Next;
                    head.Next = preM.Next;
                    preM.Next = head;
                    head = pre; // head has been moved, so pre becomes current
                }

                pre = head;
                head = head.Next;
            }

            return dummy.Next;
        }

        public static ListNode ReverseBetween2(ListNode head, int m, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.Next = head;
            ListNode pre = dummy;
            int i = 0;
            while (i < m - 1)
            {
                pre = pre.Next;
                i++;
            }

            i = 0;
            ListNode next = head;
            while (i < n)
            {
                i++;
                next = next.Next;
            }

            Reverse(pre, next);
            return dummy.Next;
        }

        private static void Reverse(ListNode pre, ListNode next)
        {
            ListNode fix = pre.Next;
            while (fix.Next != next)
            {
                ListNode t = pre.Next;
                pre.Next = fix.Next;
                fix.Next = pre.Next.Next;
                pre.Next.Next = t;
            }
        }
    }
}