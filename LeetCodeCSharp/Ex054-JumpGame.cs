/*
Given an array of non-negative integers, you are initially 
positioned at the first index of the array. 

Each element in the array represents your maximum jump length 
at that position. 

Determine if you are able to reach the last index. 

For example:
 A = [2,3,1,1,4], return true. 

A = [3,2,1,0,4], return false. 

class Solution {
public:
    bool canJump(int A[], int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex054
    {
        public static bool CanJump(int[] A)
        {
            int reach = 1;
            for (int i = 0; i < reach && reach < A.Length; i++)
                // num = index + 1
                reach = Math.Max(reach, A[i] + i + 1);
            return reach >= A.Length;
        }

        public static bool CanJump2(int[] A)
        {
            int reach = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (reach < i)
                    return false;
                reach = Math.Max(reach, i + A[i]);
            }

            return true;
        }
    }
}