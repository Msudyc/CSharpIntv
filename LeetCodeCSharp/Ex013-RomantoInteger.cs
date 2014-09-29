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
            Dictionary<char, Tuple<int, int, char, char, char>> map =
                new Dictionary<char, Tuple<int, int, char, char, char>>();

            map.Add('I', new Tuple<int, int, char, char, char>(1, 1, 'I', 'V', 'X'));
            map.Add('V', new Tuple<int, int, char, char, char>(5, 1, 'I', 'V', 'X'));
            map.Add('X', new Tuple<int, int, char, char, char>(10, 10, 'X', 'L', 'C'));
            map.Add('L', new Tuple<int, int, char, char, char>(50, 10, 'X', 'L', 'C'));
            map.Add('C', new Tuple<int, int, char, char, char>(100, 100, 'C', 'D', 'M'));
            map.Add('D', new Tuple<int, int, char, char, char>(500, 100, 'C', 'D', 'M'));
            map.Add('M', new Tuple<int, int, char, char, char>(1000, 1000, 'M', ' ', ' '));

            int result = 0;
            int i = 0;
            while (i < s.Length)
            {
                Tuple<int, int, char, char, char> temp = map[s[i]];
                if (temp.Item1 / temp.Item2 == 1)
                {
                    if (i + 1 < s.Length && s[i + 1] == temp.Item4)
                    {
                        result += temp.Item1 * 4;
                        i += 2;
                    }
                    else if (i + 1 < s.Length && s[i + 1] == temp.Item5)
                    {
                        result += temp.Item1 * 9;
                        i += 2;
                    }
                    else
                    {
                        result += temp.Item1;
                        i++;
                    }
                }
                else
                {
                    result += temp.Item1;
                    i++;
                }
            }

            return result;
        }
    }
}