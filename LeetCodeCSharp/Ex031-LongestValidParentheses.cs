/*
Given a string containing just the characters '(' and
')', find the length of the longest valid (well-formed) 
parentheses substring. 

For "(()", the longest valid parentheses substring is "()", 
which has length = 2. 

Another example is ")()())", where the longest valid 
parentheses substring is "()()", which has length = 4. 

class Solution {
public:
    int longestValidParentheses(string s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex031
    {
        public static int LongestValidParentheses(string s)
        {
            int res = 0, last = -1;
            Stack<int> lefts = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(') 
                    lefts.Push(i);
                else if (s[i] == ')')
                {
                    if (lefts.Count == 0) 
                        last = i; // no matching left
                    else
                    {
                        // find a matching pair
                        lefts.Pop();
                        if (lefts.Count == 0) 
                            res = Math.Max(res, i - last);
                        else 
                            res = Math.Max(res, i - lefts.Peek());
                    }
                }
            }

            return res;
        }
    }
}