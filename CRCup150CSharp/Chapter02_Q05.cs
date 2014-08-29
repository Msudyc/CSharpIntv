/* Question 2.5
 
You have two numbers repesented by a linked list, where each node contains a single digit.
The digits are storad in reverse order, such that the 1's digit is at the head of the list.
Write a function that adds the two numbers and returns the sum as a linked list.
Follow up: Suppose the digits are stored in forward order. Repeat the above problem.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter02_Q05
    {
        public static ListNode<int> AddLists(ListNode<int> l1, ListNode<int> l2)
        {
            ListNode<int> result = null, p = null;
            int carry = 0;
            while (l1 != null && l2 != null)
            {
                int value = (l1.Data + l2.Data + carry) % 10;
                carry = (l1.Data + l2.Data + carry) / 10;
                if (p == null)
                {
                    p = new ListNode<int>(value);
                    result = p;
                }
                else
                {
                    p.Next = new ListNode<int>(value);
                    p = p.Next;
                }

                l1 = l1.Next;
                l2 = l2.Next;
            }

            ListNode<int> q = l1 != null ? l1 : l2;
            while (q != null)
            {
                int value = (q.Data + carry) % 10;
                carry = (q.Data + carry) / 10;
                if (p == null)
                {
                    p = new ListNode<int>(value);
                    result = p;
                }
                else
                {
                    p.Next = new ListNode<int>(value);
                    p = p.Next;
                }

                q = q.Next;
            }

            if (carry > 0)
                p.Next = new ListNode<int>(carry);

            return result;
        }
    }
}
