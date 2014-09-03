/*
Given a linked list, remove the nth node from the end of 
list and return its head.

For example,
   Given linked list: 1.2.3.4.5, and n = 2.

   After removing the second node from the end, the linked 
   list becomes 1.2.3.5.

Note:
 Given n will always be valid.
 Try to do this in one pass. 

 Definition for singly-linked list.
 struct ListNode {
      int Val;
      ListNode *next;
      ListNode(int x) : Val(x), next(null) {}
 };
 
class Solution {
public:
    ListNode *removeNthFromEnd(ListNode *head, int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex019
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.Next = head;
            ListNode p = dummy;
            ListNode q = head;
            int k = 0;
            while(k < n) 
            { 
                q = q.Next; 
                k++; 
            }

            while(q != null)
            {
                q = q.Next;
                p = p.Next;            
            }
        
            p.Next = p.Next.Next;
            return dummy.Next;
        }
    }
}