/*
Given an index k, return the kth row of the Pascal's triangle.

For example, given k = 3,
 Return [1,3,3,1]. 

Note:
 Could you optimize your algorithm to use only O(k) extra space? 

class Solution {
public:
    List<int> getRow(int rowIndex) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex119
    {
        public static List<int> GetRow(int rowIndex)
        {
            List<int> res = new List<int>();
            for (int i = 0; i <= rowIndex; i++)
            {
                for (int j = i - 1; j > 0; j--)
                    res[j] = res[j - 1] + res[j];

                res.Add(1);
            }

            return res;
        }
    }
}