/*
Sort a linked list using insertion sort.

class Solution {
public:
    ListNode *insertionSortList(ListNode *head) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex147
    {
        public static ListNode InsertionSortList(ListNode head)
        {
            if (null == head) 
                return head;

            ListNode cur = head.Next, tmp = null;

            while (cur != null)
            {
                tmp = head;
                while (tmp.Val < cur.Val && tmp != cur) 
                    tmp = tmp.Next;

                if (tmp != cur)
                {
                    int first = cur.Val, second;
                    while (tmp != cur)
                    {
                        second = tmp.Val;
                        tmp.Val = first;
                        first = second;
                        tmp = tmp.Next;
                    }

                    tmp.Val = first;
                }

                cur = cur.Next;
            }

            return head;
        }
    }
}