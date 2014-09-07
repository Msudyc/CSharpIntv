/*
Given numRows, generate the first numRows of Pascal's triangle.

For example, given numRows = 5,
 Return

[
     [1],
    [1,1],
   [1,2,1],
  [1,3,3,1],
 [1,4,6,4,1]
]

class Solution {
public:
    List<List<int> > generate(int numRows) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex118
    {
        public static List<List<int>> Generate(int numRows)
        {
            List<List<int>> result = new List<List<int>>();
            if (numRows < 1) 
                return result;

            for (int i = 0; i < numRows; i++)
            {
                List<int> temp = new List<int>();
                temp.Add(1);
                if (i > 0)
                {
                    for (int j = 0; j < result[i - 1].Count - 1; j++)
                        temp.Add(result[i - 1][j] + result[i - 1][j + 1]);
                    temp.Add(1);
                }

                result.Add(temp);
            }

            return result;
        }
    }
}