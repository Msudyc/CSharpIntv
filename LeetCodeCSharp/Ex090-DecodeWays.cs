/*
A message containing letters from A-Z is being encoded to
numbers using the following mapping: 

'A' . 1
'B' . 2
...
'Z' . 26

Given an encoded message containing digits, determine 
the total number of ways to decode it. 

For example,
 Given encoded message "12", it could be decoded as "AB" 
 (1 2) or "L" (12). The number of ways decoding "12" is 2. 

class Solution {
public:
    int numDecodings(string s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex090
    {
        public static int NumDecodings(string s)
        {
            int n = s.Length;
            if (n == 0) 
                return 0;

            int[] temp = new int[n + 1]; 
            temp[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                int p1 = 0, p2 = 0;
                // 00 invalid
                if (s[i - 1] != '0')
                    p1 = temp[i - 1];

                if (i >= 2 && (s[i - 2] == '1' || s[i - 2] == '2' && s[i - 1] <= '6'))
                    p2 = temp[i - 2];

                temp[i] = p1 + p2;
            }

            int r = temp[n];
            return r;
        }

        public static int NumDecodings2(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            int[] dp = new int[s.Length + 1];
            dp[s.Length] = 1;
            dp[s.Length - 1] = 1;
            for (int i = s.Length - 2; i >= 0; i--)
            {
                if ((s[i] == '1' && s[i + 1] <= '9' && s[i + 1] > '0')
                    || (s[i] == '2' && s[i + 1] <= '6' && s[i + 1] >= '0'))
                    dp[i] = dp[i + 1] + dp[i + 2];
                else
                    dp[i] = dp[i + 1];
            }

            return dp[0];
        }
    }
}