/* Question 2.2
 
Implement an algorithm to find the kth to last element of a singly lined list.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter02_Q02
    {
        public static ListNode<T> NthToLast<T>(ListNode<T> head, int k)
        {
            ListNode<T> p = head;
            ListNode<T> q = head;
            for (int i = 0; q != null && i < k; i++)
                q = q.Next;
            if (q == null) return null;
            while (q.Next != null)
            {
                q = q.Next;
                p = p.Next;
            }

            return p;
        }
    }
}
