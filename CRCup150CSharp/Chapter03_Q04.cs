/* Question 3.4
 
In the classic problem of the Towers of Hanoi, you have 3 towers and N disks of different sizes 
which can slide onto any tower. The puzzle starts with disks sorted in ascending order of size 
from top to bottom (i.e., each disk sits on top of an even larger one). You have the 
following constraints:
1, Only one disk can be moved at a time
2, A disk is slid off the top of one tower onto the next rod
3, A disk can only be placed on top of a large disk
Write a program to move the disks from the first tower to the last using Stacks.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter03_Q04
    {
        public class Tower
        {
            #region Util
            private Stack<int> disks;

            public Tower()
            {
                this.disks = new Stack<int>();
            }

            public void Add(int d)
            {
                if (this.disks.Count == 0 || 
                    (this.disks.Count > 0 && this.disks.Peek() > d))
                    this.disks.Push(d);
            }

            public void MoveTopTo(Tower t)
            {
                int top = this.disks.Pop();
                t.Add(top);
            }

            public bool IsEmpty()
            {
                return this.disks.Count == 0;
            }

            public int Pop()
            {
                return this.disks.Pop();
            }
            #endregion

            public void MoveDisks(int n, Tower destination, Tower buffer)
            {
                if (n > 0)
                {
                    this.MoveDisks(n - 1, buffer, destination);
                    this.MoveTopTo(destination);
                    buffer.MoveDisks(n - 1, destination, this);
                }
            }
        }
    }
}
