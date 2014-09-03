/*
Given n pairs of parentheses, write a function to generate 
all combinations of well-formed parentheses. 

For example, given n = 3, a solution set is: 

"((()))", "(()())", "(())()", "()(())", "()()()" 

class Solution {
public:
    List<string> generateParenthesis(int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex021
    {
        public static List<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            Generate(n, n, "", result);
            return result;
        }

        private static void Generate(int l, int r, string s, List<string> res)
        {
            if (l == 0 && r == 0) 
                res.Add(s);

            if (l < r)
            {
                if (l > 0) 
                    Generate(l - 1, r, s + "(", res);
                if (r > 0) 
                    Generate(l, r - 1, s + ")", res);
            }
            else if (l == r)
            {
                if (l > 0) 
                    Generate(l - 1, r, s + "(", res);
            }
        }
    }
}