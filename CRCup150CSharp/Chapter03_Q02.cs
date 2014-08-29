/* Question 3.2
 
How would you design a stack which in addition to push and pop, also has a function min 
which returs the minimum element? Push, pop and min should all operate in O(1) time.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter03_Q02
    {
        public class StackWithMin : Stack<int>
        {
            private Stack<int> minStack = new Stack<int>();

            public new void Push(int value)
            {
                if (this.Min() >= value)
                    this.minStack.Push(value);
                base.Push(value);
            }

            public new int Pop()
            {
                int value = base.Pop();
                if (value == this.Min())
                    this.minStack.Pop();
                return value;
            }

            public int Min()
            {
                if (this.minStack.Count > 0)
                    return this.minStack.Peek();
                else
                    return int.MaxValue;
            }
        }
    }
}
