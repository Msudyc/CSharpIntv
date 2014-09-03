/*
Given a linked list, swap every two adjacent nodes and return 
its head. 

For example,
 Given 1.2.3.4, you should return the list as 2.1.4.3. 

Your algorithm should use only constant space. You may not 
modify the values in the list, only nodes itself can be changed. 

class Solution {
public:
    ListNode *swapPairs(ListNode *head) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex023
    {
        public static ListNode SwapPairs(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.Next = head;
            ListNode p = dummy;
            ListNode q = head;
            while (q != null && q.Next != null)
            {
                p.Next = q.Next;
                q.Next = p.Next.Next;
                p.Next.Next = q;
                // move forward
                p = q;
                q = q.Next;
            }

            return dummy.Next;
        }
    }
}