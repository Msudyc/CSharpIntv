/*
Given a linked list, determine if it has a cycle in it. 

Follow up:
 Can you solve it without using extra space? 

class Solution {
public:
    bool hasCycle(ListNode *head) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex141
    {
        public static bool HasCycle(ListNode head)
        {
            ListNode slow = head, fast = head;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast) 
                    return true;
            }

            return false;
        }
    }
}