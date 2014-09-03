/*
Given an array of strings, return all groups of strings 
that are anagrams. 

Note: All inputs will be in lower-case.

class Solution {
public:
    List<string> anagrams(List<string> &strs) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex048
    {
        public static List<string> Anagrams(List<string> strs)
        {
            Dictionary<string, List<string>> strmap = new Dictionary<string,List<string>>();
            foreach (string str in strs) 
            {
                char[] strArr = str.ToCharArray();
                Array.Sort(strArr);
                string key = new string(strArr);
                if(!strmap.ContainsKey(key))
                    strmap.Add(key, new List<string>());
                strmap[key].Add(str);
            }

            List<string> res = new List<string>();
            foreach (var e in strmap)
                if (e.Value.Count > 1)
                    res.AddRange(e.Value);

            return res;
        }
    }
}