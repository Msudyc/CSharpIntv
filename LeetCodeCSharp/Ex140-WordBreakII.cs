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
            int len = s.Length;
            List<List<int>> record = new List<List<int>>();

            for (int i = 0; i < len; i++)
                record.Add(new List<int>());

            for (int end = len - 1; end >= 0; end--)
                for (int runner = end; runner >= 0; runner--)
                    if (dict.Contains(s.Substring(runner, end - runner + 1)))
                        record[runner].Add(end);

            List<string> solutionSet = new List<string>();
            WordBreakHelper(record, 0, s, "", solutionSet);

            return solutionSet;
        }

        private static void WordBreakHelper(
            List<List<int>> record, int current, string s, string solution, List<string> solutionSet)
        {
            foreach (int end in record[current])
            {
                string sub = s.Substring(current, end - current + 1);
                string newSoln = solution + (current == 0 ? sub : " " + sub);
                if (end == s.Length - 1)
                    solutionSet.Add(newSoln);
                else
                    WordBreakHelper(record, end + 1, s, newSoln, solutionSet);
            }
        }
    }
}