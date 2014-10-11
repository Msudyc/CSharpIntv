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
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;

            ListNode<int> head = null, p = null;
            int carry = 0;
            while (l1 != null && l2 != null)
            {
                int v = (l1.Data + l2.Data + carry) % 10;
                carry = (l1.Data + l2.Data + carry) / 10;
                if (head == null)
                {
                    p = new ListNode<int>(v);
                    head = p;
                }
                else
                {
                    p.Next = new ListNode<int>(v);
                    p = p.Next;
                }

                l1 = l1.Next;
                l2 = l2.Next;
            }

            ListNode<int> left = l1 != null ? l1 : l2;
            while (left != null)
            {
                int v = (left.Data + carry) % 10;
                carry = (left.Data + carry) / 10;
                p.Next = new ListNode<int>(v);
                p = p.Next;
                left = left.Next;
            }

            if (carry == 1)
                p.Next = new ListNode<int>(1);

            return head;
        }
    }
}
