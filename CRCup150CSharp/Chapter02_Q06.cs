/* Question 2.6
 
Given a circular linked list, implement an algorithm which returns the node
at the beginning of the loop.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter02_Q06
    {
        public static ListNode<int> FindBeginning(ListNode<int> head)
        {
            ListNode<int> p = head, q = head;
            while (q != null && q.Next != null)
            {
                p = p.Next;
                q = q.Next.Next;
                if (p == q)
                    break;
            }

            if (q == null || q.Next == null)
                return null;

            p = head;
            while (p != q)
            {
                p = p.Next;
                q = q.Next;
            }

            return p;
        }
    }
}
