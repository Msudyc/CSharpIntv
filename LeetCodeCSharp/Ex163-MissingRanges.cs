/*
Given a sorted integer array where the range of elements 
are [lower, upper] inclusive, return its missing ranges.

For example, given [0, 1, 3, 50, 75], lower = 0 and 
upper = 99, return ["2", "4->49", "51->74", "76->99"].

class Solution {
public:
    vector<string> findMissingRanges(int A[], int n, int lower, int upper) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex163
    {
        public static List<String> FindMissingRanges(int[] A, int lower, int upper)
        {
            List<String> ranges = new List<String>();
            int prev = lower - 1;
            for (int i = 0; i <= A.Length; ++i)
            {
                int cur = (i == A.Length) ? upper + 1 : A[i];
                if (cur - prev >= 2)
                    ranges.Add(GetRange(prev + 1, cur - 1));
                
                prev = cur;
            }
            
            return ranges;
        }

        private static String GetRange(int from, int to)
        {
            return (from == to) ? from.ToString() : from + "->" + to;
        }
    }
}