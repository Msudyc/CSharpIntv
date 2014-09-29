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
            if (head == null || head.Next == null)
                return head;

            ListNode p = head, q = head.Next;
            while (q != null && q.Next != null)
            {
                p = p.Next;
                q = q.Next.Next;
            }

            ListNode t = p.Next;
            p.Next = null;
            return Merge(
                SortList(head), 
                SortList(t));
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