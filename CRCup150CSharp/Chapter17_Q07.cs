/* Question 17.7
 
Given any integer, print an English phrase that describes the integer 
(e.g., "one thousand two hundred thirty four") 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q07
    {
        private static string[] digits = 
            {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        private static string[] teens =
            {"eleven", "twelve", "thirteen", "fourteen", "fifteen", 
             "sixteen", "seventeen", "eighteen", "nineteen"};
        private static string[] tens = 
            { "ten", "twenty", "thirty", "forty", "fifty", 
              "sixty", "seventy", "eighty", "ninety" };
        private static string[] bigs = { "", "thousand", "million" };

        public static string NumToString(int num)
        {
            if (num == 0)
                return "zero";
            else if (num < 0)
                return "negative " + NumToString(-1 * num);

            int count = 0;
            string str = "";
            while (num > 0)
            {
                if (num % 1000 != 0)
                    str = NumToString100(num % 1000) + bigs[count] + " " + str;
                num /= 1000;
                count++;
            }

            return str;
        }

        private static string NumToString100(int num)
        {
            string str = "";
            if (num >= 100)
            {
                str += digits[num / 100 - 1] + " hundred ";
                num %= 100;
            }

            if(num >= 11 && num <= 19)
                return str + teens[num - 11] + " ";
            else if (num == 10 || num >= 20)
            {
                str += tens[num / 10 - 1] + " ";
                num %= 10;
            }

            if (num >= 1 && num <= 9)
                str += digits[num - 1] + " ";

            return str;
        }
    }
}
