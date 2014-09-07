/*
Sort a linked list in O(n log n) time using constant space
complexity.

class Solution {
public:
    ListNode *sortList(ListNode *head) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex148
    {
        public static ListNode SortList(ListNode head)
        {
            if (null == head || null == head.Next) 
                return head;
            else
            {
                ListNode fast = head, slow = head;
                while (fast.Next != null && fast.Next.Next != null)
                {
                    fast = fast.Next.Next;
                    slow = slow.Next;
                }

                fast = slow;
                slow = slow.Next;
                fast.Next = null;
                fast = SortList(head);
                slow = SortList(slow);
                return Merge(fast, slow);
            }
        }

        private static ListNode Merge(ListNode head1, ListNode head2)
        {
            if(null == head1) 
                return head2;

            if(null == head2) 
                return head1;

            ListNode dummy = new ListNode(0);
            ListNode p = dummy;

            while(head1 != null && head2 != null)
            {
                if(head1.Val < head2.Val)
                {
                    p.Next = head1;
                    head1 = head1.Next;
                }
                else
                {
                    p.Next = head2;
                    head2 = head2.Next;
                }
            
                p = p.Next;
            }
        
            if(head1 != null) 
                p.Next = head1;
            else if(head2 != null)
                p.Next = head2;

            return dummy.Next;
        }
    }
}