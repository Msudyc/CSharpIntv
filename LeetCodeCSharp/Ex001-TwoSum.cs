/*
Given an array of integers, find two numbers such that 
they add up to a specific target number.

The function twoSum should return indices of the two numbers 
such that they add up to the target, where index1 must be 
less than index2.

Please note that your returned answers (both index1 and index2) 
are not zero-based.

You may assume that each input would have exactly one solution.

Input: numbers={2, 7, 11, 15}, target=9
Output: index1=1, index2=2

class Solution {
public:
    List<int> twoSum(List<int> &numbers, int target) {
        // Start typing your C/C++ solution below
        // DO NOT write int main() function
        
    }
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex001
    {
        public static Tuple<int, int> TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> map = new Dictionary<int,int>();
            for(int i = 0; i < numbers.Length; i++)
                map.Add(numbers[i], i + 1);

            for(int i = 0; i < numbers.Length; i++)
                if (map.ContainsKey(target - numbers[i]) && 
                    map[target - numbers[i]] != i + 1)
                    return new Tuple<int,int>(i + 1, map[target - numbers[i]]);

            return null;
        }
    }
}