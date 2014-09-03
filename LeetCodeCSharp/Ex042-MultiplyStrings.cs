/*
Given two numbers represented as strings, return 
multiplication of the numbers as a string.

Note: The numbers can be arbitrarily large and are
non-negative.

class Solution {
public:
    string multiply(string num1, string num2) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex042
    {
        public static string Multiply(string num1, string num2)
        {
            if(num1.Length ==0 || num2.Length ==0) 
                return null;
            
            string res = new string('0', num1.Length + num2.Length + 1);
            char[] resArray = res.ToCharArray();
            char[] num1Arr = num1.ToCharArray();
            char[] num2Arr = num2.ToCharArray();
            Array.Reverse(num1Arr);
            Array.Reverse(num2Arr);

            for(int i = 0; i < num1Arr.Length; i++)
            {
                int dig1 = num1Arr[i] - '0';
                int carry = 0;
                for(int j = 0; j < num2Arr.Length; j++) 
                {
                    int dig2 = num2Arr[j] - '0';
                    int exist = resArray[i + j] - '0';
                    int value = dig1*dig2 + carry + exist;
                    resArray[i+j] = (char)(value % 10 + '0'); 
                    carry = value/10;
                }
            
                if(carry > 0)
                    resArray[i + num2Arr.Length] = (char)(carry + '0'); 
            }
        
            Array.Reverse(resArray);
            res = new string(resArray);
            int start = 0;
            while (start < res.Length && res[start] == '0')
                start++;
            if (start == res.Length)
                return "0";
            else
                return res.Substring(start);
        }
    }
}