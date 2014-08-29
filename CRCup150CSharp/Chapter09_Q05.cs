/* Question 9.5
 
Write a method to compute all permutations of a string. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q05
    {
        public static List<string> GetPerms(string str)
        {
            if (str == null)
                return null;
            List<string> perms = new List<string>();
            if (str.Length == 0)
            {
                perms.Add("");
                return perms;
            }

            char first = str[0];
            string remainder = str.Substring(1);
            List<string> words = GetPerms(remainder);
            foreach (string word in words)
            {
                for (int i = 0; i <= word.Length; i++)
                {
                    string s = InsertCharAt(word, first, i);
                    perms.Add(s);
                }
            }

            return perms;
        }

        private static string InsertCharAt(string word, char c, int i)
        {
            string start = word.Substring(0, i);
            string end = word.Substring(i);
            return start + c + end;
        }
    }
}
