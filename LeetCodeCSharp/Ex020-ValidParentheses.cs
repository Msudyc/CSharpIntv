/*
Given a string containing just the characters '(', ')', 
'{', '}', '[' and ']', determine if the input string is 
valid.

The brackets must close in the correct order, "()" and 
"()[]{}" are all valid but "(]" and "([)]" are not.

class Solution {
public:
    bool isValid(string s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex020
    {
        public static bool IsValid(string s)
        {
            Stack<char> stk = new Stack<char>();
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    stk.Push(s[i]);
                else if (s[i] == ')' && ((stk.Count == 0) || stk.Peek() != '('))
                    return false;
                else if (s[i] == ']' && ((stk.Count == 0) || stk.Peek() != '['))
                    return false;
                else if (s[i] == '}' && ((stk.Count == 0) || stk.Peek() != '{'))
                    return false;

                if (s[i] == ')' || s[i] == '}' || s[i] == ']')
                    stk.Pop();
            }

            if (stk.Count == 0) 
                return true;
            else
                return false;
        }
    }
}