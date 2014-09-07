/*
There are N gas stations along a circular route, where the
amount of gas at station i is gas[i]. 

You have a car with an unlimited gas tank and it costs cost[i]
of gas to travel from station i to its next station (i+1). You
begin the journey with an empty tank at one of the gas stations. 

Return the starting gas station's index if you can travel around
the circuit once, otherwise return -1. 

Note:
 The solution is guaranteed to be unique. 

class Solution {
public:
    int canCompleteCircuit(List<int> &gas, List<int> &cost) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex134
    {
        public static int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int n = gas.Length;
            int i = 0, j = n - 1, sum = 0;
            while (i <= j)
            {
                if (sum < 0)
                {
                    sum += gas[j] - cost[j];
                    j--;
                }
                else
                {
                    sum += gas[i] - cost[i];
                    i++;
                }
            }

            if (sum >= 0) 
                return j + 1 == n ? 0 : j + 1;
            else 
                return -1;
        }
    }
}