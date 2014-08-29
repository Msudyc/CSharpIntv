/* Question 17.8
 
You are given an array of integers (both positive and negative). Find the contiguous
sequence with the largest sum. Return the sum.
Example:
Input: 2, -8, 3, -2, 4, -10
Output: 5 (i.e., {3, -2, 4})
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q08
    {
        public static int GetMaxSum(int[] arr)
        {
            int maxsum = 0;
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (maxsum < sum)
                    maxsum = sum;
                else if (sum < 0)
                    sum = 0;
            }

            return maxsum;
        }
    }
}
