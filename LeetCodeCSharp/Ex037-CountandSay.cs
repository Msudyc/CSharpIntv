/*
The count-and-say sequence is the sequence of integers 
beginning as follows:

1, 11, 21, 1211, 111221, ... 

1 is read off as "one 1" or 11.
11 is read off as "two 1s" or 21.
21 is read off as "one 2, then one 1" or 1211.

Given an integer n, generate the nth sequence. 

Note: The sequence of integers will be represented as 
a string. 

class Solution {
public:
    string countAndSay(int n) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Text;
    using System.Collections.Generic;
    #endregion

    public class Ex037
    {
        public static string CountAndSay(int n)
        {
            string result = "1";
            for (int i = 2; i <= n; i++)
            {
                StringBuilder sb = new StringBuilder();
                char cur = result[0];
                int count = 1;
                for (int j = 1; j < result.Length; j++)
                {
                    if (result[j] == cur)
                        count++;
                    else
                    {
                        sb.Append(count);
                        sb.Append(cur);
                        cur = result[j];
                        count = 1;
                    }
                }

                sb.Append(count);
                sb.Append(cur);
                result = sb.ToString();
            }

            return result;
        }
    }
}