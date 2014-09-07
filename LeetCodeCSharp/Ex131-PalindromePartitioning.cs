/*
Given a string s, partition s such that every substring
of the partition is a palindrome. Return all possible 
palindrome partitioning of s. 

For example, given s = "aab", Return 

  [
    ["aa","b"],
    ["a","a","b"]
  ]

class Solution {
public:
    List<List<string>> partition(string s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex131
    {
        public static List<List<string>> Partition(string s)
        {
            List<List<string>> res = new List<List<string>>();
            List<string> r = new List<string>();
            Find(s, 0, r, res);
            return res;
        }

        private static void Find(string s, int st, List<string> r, List<List<string>> res)
        {
            if (st >= s.Length) 
                res.Add(r);
            else
                for (int i = st; i < s.Length; i++)
                    if (IsValid(s, st, i))
                    {
                        string temp = s.Substring(st, i - st + 1);
                        r.Add(temp);
                        Find(s, i + 1, r, res);
                        r.Remove(temp);
                    }
        }

        private static bool IsValid(string str, int st, int ed)
        {
            while (st < ed)
            {
                if (str[ed] != str[st]) 
                    return false;
                else 
                { 
                    st++; 
                    ed--; 
                }
            }

            return true;
        }
    }
}