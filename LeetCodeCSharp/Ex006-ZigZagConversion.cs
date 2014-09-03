/*
The string "PAYPALISHIRING" is written in a zigzag pattern on 
a given number of rows like this: (you may want to display this
pattern in a fixed font for better legibility) 

P   A   H   N
A P L S I I G
Y   I   R

And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion
given a number of rows: string convert(string text, int nRows);
convert("PAYPALISHIRING", 3) should return "PAHNAPLSIIGYIR". 

class Solution {
public:
    string convert(string s, int nRows) {
        
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

    public class Ex006
    {
        public static string Convert(string s, int nRows)
        {
            if(nRows <= 1) 
                return s;

            StringBuilder r = new StringBuilder();
            int zigSize = 2 * nRows - 2;
            for(int i =0; i < nRows; i++)
            {
                int b = i;            
                while(b < s.Length)
                {
                    r.Append(s[b]);
                    if(i > 0 && i < nRows - 1)
                    {
                        int off = zigSize - 2 * i;
                        if (b + off < s.Length) 
                            r.Append(s[b + off]);
                    }

                    b = b + zigSize;
                }
            }

            return r.ToString();
        }
    }
}