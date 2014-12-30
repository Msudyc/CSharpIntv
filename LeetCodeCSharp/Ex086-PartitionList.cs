/*
Given a linked list and a value x, partition it such that 
all nodes less than x come before nodes greater than or 
equal to x. 

You should preserve the original relative order of the nodes 
in each of the two partitions. 

For example,
 Given 1.4.3.2.5.2 and x = 3,
 return 1.2.2.4.3.5. 

class Solution {
public:
    ListNode *partition(ListNode *head, int x) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex086
    {
        public static ListNode Partition(ListNode head, int x)
        {
            ListNode before = null, p = null;
            ListNode after = null, q = null;

            while (head != null)
            {
                if (head.Val < x)
                {
                    if (p == null)
                    {
                        p = head;
                        before = p;
                    }
                    else
                    {
                        p.Next = head;
                        p = p.Next;
                    }
                }
                else
                {
                    if (q == null)
                    {
                        q = head;
                        after = q;
                    }
                    else
                    {
                        q.Next = head;
                        q = q.Next;
                    }
                }

                head = head.Next;
            }

            if (p != null)
                p.Next = after;
            if (q != null)
                q.Next = null;

            return before != null ? before : after;
        }
    }
}