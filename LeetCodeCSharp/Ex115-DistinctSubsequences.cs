/*
Given a string S and a string T, count the number of 
distinct subsequences of T in S. 

A subsequence of a string is a new string which is formed
from the original string by deleting some (can be none) of
the characters without disturbing the relative positions 
of the remaining characters. (ie, "ACE" is a subsequence of
"ABCDE" while "AEC" is not). 

Here is an example:
S = "rabbbit", T = "rabbit" 

Return 3. 

class Solution {
public:
    int numDistinct(string S, string T) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex115
    {
        public static int NumDistinct(string S, string T)
        {
            int[] t = new int[T.Length + 1];
            t[T.Length] = 1;

            for (int i = S.Length - 1; i >= 0; i--)
                for (int j = 0; j < T.Length; j++)
                    t[j] += S[i] == T[j] ? t[j + 1] : 0;

            return t[0];
        }
    }
}