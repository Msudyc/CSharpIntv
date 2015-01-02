/*
Given two integers representing the numerator and denominator
of a fraction, return the fraction in string format.

If the fractional part is repeating, enclose the repeating 
part in parentheses.

For example, 
Given numerator = 1, denominator = 2, return "0.5".
Given numerator = 2, denominator = 1, return "2".
Given numerator = 2, denominator = 3, return "0.(6)".

class Solution {
public:
    string fractionToDecimal(int numerator, int denominator) {
        
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

    public class Ex166
    {
        public static string FractionToDecimal(int numerator, int denominator) 
        {
            long longNumerator = Math.Abs((long)numerator);
            long longDenominator = Math.Abs((long)denominator);
            
            StringBuilder sb = new StringBuilder();
            if ((long) numerator * denominator < 0)
                sb.Append("-");
            sb.Append(longNumerator / longDenominator);
            
            long remainder = longNumerator % longDenominator;
            if (remainder == 0) 
                return sb.ToString();
            
            sb.Append(".");
            
            StringBuilder fracSb = new StringBuilder();
            Dictionary<long, int> map = new Dictionary<long, int>();
            int index = 0;
            while (remainder != 0) 
            {
                remainder *= 10;
                long nextRemainder = remainder % longDenominator;
                // If repeated part occurs.
                if (map.ContainsKey(remainder)) 
                {
                    fracSb.Insert(map[remainder], "(");
                    fracSb.Append(")");
                    break;
                }
                
                map.Add(remainder, index++);
                fracSb.Append(remainder / longDenominator);
                remainder = nextRemainder;
            }
            
            sb.Append(fracSb);
            return sb.ToString();
        }
    }
}