/*
Given a linked list, reverse the nodes of a linked list k at 
a time and return its modified list. If the number of nodes 
is not a multiple of k then left-out nodes in the end should 
remain as it is.You may not alter the values in the nodes, only 
nodes itself may be changed. Only constant memory is allowed.

For example,
 Given this linked list: 1.2.3.4.5 

For k = 2, you should return: 2.1.4.3.5 

For k = 3, you should return: 3.2.1.4.5 

class Solution {
public:
    ListNode *reverseKGroup(ListNode *head, int k) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex024
    {
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || k <= 1) 
                return head;

            ListNode dummy = new ListNode(0);
            dummy.Next = head;
            ListNode pre = dummy;

            int i = 0;
            while (head != null) 
            {
                i++;
                if (i % k == 0) 
                {
                    pre = Reverse(pre, head.Next);                
                    head = pre.Next;
                } 
                else 
                    head = head.Next;
            }

            return dummy.Next;
        }

        private static ListNode Reverse(ListNode pre, ListNode next)
        {
            ListNode last = pre.Next;
            ListNode cur = last.Next;
            while (cur != next)
            {
                last.Next = cur.Next;
                cur.Next = pre.Next;
                pre.Next = cur;
                cur = last.Next;
            }

            return last;
        }
    }
}