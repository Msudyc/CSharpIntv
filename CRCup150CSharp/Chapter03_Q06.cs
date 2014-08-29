/* Question 3.6
 
Write a program to sort a stack in ascending order (with biggest items on top). You may use additional stacks 
on hold items, but you may not copy the elements into any other data structue (such as an array). The stack
supports the following operations: push, pop, peek, and isEmpty.
 * 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter03_Q06
    {
        public static Stack<int> Sort(Stack<int> s)
        {
            Stack<int> temp = new Stack<int>();
            while (s.Count > 0)
            {
                int t = s.Pop();
                while (temp.Count > 0 && temp.Peek() > t)
                    s.Push(temp.Pop());

                temp.Push(t);
            }

            return temp;
        }
    }
}
