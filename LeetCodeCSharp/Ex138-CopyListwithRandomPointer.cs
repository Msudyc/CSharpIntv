/*
A linked list is given such that each node contains an 
additional random pointer which could point to any node 
in the list or null. 

Return a deep copy of the list. 

class Solution {
public:
    RandomListNode *copyRandomList(RandomListNode *head) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex138
    {
        public static RandomListNode CopyRandomList(RandomListNode head)
        {
            if(null == head) 
                return null;

            RandomListNode result = null, 
                pold = head, 
                pnew = result, 
                poldNext = null;

            do
            {
                poldNext = pold.Next;
                pnew = new RandomListNode(pold.Label);
                pold.Next = pnew;
                pnew.Next = poldNext;
                if(result == null) 
                    result = pnew;
                pold = poldNext;
            }
            while(pold != null);

            pold = head;
            while(pold != null)
            {
                if(pold.Random != null) 
                    pold.Next.Random = pold.Random.Next;
                pold = pold.Next.Next;
            }
        
            pold = head;
            pnew = result;
            while(pnew.Next != null)
            {
                pold.Next = pnew.Next;
                pold = pold.Next;
                pnew.Next = pold.Next;
                pnew = pnew.Next;
            }
        
            pold.Next = null;
            pnew.Next = null;
            return result;
        }
    }
}