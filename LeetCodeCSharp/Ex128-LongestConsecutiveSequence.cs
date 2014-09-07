/*
Given an unsorted array of integers, find the length of 
the longest consecutive elements sequence. 

For example,
 Given [100, 4, 200, 1, 3, 2],
 The longest consecutive elements sequence is [1, 2, 3, 4]. 
 Return its length: 4. 

Your algorithm should run in O(n) complexity. 

class Solution {
public:
    int longestConsecutive(List<int> &num) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex128
    {
        public static int LongestConsecutive(int[] num)
        {
            Dictionary<int, bool> mp = new Dictionary<int,bool>();
            for (int i = 0; i < num.Length; i++)
                mp[num[i]] = true;

            int res = 0;
            for (int i = 0; i < num.Length; i++)
            {
                int mx = 1;
                int fd = num[i];
                mp.Remove(num[i]);
                while (mp.ContainsKey(fd + 1))
                {
                    mx++;
                    mp.Remove(fd + 1);
                    fd++;
                }

                fd = num[i];
                while (mp.ContainsKey(fd - 1))
                {
                    mx++;
                    mp.Remove(fd - 1);
                    fd--;
                }

                res = Math.Max(res, mx);
            }

            return res;
        }
    }
}