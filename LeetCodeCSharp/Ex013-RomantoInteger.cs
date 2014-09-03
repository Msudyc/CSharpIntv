/*
Given a roman numeral, convert it to an integer.
Input is guaranteed to be within the range from 
1 to 3999.

class Solution {
public:
    int romanToInt(string s) {
        
    }
};

I-1, V-5, X-10, L-50, C-100, D-500, M-1000
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex013
    {
        public static int RomanToInt(string s)
        {
            int r = 0;
            int n = s.Length;
            int k = 0;

            while (k < n)
            {
                switch (s[k])
                {
                    case 'M':
                        r += 1000; 
                        k++; 
                        break;
                    case 'D': 
                        r += 500; 
                        k++; 
                        break;
                    case 'C':
                        if (s[k + 1] == 'M') 
                        { 
                            r += 900; 
                            k = k + 2; 
                        }
                        else if (s[k + 1] == 'D') 
                        { 
                            r += 400; 
                            k = k + 2; }
                        else 
                        { 
                            r += 100; 
                            k++; 
                        }
                        break;
                    case 'L': 
                        r += 50; 
                        k++; 
                        break;
                    case 'X':
                        if (s[k + 1] == 'C') 
                        { 
                            r += 90; 
                            k = k + 2; 
                        }
                        else if (s[k + 1] == 'L') 
                        { 
                            r += 40; 
                            k = k + 2; 
                        }
                        else 
                        { 
                            r += 10; 
                            k++; 
                        }
                        break;
                    case 'V': 
                        r += 5; 
                        k++; 
                        break;
                    case 'I':
                        if (k + 1 < n && s[k + 1] == 'X') 
                        { 
                            r += 9; 
                            k = k + 2; 
                        }
                        else if (k + 1 < n && s[k + 1] == 'V') 
                        { 
                            r += 4; 
                            k = k + 2; 
                        }
                        else 
                        { 
                            r += 1; 
                            k++; 
                        }
                        break;
                    default: break;
                }
            }

            return r;
        }
    }
}