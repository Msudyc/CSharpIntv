/*
Given an array of size n, find the majority element. 
The majority element is the element that appears more
than ⌊ n/2 ⌋ times.

You may assume that the array is non-empty and the 
majority element always exist in the array.

class Solution {
public:
    int majorityElement(vector<int> &num) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex169
    {
        public static int MajorityElement(int[] num) 
        {
            int d = num[0];
            int c = 1;

            for (int i = 1; i < num.Length; ++i)
            {
                if(d == num[i])
                    c++;
                else 
                {
                    c--;
                    if(c==0) 
                    {
                        d = num[i];
                        c = 1;
                    }
                }
            }
            
            return d;
        }
    }
}