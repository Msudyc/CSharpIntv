/* Question 2.1
 
 Write code to remove duplicates from an unsorted linked list.
 Followup: How would you solve this problem if a temporary buffer is not allowed?
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter02_Q01
    {
        public static void DeleteDups<T>(ListNode<T> head)
        {
            Dictionary<T, bool> map = new Dictionary<T, bool>();
            ListNode<T> pre = new ListNode<T>(default(T));
            pre.Next = head;
            while (head != null)
            {
                if (!map.ContainsKey(head.Data))
                {
                    map.Add(head.Data, true);
                    pre = pre.Next;
                }
                else
                    pre.Next = head.Next;
                head = head.Next;
            }
        }

        public static void DeleteDups2<T>(ListNode<T> head)
        {
            ListNode<T> cur = head;
            ListNode<T> pre = head;
            ListNode<T> next = head.Next;
            while (cur != null)
            {
                while (next != null && !next.Data.Equals(cur.Data))
                {
                    next = next.Next;
                    pre = pre.Next;
                }

                if (next != null)
                {
                    pre.Next = next.Next;
                    next = next.Next;
                }
                else
                {
                    cur = cur.Next;
                    pre = cur;
                    next = pre != null? pre.Next : null;
                }
            }
        }
    }
}
