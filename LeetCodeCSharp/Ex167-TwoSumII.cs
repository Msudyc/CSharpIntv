/*
Given an array of integers that is already sorted in 
ascending order, find two numbers such that they add 
up to a specific target number.

The function twoSum should return indices of the two 
numbers such that they add up to the target, where index1 
must be less than index2. Please note that your returned 
answers (both index1 and index2) are not zero-based.

You may assume that each input would have exactly one solution.

Input: numbers={2, 7, 11, 15}, target=9
Output: index1=1, index2=2 

class Solution {
public:
    vector<int> twoSum(vector<int> &numbers, int target) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex167
    {
        public static List<int> TwoSum(int[] numbers, int target)
        {
            List<int> result = new List<int>();
            int low=0, high = numbers.Length - 1;
            while (low < high)
            {
                if (numbers[low] + numbers[high] == target)
                {
                    result.Add(low+1);
                    result.Add(high+1);
                    return result;
                }
                else if(numbers[low] + numbers[high] > target)
                    high--;
                else
                    low++;
            }
            
            return result;
        }
    }
}