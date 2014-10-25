/*
Given a sorted linked list, delete all nodes that have 
duplicate numbers, leaving only distinct numbers from the 
original list. 

For example,
 Given 1.2.3.3.4.4.5, return 1.2.5.
 Given 1.1.1.2.3, return 2.3. 

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

    public class Ex083
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.Next = head;

            ListNode pre = dummy, cur = head;
            while (cur != null) 
            {
                int temp = cur.Val;
                if (cur.Next != null && cur.Next.Val == temp) 
                {
                    while (cur != null && cur.Val == temp) 
                    {
                        pre.Next = cur.Next;
                        cur = pre.Next;
                    }

                    cur = pre;
                }

                pre = cur;
                cur = cur.Next;
            }

            return dummy.Next;
        }

        public static ListNode DeleteDuplicates2(ListNode head)
        {
            if (head == null || head.Next == null)
                return head;

            ListNode dummy = new ListNode(0);
            dummy.Next = head;

            ListNode p = dummy;
            ListNode q = head;

            while (q != null)
            {
                while (q != null && q.Next != null && q.Val == q.Next.Val)
                    q = q.Next;

                if (p.Next == q)
                    p = p.Next;
                else
                    p.Next = q.Next;

                q = q.Next;
            }

            return dummy.Next;
        }
    }
}