/*
Given a list, rotate the list to the right by k places, 
where k is non-negative.

For example:
 Given 1.2.3.4.5.null and k = 2,
 return 4.5.1.2.3.null.

class Solution {
public:
    ListNode *rotateRight(ListNode *head, int k) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex060
    {
        public static ListNode RotateRight(ListNode head, int k)
        {
            if (head == null || head.Next == null) 
                return head;
            ListNode dummy = new ListNode(0);
            dummy.Next = head;
            ListNode tail = dummy;
            int l = 0;
            while (tail.Next != null) 
            { 
                l++; 
                tail = tail.Next; 
            }
            int move = l - k % l;
            for (int i = 0; i < move; i++)
            {
                ListNode dummy_next = dummy.Next;
                dummy.Next = dummy_next.Next;
                tail.Next = dummy_next;
                tail = tail.Next;
                tail.Next = null;
            }

            head = dummy.Next;
            return head;
        }

        public static ListNode RotateRight2(ListNode head, int k)
        {
            int len = 0;
            ListNode t = head;
            while (t.Next != null)
            {
                len++;
                t = t.Next;
            }
            
            t.Next = head;
            len++;
            int x = 0;
            while (x < len - k)
            {
                x++;
                t = t.Next;
            }

            ListNode newHead = t.Next;
            t.Next = null;
            return newHead;
        }
    }
}