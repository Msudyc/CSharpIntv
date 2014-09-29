/*
Merge k sorted linked lists and return it as one sorted list. 
Analyze and describe its complexity.

class Solution {
public:
    ListNode *mergeKLists(List<ListNode *> &lists) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex022
    {
        public static ListNode MergeKLists(List<ListNode> lists)
        {
            if (lists.Count == 0)
                return null;

            ListNode dummy = new ListNode(0);
            dummy.Next = lists[0];
            ListNode cur, p, q;

            for (int i = 1; i < lists.Count; i++)
            {
                cur = dummy;
                p = cur.Next;
                q = lists[i];

                while (p != null && q != null)
                {
                    if (p.Val < q.Val)
                    {
                        cur.Next = p;
                        p = p.Next;
                    }
                    else
                    {
                        cur.Next = q;
                        q = q.Next;
                    }

                    cur = cur.Next;
                }

                if (p == null)
                    cur.Next = q;
                else if (q == null)
                    cur.Next = p;
            }

            return dummy.Next;
        }
    }
}