/*
Given a positive integer, return its corresponding column
title as appear in an Excel sheet.

For example:
    1 -> A
    2 -> B
    3 -> C
    ...
    26 -> Z
    27 -> AA
    28 -> AB 

class Solution {
public:
    string convertToTitle(int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Text;
    using System.Collections.Generic;
    #endregion

    public class Ex168
    {
        public static string ConvertToTitle(int n)
        {
            StringBuilder sb = new StringBuilder();
            while (n > 0)
            {
                int apd = n % 26;
                char c;
                if (apd == 0)
                {
                    c = 'Z';
                    n = n / 26 - 1;
                }
                else
                {
                    c = (char)(apd + 'A' - 1);
                    n = n / 26;
                }
                
                sb.Append(c);
            }

            return Reverse(sb.ToString());
        }

        private static string Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}