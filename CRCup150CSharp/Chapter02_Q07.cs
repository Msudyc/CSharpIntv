/* Question 2.7
 
Implement a function to check if a linked list is a palindrome.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter02_Q07
    {
        public static bool IsPalindrome(ListNode<int> head)
        {
            ListNode<int> fast = head;
            ListNode<int> slow = head;
            Stack<int> stack = new Stack<int>();

            while (fast != null && fast.Next != null)
            {
                stack.Push(slow.Data);
                fast = fast.Next.Next;
                slow = slow.Next;
            }

            if (fast != null)
                slow = slow.Next;
            while (slow != null)
            {
                int top = stack.Pop();
                if (top != slow.Data)
                    return false;
                slow = slow.Next;
            }

            return true;
        }
    }
}
