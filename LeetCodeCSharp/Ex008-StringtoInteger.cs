/*
Implement atoi to convert a string to an integer.

Hint: Carefully consider all possible input cases. If you want 
a challenge, please do not see below and ask yourself what are 
the possible input cases.

Notes: It is intended for this problem to be specified vaguely 
(ie, no given input specs). You are responsible to gather all 
the input requirements up front. 

class Solution {
public:
    int atoi(const char *str) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex008
    {
        public static int Atoi(string str)
        {
            bool minus = false;
            if (string.IsNullOrEmpty(str))
                return 0;

            int i = 0;
            while (i < str.Length && str[i] == ' ')
                i++;

            if (i < str.Length && str[i] == '+')
                i++;

            if (i < str.Length && str[i] == '-')
            {
                minus = true;
                i++;
            }

            int r = 0;
            while (i < str.Length && str[i] >= '0' && str[i] <= '9')
            {
                if (r > int.MaxValue / 10)
                {
                    return minus ? int.MinValue : int.MaxValue;
                }
                else if (r == int.MaxValue / 10)
                {
                    if (minus && str[i] > '8') return int.MinValue;
                    if (!minus && str[i] > '7') return int.MaxValue;
                }

                r = r * 10 + str[i] - '0';
                i++;
            }

            if (minus) r = -r;
            return r;
        }
    }
}