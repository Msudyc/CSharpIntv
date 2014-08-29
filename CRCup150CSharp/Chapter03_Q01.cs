/* Question 3.1
 
Describe how you could use a single array to implement three stacks.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter03_Q01
    {
        public class FixedSizeStacks
        {
            private const int StackSize = 100;
            private int[] buffer = new int[StackSize * 3];
            private int[] stackPointer = { -1, -1, -1 };

            public void Push(int stackNum, int value)
            {
                if (stackPointer[stackNum] + 1 > StackSize)
                    throw new Exception("Out of space");
                stackPointer[stackNum]++;
                buffer[this.absTopOfStack(stackNum)] = value;
            }

            public int Pop(int stackNum)
            {
                if (stackPointer[stackNum] < 0)
                    throw new Exception("Empty stack");
                int value = buffer[this.absTopOfStack(stackNum)];
                buffer[this.absTopOfStack(stackNum)] = 0;
                stackPointer[stackNum]--;
                return value;
            }

            public int Peek(int stackNum)
            {
                return buffer[this.absTopOfStack(stackNum)];
            }

            public bool IsEmpty(int stackNum)
            {
                return stackPointer[stackNum] < 0;
            }

            private int absTopOfStack(int stackNum)
            {
                return stackNum * StackSize + stackPointer[stackNum];
            }
        }
    }
}
