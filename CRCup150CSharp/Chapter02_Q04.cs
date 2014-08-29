/* Question 2.4
 
Write code to partition a linked list around a value x, such that all nodes 
less than x come before all nodes greater than or equal to x
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter02_Q04
    {
        public static ListNode<int> Partition(ListNode<int> head, int x)
        {
            ListNode<int> before = null, p = null;
            ListNode<int> after = null, q = null;

            while (head != null)
            {
                if (head.Data < x)
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

            if(p != null)
                p.Next = after;
            if(q != null)
                q.Next = null;

            return before != null? before : after;
        }
    }
}
