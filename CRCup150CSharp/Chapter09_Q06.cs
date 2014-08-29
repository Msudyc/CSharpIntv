/* Question 9.6
 
Implement an algorithm to print all valid combinations of n-pairs of parentheses. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Text;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q06
    {
        public static List<string> GenerateParens(int num)
        {
            char[] str = new char[num * 2];
            List<string> result = new List<string>();
            AddParen(result, num, num, str, 0);
            return result;
        }

        private static void AddParen(
            List<string> list,
            int leftRem,
            int rightRem,
            char[] s,
            int count)
        {
            if (leftRem < 0 || rightRem < leftRem)
                return;

            if (leftRem == 0 && rightRem == 0)
                list.Add(new string(s));
            else
            {
                if (leftRem > 0)
                {
                    s[count] = '(';
                    AddParen(list, leftRem - 1, rightRem, s, count + 1);
                }

                if (rightRem > leftRem)
                {
                    s[count] = ')';
                    AddParen(list, leftRem, rightRem - 1, s, count + 1);
                }
            }
        }
    }
}
