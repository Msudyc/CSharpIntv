/* Question 1.5
 
 Implement a method to perform basic string compression using the counts of repeated characters.
 For example, the string aabccccccaa would become a2b1c6a2. If the compressed string would not become
 smaller than the original string, your method should return the original string.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Text;
    using System.Collections.Generic;
    #endregion

    public class Chapter01_Q05
    {
        public static string Compress(string str)
        {
            StringBuilder r = new StringBuilder();
            int count = 0;
            char t = str[0];
            int i = 0;
            while (i < str.Length)
            {
                while (i < str.Length && str[i] == t)
                {
                    count++;
                    i++;
                }

                r.Append(t);
                r.Append(count);
                if (i < str.Length)
                {
                    t = str[i];
                    count = 0;
                }
            }

            string re = r.ToString();
            return re.Length < str.Length ? re : str;
        }
    }
}
