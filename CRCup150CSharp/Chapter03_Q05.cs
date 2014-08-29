/* Question 3.5
 
Implement a MyQueue class which implements a queue using two stacks. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter03_Q05
    {
        public class MyQueue
        {
            private Stack<int> In = new Stack<int>();
            private Stack<int> Out = new Stack<int>();

            public void Add(int value)
            {
                this.In.Push(value);
            }

            public int Remove()
            {
                if (this.Out.Count == 0)
                    this.ShiftStacks();
                if (this.Out.Count == 0)
                    throw new IndexOutOfRangeException("Queue is empty");
                return this.Out.Pop();
            }

            private void ShiftStacks()
            {
                while (this.In.Count > 0)
                    this.Out.Push(this.In.Pop());
            }
        }
    }
}
