/*
Given a string s and a dictionary of words dict, determine 
if s can be segmented into a space-separated sequence of one 
or more dictionary words. 

For example, given
s = "leetcode",
dict = ["leet", "code"]. 

Return true because "leetcode" can be segmented as "leet code". 

class Solution {
public:
    bool wordBreak(string s, unordered_set<string> &dict) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex139
    {
        public static bool WordBreak(string s, HashSet<string> dict)
        {
            bool[] wordB = new bool[s.Length + 1];
            wordB[0] = true;

            for (int i = 1; i < s.Length + 1; i++)
                for (int j = i - 1; j >= 0; j--)
                    if (wordB[j] && dict.Contains(s.Substring(j, i - j))) 
                    {
                        wordB[i] = true;
                        break;
                    }
        
            return wordB[s.Length];
        }
    }
}