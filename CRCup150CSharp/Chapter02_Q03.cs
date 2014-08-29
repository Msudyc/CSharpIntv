/* Question 2.3
 
Implement an algorithm to delete a node in the middle of a singly linked list,
given only access to that node.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter02_Q03
    {
        public static void DeleteNode<T>(ListNode<T> node)
        {
            if (node != null && node.Next != null)
            {
                while (node.Next.Next != null)
                {
                    node.Data = node.Next.Data;
                    node = node.Next;
                }

                node.Data = node.Next.Data;
                node.Next = null;
            }
        }
    }
}
