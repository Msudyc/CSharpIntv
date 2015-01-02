/*
Design a stack that supports push, pop, top, and retrieving 
the minimum element in constant time. 
• push(x) -- Push element x onto stack. 
• pop() -- Removes the element on top of the stack. 
• top() -- Get the top element. 
• getMin() -- Retrieve the minimum element in the stack. 

class MinStack {
public:
    void push(int x) {
        
    }

    void pop() {
        
    }

    int top() {
        
    }

    int getMin() {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex155
    {
        public class MinStack
        {
            private Stack<int> stk = new Stack<int>();
            private Stack<int> mins = new Stack<int>();

            public void Push(int x)
            {
                this.stk.Push(x);
                if (this.mins.Count == 0 || x <= this.mins.Peek())
                    this.mins.Push(x);
            }

            public int Pop()
            {
                int ele = this.stk.Pop();
                if (ele == this.mins.Peek())
                    this.mins.Pop();

                return ele;
            }

            public int Top()
            {
                return this.stk.Peek();
            }

            public int GetMin()
            {
                if (this.mins.Count > 0)
                    return this.mins.Peek();

                return int.MinValue;
            }
        }
    }
}