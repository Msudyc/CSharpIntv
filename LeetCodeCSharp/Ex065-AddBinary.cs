/*
Given two binary strings, return their sum (also 
a binary string). 

For example,
 a = "11"
 b = "1"
 Return "100".

class Solution {
public:
    string addBinary(string a, string b) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex065
    {
        public static string AddBinary(string a, string b)
        {
            string r = a.Length > b.Length ? a : b;
            char[] res = r.ToCharArray();
            string str = a.Length > b.Length ? b : a;
            bool carry = false;
            int i = str.Length - 1;
            int j = res.Length - 1;
            while (i >= 0)
            {
                if (res[j] == '1' && str[i] == '1') 
                { 
                    res[j] = carry ? '1' : '0'; 
                    carry = true; 
                }
                else if (res[j] == '0' && str[i] == '0') 
                { 
                    res[j] = carry ? '1' : '0'; 
                    carry = false; 
                }
                else if (res[j] == '0' && str[i] == '1') 
                    res[j] = carry ? '0' : '1';  // carry no change from last time
                else if (res[j] == '1' && str[i] == '0')
                    res[j] = carry ? '0' : '1';  // carry no change from last time
                i--; 
                j--;
            }

            while (j >= 0 && carry)
            {
                if (res[j] == '1') 
                { 
                    res[j] = '0'; 
                    j--; 
                    continue; 
                }
                if (res[j] == '0') 
                { 
                    res[j] = '1'; 
                    break; 
                }
            }

            string result = new string(res);
            if (j < 0 && carry) 
                result = "1" + result;
            return result;
        }
    }
}