/*
You are given a string, S, and a list of words, L, that 
are all of the same length. Find all starting indices of 
substring(s) in S that is a concatenation of each word 
in L exactly once and without any intervening characters. 

For example, given:
S: "barfoothefoobarman"
L: ["foo", "bar"] 

You should return the indices: [0,9].
 (order does not matter).

class Solution {
public:
    List<int> findSubstring(string S, List<string> &L) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex029
    {
        public static List<int> FindSubstring(string S, List<string> L)
        {
            List<int> res = new List<int>();
            if(L.Count == 0) 
                return res;

            int len = L[0].Length;
            Dictionary<string, int> mapL = new Dictionary<string,int>();

            foreach (string it in L)
            {
                if (!mapL.ContainsKey(it))
                    mapL.Add(it, 0);
                mapL[it]++;
            }

            Dictionary<string, int> mapMatch = new Dictionary<string,int>();
        
            for (int offset = 0; offset < len; offset++) 
            {
                mapMatch.Clear();
                int left = offset, count = 0;
                for (int p = offset; p + len <= S.Length; p += len) 
                {
                    string str = S.Substring(p, len);
                    if (mapL.ContainsKey(str) && mapL[str] > 0)
                    {
                        if (!mapMatch.ContainsKey(str))
                            mapMatch.Add(str, 0);
                        mapMatch[str]++;
                        if (mapMatch[str] <= mapL[str]) 
                            count++;
                        if (L.Count == count) 
                            res.Add(left);
                        // reach L.Count, remove the first match
                        if ((p - left)/len + 1 == L.Count) 
                        {
                            str = S.Substring(left, len);
                            mapMatch[str]--;
                            // decrease count if str was counted
                            if (mapMatch[str] < mapL[str]) 
                                count--;
                            left += len;
                        }
                    }
                    else
                    {
                        mapMatch.Clear();
                        left = p + len;
                        count = 0;
                    }
                }
            }
        
            return res;
        }
    }
}