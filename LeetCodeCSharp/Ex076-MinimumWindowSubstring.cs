/*
Given a string S and a string T, find the minimum window in S 
which will contain all the characters in T in complexity O(n). 

For example,
S = "ADOBECODEBANC"
T = "ABC"


Minimum window is "BANC". 

Note:
 If there is no such window in S that covers all characters in 
 T, return the emtpy string "". 

If there are multiple such windows, you are guaranteed that 
there will always be only one unique minimum window in S. 

class Solution {
public:
    string minWindow(string S, string T) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex076
    {
        public static string MinWindow(string S, string T)
        {
            int nT = T.Length, nS = S.Length;
            int[] needToFind = new int[256];
            int[] hasFound = new int[256];

            for (int i = 0; i < nT; i++) 
                needToFind[T[i]]++;

            int minBegin = 0, minEnd = 0, minWindow = nS + 1, count = 0;
            char ch;
            for (int begin = 0, end = 0; end < nS; end++)
            {
                if (needToFind[S[end]] == 0) 
                    continue;

                ch = S[end]; 
                hasFound[ch]++;
                if (hasFound[ch] <= needToFind[ch]) 
                    count++;
                if (count == nT)
                {
                    while (needToFind[S[begin]] == 0 || hasFound[S[begin]] > needToFind[S[begin]])
                    {
                        if (hasFound[S[begin]] > needToFind[S[begin]]) 
                            hasFound[S[begin]]--;
                        begin++;
                    }

                    int len = end - begin + 1;
                    if (len < minWindow) 
                    { 
                        minBegin = begin; 
                        minEnd = end; 
                        minWindow = len; 
                    }
                }
            }
            
            return minWindow <= nS ? S.Substring(minBegin, minEnd - minBegin+1) : "";
        }
    }
}