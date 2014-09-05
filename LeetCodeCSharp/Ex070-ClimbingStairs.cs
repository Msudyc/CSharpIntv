/*
You are climbing a stair case. It takes n steps to reach
to the top.

Each time you can either climb 1 or 2 steps. In how many
distinct ways can you climb to the top?

class Solution {
public:
    int climbStairs(int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex070
    {
        public static int ClimbStairs(int n)
        {
            int p = 1, q = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = q;
                q += p;
                p = temp;
            }

            return q;
        }
    }
}