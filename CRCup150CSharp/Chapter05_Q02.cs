/* Question 5.2
 
Given a real umber between0 and 1 (e.g. 0.72) that is passed in as a double, 
print the binary representation. If the number cannot be represented accurately 
in binary with at most 32 characters, print "ERROR" 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Text;
    using System.Collections.Generic;
    #endregion

    public class Chapter05_Q02
    {
        public static string PrintBinary(double num)
        {
            if (num >= 1 || num < 0)
                return "ERROR";

            StringBuilder binary = new StringBuilder();
            binary.Append(".");
            while (num > 0)
            {
                if (binary.Length >= 32)
                    return "ERROR";

                double r = num * 2;
                if (r >= 1)
                {
                    binary.Append(1);
                    num = r - 1;
                }
                else
                {
                    binary.Append(0);
                    num = r;
                }
            }

            return binary.ToString();
        }
    }
}
