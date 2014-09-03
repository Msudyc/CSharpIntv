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
            ListNode p, q, temp;
            for (int i = 1; i < lists.Count; i++)
            {
                p = dummy; 
                q = lists[i];
                while(q != null)
                {
                    if(p.Next == null) 
                    { 
                        p.Next = q; 
                        break; 
                    } //critical
                    if(p.Next.Val < q.Val) 
                        p = p.Next;
                    else
                    {
                        temp = p.Next;
                        p.Next = q;
                        q = q.Next;
                        p = p.Next;
                        p.Next = temp;
                    }
                }
            }

            return dummy.Next;
        }
    }
}