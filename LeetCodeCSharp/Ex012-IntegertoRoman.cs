/*
Given an integer, convert it to a roman numeral. 
Input is guaranteed to be within the range from 
1 to 3999.

class Solution {
public:
    string intToRoman(int num) {
        
    }
};

I-1, V-5, X-10, L-50, C-100, D-500, M-1000
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Text;
    using System.Collections.Generic;
    #endregion

    public class Ex012
    {
        public static string IntToRoman(int num)
        {
            string result = "";
            result += DigitSymbol(num/1000%10, ' ', ' ', 'M');
            result += DigitSymbol(num/100%10, 'M', 'D', 'C');
            result += DigitSymbol(num/10%10, 'C', 'L', 'X'); 
            result += DigitSymbol(num%10, 'X', 'V', 'I');
            return result;
        }
        
        private static string DigitSymbol(int num, char ten, char five, char one)
        {
            StringBuilder r = new StringBuilder();
            if (num == 9)
            {
                r.Append(one);
                r.Append(ten);
            }
            else if (num >= 5)
            {
                r.Append(five);
                r.Append(one, num % 5);
            }
            else if (num == 4)
            {
                r.Append(one);
                r.Append(five);
            }
            else
                r.Append(one, num);
            return r.ToString();
        }
    }
}