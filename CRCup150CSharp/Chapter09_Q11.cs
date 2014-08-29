/* Question 9.11
 
Given a boolean expression consisting of the symbols 0, 1, &, |, and ^, and 
a desired boolean result value result, implement a funciton to count the number 
of ways o parenthesizing the expression such that it evaluates to result. 
Example:
Expression: 1^0|0|1
Desired result: false (0)
Outputs: 2 ways. 1^((0|0)|1) and 1^(0|(0|1)).
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q11
    {
        public static int NumOfWays(string exp, bool result)
        {
            Dictionary<string, int> q = new Dictionary<string, int>();
            return f(exp, result, 0, exp.Length - 1, q);
        }

        private static int f(
            string exp,
            bool result,
            int s,
            int e,
            Dictionary<string, int> q)
        {
            string key = "" + result + s + e;
            if (q.ContainsKey(key))
                return q[key];

            if (s == e)
            {
                if (exp[s] == '1' && result == true)
                    return 1;
                else if (exp[s] == '0' && result == false)
                    return 1;
                return 0;
            }

            int c = 0;
            if (result == true)
            {
                for (int i = s + 1; i <= e; i += 2)
                {
                    char op = exp[i];
                    if (op == '&')
                        c += f(exp, true, s, i - 1, q) * f(exp, true, i + 1, e, q);
                    else if (op == '|')
                    {
                        c += f(exp, true, s, i - 1, q) * f(exp, false, i + 1, e, q);
                        c += f(exp, false, s, i - 1, q) * f(exp, true, i + 1, e, q);
                        c += f(exp, true, s, i - 1, q) * f(exp, true, i + 1, e, q);
                    }
                    else if (op == '^')
                    {
                        c += f(exp, true, s, i - 1, q) * f(exp, false, i + 1, e, q);
                        c += f(exp, false, s, i - 1, q) * f(exp, true, i + 1, e, q);
                    }
                }
            }
            else
            {
                for (int i = s + 1; i <= e; i += 2)
                {
                    char op = exp[i];
                    if (op == '&')
                    {
                        c += f(exp, true, s, i - 1, q) * f(exp, false, i + 1, e, q);
                        c += f(exp, false, s, i - 1, q) * f(exp, true, i + 1, e, q);
                        c += f(exp, false, s, i - 1, q) * f(exp, false, i + 1, e, q);
                    }
                    else if (op == '|')
                    {
                        c += f(exp, false, s, i - 1, q) * f(exp, false, i + 1, e, q);
                    }
                    else if (op == '^')
                    {
                        c += f(exp, true, s, i - 1, q) * f(exp, true, i + 1, e, q);
                        c += f(exp, false, s, i - 1, q) * f(exp, false, i + 1, e, q);
                    }
                }
            }

            q.Add(key, c);
            return c;
        }
    }
}
