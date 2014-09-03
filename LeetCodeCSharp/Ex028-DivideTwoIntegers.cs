/*
Divide two integers without using multiplication, 
division and mod operator. 

class Solution {
public:
    int divide(int dividend, int divisor) {

    }
}
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex028
    {
        public static int Divide(int dividend, int divisor)
        {
            long a = Math.Abs((long)dividend);;
            long b = Math.Abs((long)divisor);

            long ret = 0;
            while (a >= b) 
            {
                long c = b;
                for (int i = 0; a >= c; i++, c <<= 1) 
                {
                    a -= c;
                    ret += (long) 1 << i;
                }
            }

            bool minus = (((dividend^divisor) >> 31) & 0x1) == 1;
            return minus ? (int)(-ret) : (int)(ret);
        }
    }
}