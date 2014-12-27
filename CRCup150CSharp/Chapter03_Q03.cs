/* Question 3.3
 
Imagine a (literal) stack of plates. If the stack gets too high, it might topple. Therefore, in real life,
we would likely start a new stack when the previous stack exceeds some threshold. Implement a data structure 
SetOfStacks that mimics this. SetOfStacks should be composed of several stacks and should create a new stack
once the previous one exceeds capacity. SetOfStacks.push() and SetOfStacks.pop() should return the same values
as it would if there were just a single stack.
Follow up: Implement a function popAt(int index) which performs a pop operation on a specific sub-stack.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter03_Q03
    {
        public class SetOfStacks
        {
            private const int Size = 2;
            private List<Stack<int>> stacks = new List<Stack<int>>();
            private Stack<int> lastStack;

            public void Push(int value)
            {
                if (this.lastStack == null || this.IsStackFull(this.lastStack))
                {
                    Stack<int> stack = new Stack<int>();
                    this.stacks.Add(stack);
                    this.lastStack = stack;
                }

                this.lastStack.Push(value);
            }

            public int Pop()
            {
                if (this.lastStack == null)
                    throw new IndexOutOfRangeException("Stacks is empty");
                int value = this.lastStack.Pop();
                if (this.lastStack.Count == 0)
                {
                    this.stacks.Remove(this.lastStack);
                    if (this.stacks.Count > 0)
                        this.lastStack = this.stacks[this.stacks.Count - 1];
                    else
                        this.lastStack = null;
                }

                return value;
            }

            private bool IsStackFull(Stack<int> stack)
            {
                return stack.Count >= Size;
            }
        }
    }
}
