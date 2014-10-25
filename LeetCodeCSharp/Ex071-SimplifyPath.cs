/*
Given an absolute path for a file (Unix-style), simplify it.

For example,
path = "/home/", => "/home"
path = "/a/./b/../../c/", => "/c"

Corner Cases: 

.Did you consider the case where path = "/../"? In this 
 case, you should return "/".
.Another corner case is the path might contain multiple 
 slashes '/' together, such as "/home//foo/".
 In this case, you should ignore redundant slashes and 
 return "/home/foo".

class Solution {
public:
    string simplifyPath(string path) {
        
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

    public class Ex071
    {
        public static string SimplifyPath(string path)
        {
            if (path[path.Length - 1] != '/') 
                path = path + '/';
            List<string> pv = new List<string>();
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == '/')
                {
                    if (temp.ToString() == "..") 
                    { 
                        if (pv.Count != 0) 
                            pv.RemoveAt(pv.Count - 1); 
                    }
                    else if (temp.ToString() != "." && temp.Length != 0) 
                        pv.Add(temp.ToString());
                    temp.Clear();
                }
                else temp.Append(path[i]);
            }

            StringBuilder ret = new StringBuilder();
            for (int i = 0; i < pv.Count; i++)
            {
                ret.Append('/');
                ret.Append(pv[i]);
            }

            if (ret.Length == 0) 
                return "/";
            return ret.ToString();
        }

        public static string SimplifyPath2(string path)
        {
            string[] temp = path.Split('/');
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == ".")
                    temp[i] = string.Empty;
                else if (temp[i] == "..")
                {
                    temp[i] = string.Empty;
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (string.IsNullOrEmpty(temp[k]))
                            continue;
                        temp[k] = string.Empty;
                        break;
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < temp.Length; i++)
            {
                if (!string.IsNullOrEmpty(temp[i]))
                {
                    sb.Append("/");
                    sb.Append(temp[i]);
                }
            }

            return sb.ToString();
        }
    }
}