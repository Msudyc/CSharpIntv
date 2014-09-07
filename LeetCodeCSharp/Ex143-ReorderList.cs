/*
Given a singly linked list L: L0→L1→…→Ln-1→Ln, reorder it
to: L0→Ln→L1→Ln-1→L2→Ln-2→… 

You must do this in-place without altering the nodes' values.

For example,
 Given {1,2,3,4}, reorder it to {1,4,2,3}.

class Solution {
public:
    void reorderList(ListNode *head) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex143
    {
        public static void ReorderList(ListNode head)
        {
            if (null == head) 
                return;

            ListNode p1 = head, p2 = head.Next;

            while (p2 != null && p2.Next != null) 
            { 
                p1 = p1.Next; 
                p2 = p2.Next.Next; 
            }

            ListNode p3 = p1;
            p2 = p1.Next;
            p1 = null;
            p3.Next = null;

            while (p2 != null)
            {
                p3 = p2.Next;
                p2.Next = p1;
                p1 = p2;
                p2 = p3;
            }

            p2 = head;
            while (p1 != null)
            {
                p3 = p1.Next;
                p1.Next = p2.Next;
                p2.Next = p1;
                p2 = p1.Next;
                p1 = p3;
            }
        }
    }
}