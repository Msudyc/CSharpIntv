/*
Given an unsorted array, find the maximum difference between
the successive elements in its sorted form.

Try to solve it in linear time/space.

Return 0 if the array contains less than 2 elements.

You may assume all elements in the array are non-negative
integers and fit in the 32-bit signed integer range.

class Solution {
public:
    int maximumGap(vector<int> &num) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Linq;
    using System.Collections.Generic;
    #endregion

    public class Ex164
    {
        public static int MaximumGap(int[] num) 
        {
            if(num == null || num.Length < 2)
                return 0;
            
            // find max and min
            int min = int.MaxValue;
            int max = int.MinValue;
            foreach(int value in num)
            {
                min = Math.Min(min, value);
                max = Math.Max(max, value);
            }
            
            int gap = (int)Math.Ceiling((double)(max - min)/(num.Length-1));
            int[] minNums = Enumerable.Repeat(int.MaxValue, num.Length -1).ToArray();
            int[] maxNums = Enumerable.Repeat(int.MinValue, num.Length -1).ToArray();
            
            foreach(int value in num)
            {
                if(value !=min && value != max)
                {
                    int i = (value - min) / gap;
                    minNums[i] = Math.Min(minNums[i], value);
                    maxNums[i] = Math.Max(maxNums[i], value);
                }
            }
            
            int maxGap = int.MinValue;
            int preMax = min; // last non-empty bucket max value
            for(int i=0; i<num.Length-1; i++)
            {
                if(minNums[i] != int.MaxValue && maxNums[i] != int.MinValue)
                {
                    maxGap = Math.Max(maxGap, minNums[i] - preMax);
                    preMax = maxNums[i];
                }
            }
            
            maxGap = Math.Max(maxGap, max - preMax);
            return maxGap;
        }
    }
}