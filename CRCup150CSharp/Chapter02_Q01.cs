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
        public static void DeleteDups(ListNode<int> head)
        {
            if (head == null)
                return;

            HashSet<int> set = new HashSet<int>();
            ListNode<int> p = head;
            set.Add(p.Data);
            while (p.Next != null)
            {
                if (set.Contains(p.Next.Data))
                    p.Next = p.Next.Next;
                else
                {
                    set.Add(p.Next.Data);
                    p = p.Next;
                }
            }
        }

        public static void DeleteDups2(ListNode<int> head)
        {
            if (head == null)
                return;

            ListNode<int> cur = head, p;
            while (cur != null)
            {
                p = cur;
                while (p.Next != null)
                {
                    if (p.Next.Data == cur.Data)
                        p.Next = p.Next.Next;
                    else
                        p = p.Next;
                }

                cur = cur.Next;
            }
        }
    }
}
