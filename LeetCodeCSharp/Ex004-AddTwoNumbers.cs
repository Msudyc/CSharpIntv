/*
You are given two linked lists representing two non-negative 
numbers. The digits are stored in reverse order and each of 
their nodes contain a single digit. Add the two numbers and 
return it as a linked list.

Input: (2 . 4 . 3) + (5 . 6 . 4)
Output: 7 . 0 . 8

 * Definition for singly-linked list.
 * struct ListNode {
 *     int Val;
 *     ListNode *next;
 *     ListNode(int x) : Val(x), next(null) {}
 * };

class Solution {
public:
    ListNode *addTwoNumbers(ListNode *l1, ListNode *l2) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex004
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null, p = null;
            int carry = 0;
            while (l1 != null && l2 != null)
            {
                int value = (l1.Val + l2.Val + carry) % 10;
                carry = (l1.Val + l2.Val + carry) / 10;
                if (p == null)
                {
                    p = new ListNode(value);
                    result = p;
                }
                else
                {
                    p.Next = new ListNode(value);
                    p = p.Next;
                }

                l1 = l1.Next;
                l2 = l2.Next;
            }

            ListNode q = l1 != null ? l1 : l2;
            while (q != null)
            {
                int value = (q.Val + carry) % 10;
                carry = (q.Val + carry) / 10;
                if (p == null)
                {
                    p = new ListNode(value);
                    result = p;
                }
                else
                {
                    p.Next = new ListNode(value);
                    p = p.Next;
                }

                q = q.Next;
            }

            if (carry > 0)
                p.Next = new ListNode(carry);

            return result;
        }
    }
}