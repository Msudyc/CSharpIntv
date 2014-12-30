/*
Given n non-negative integers representing the histogram's
bar height where the width of each bar is 1, find the area 
of largest rectangle in the histogram. 

Above is a histogram where width of each bar is 1, given 
height = [2,1,5,6,2,3]. The largest rectangle is shown in 
the shaded area, which has area = 10 unit.

For example,
 Given height = [2,1,5,6,2,3],
 return 10. 

class Solution {
public:
    int largestRectangleArea(List<int> &height) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex084
    {
        public static int LargestRectangleArea(List<int> height)
        {
            Stack<int> stk = new Stack<int>();
            height.Add(0);
            int i = 0, m = 0;
            while (i < height.Count)
            {
                if (stk.Count == 0 || height[stk.Peek()] <= height[i])
                    stk.Push(i++);
                else
                {
                    int t = stk.Pop();
                    int len = stk.Count == 0 ? i : i - stk.Peek() - 1;
                    int area = height[t] * len;
                    m = Math.Max(m, area);
                }
            }

            return m;
        }
    }
}