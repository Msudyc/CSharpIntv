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
            StringBuilder buf = new StringBuilder("1");
            for (int i = 1; i < n; i++)
            {
                StringBuilder tmp = new StringBuilder();
                int j = 0;
                while (j < buf.Length)
                {
                    char c = buf[j];
                    int count, k;
                    for (k = j, count = 0; k < buf.Length && buf[k] == c; k++)
                        count++;

                    tmp.Append(count).Append(c);
                    j = k;
                }

                buf = tmp;
            }

            return buf.ToString();
        }
    }
}