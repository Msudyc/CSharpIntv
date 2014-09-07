/*
Evaluate the value of an arithmetic expression in Reverse 
Polish Notation. Valid operators are +, -, *, /. Each operand
may be an integer or another expression. 

Some examples:

  ["2", "1", "+", "3", "*"] . ((2 + 1) * 3) . 9
  ["4", "13", "5", "/", "+"] . (4 + (13 / 5)) . 6

class Solution {
public:
    int evalRPN(List<string> &tokens) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex150
    {
        public static int EvalRPN(List<string> tokens)
        {
            int result = 0, n = tokens.Count;
            Stack<string> s = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                if (tokens[i] != "+" && tokens[i] != "-" && tokens[i] != "*" && tokens[i] != "/")
                    s.Push(tokens[i]);
                else
                {
                    int right = Convert.ToInt32(s.Peek());
                    s.Pop();
                    int left = Convert.ToInt32(s.Peek());
                    s.Pop();
                    if (tokens[i] == "+") 
                        result = left + right;
                    else if (tokens[i] == "-") 
                        result = left - right;
                    else if (tokens[i] == "*") 
                        result = left * right;
                    else if (tokens[i] == "/") 
                        result = left / right;
                    s.Push(result.ToString());
                }
            }

            result = Convert.ToInt32(s.Peek());
            return result;
        }
    }
}