/*
Given a string containing only digits, restore it by 
returning all possible valid IP address combinations.

For example:
 Given "25525511135", 

return ["255.255.11.135", "255.255.111.35"]. 
(Order does not matter) 

class Solution {
public:
    List<string> restoreIpAddresses(string s) {
        
    }
};
*/

namespace LeetCodeCSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Ex093
    {
        public static List<string> RestoreIpAddresses(string s)
        {
            List<string> res = new List<string>();
            GetRes(s, "", res, 4);
            return res;
        }

        private static void GetRes(string s, string r, List<string> res, int k)
        {
            if (k == 0)
            {
                if (string.IsNullOrEmpty(s))
                    res.Add(r);
                return;
            }
            else
                for (int i = 1; i <= 3; i++)
                    if (s.Length >= i && IsValid(s.Substring(0, i)))
                    {
                        if (k == 1) 
                            GetRes(s.Substring(i), r + s.Substring(0, i), res, k - 1);
                        else 
                            GetRes(s.Substring(i), r + s.Substring(0, i) + ".", res, k - 1);
                    }
        }

        private static bool IsValid(string s)
        {
            if (s.Length == 3 && (Convert.ToInt32(s) > 255 || Convert.ToInt32(s) == 0)) 
                return false;
            if (s.Length == 3 && s[0] == '0') 
                return false;
            if (s.Length == 2 && Convert.ToInt32(s) == 0) 
                return false;
            if (s.Length == 2 && s[0] == '0') 
                return false;
            return true;
        }
    }
}