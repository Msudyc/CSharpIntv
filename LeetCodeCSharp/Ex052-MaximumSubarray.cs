/*
Find the contiguous subarray within an array (containing 
at least one number) which has the largest sum. 

For example, given the array [−2,1,−3,4,−1,2,1,−5,4], the 
contiguous subarray [4,−1,2,1] has the largest sum = 6. 

click to show more practice.

More practice: 
If you have figured out the O(n) solution, try coding another 
solution using the divide and conquer approach, which is more 
subtle.

class Solution {
public:
    int maxSubArray(int A[], int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex052
    {
        public static int MaxSubArray(int[] A, int n)
        {
            int ret = A[0], sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = Math.Max(sum + A[i], A[i]);
                ret = Math.Max(ret, sum);
            }

            return ret;
        }

        public static int MaxSubArrayDV(int[] A, int n)
        {
            if (n == 0) 
                return 0;
            return MaxSubArrayHelper(A, 0, n - 1);
        }

        private static int MaxSubArrayHelper(int[] A, int left, int right)
        {
            if (right == left) 
                return A[left];
            int middle = (left + right) / 2;
            int leftans = MaxSubArrayHelper(A, left, middle);
            int rightans = MaxSubArrayHelper(A, middle + 1, right);
            int leftmax = A[middle];
            int rightmax = A[middle + 1];
            int temp = 0;
            for (int i = middle; i >= left; i--)
            {
                temp += A[i];
                if (temp > leftmax) 
                    leftmax = temp;
            }

            temp = 0;
            for (int i = middle + 1; i <= right; i++)
            {
                temp += A[i];
                if (temp > rightmax) 
                    rightmax = temp;
            }

            return Math.Max(Math.Max(leftans, rightans), leftmax + rightmax);
        }
    }
}