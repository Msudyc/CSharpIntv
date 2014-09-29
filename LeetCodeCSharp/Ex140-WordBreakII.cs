/*
Given a string s and a dictionary of words dict, add 
spaces in s to construct a sentence where each word is
a valid dictionary word. 

Return all such possible sentences. 

For example, given
s = "catsanddog",
dict = ["cat", "cats", "and", "sand", "dog"]. 

A solution is ["cats and dog", "cat sand dog"]. 

class Solution {
public:
    List<string> wordBreak(string s, unordered_set<string> &dict) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex140
    {
        public static List<string> WordBreak(string s, HashSet<string> dict)
        {
            List<string> result = new List<string>();
            WordBreakHelper(s, dict, "", result);
            return result;
        }

        private static void WordBreakHelper(
            string s, HashSet<string> dict, string solution, List<string> solutionSet)
        {
            if (dict.Contains(s))
            {
                solution += s;
                solutionSet.Add(solution);
            }
            else
            {
                for (int i = 0; i < s.Length - 1; i++)
                    if (dict.Contains(s.Substring(0, i + 1)))
                    {
                        string t = solution + s.Substring(0, i + 1) + " ";
                        WordBreakHelper(s.Substring(i + 1), dict, t, solutionSet);
                    }
            }
        }
    }
}