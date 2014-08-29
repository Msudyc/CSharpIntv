/* Question 5.8
 
A monochrome screen is stored as a single array of bytes, allowing eight consecutive pixels 
to be stored in one byte. The screen has width w, where w is divisible by 8 (that is, no 
byte will be split across rows). The height of he screen, of course, can be derived from 
the length of the array and the width. Implement a function 
drawHorizontalLine(byte[] screen, int width, int x1, int x2, int y)
which draws a horizontal line from (x1, y) to (x2, y).
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter05_Q08
    {
        public static void Drawline(byte[] screen, int w, int x1, int x2, int y)
        {
            int startOffset = x1 % 8;
            int firstFullByte = x1 / 8;
            if (startOffset != 0)
                firstFullByte++;

            int endOffset = x2 % 8;
            int lastFullByte = x2 / 8;
            if (lastFullByte != 7)
                lastFullByte--;

            for (int b = firstFullByte; b <= lastFullByte; b++)
                screen[(w / 8) * y + b] = (byte)0xFF;

            byte startMask = (byte)(0xFF >> startOffset);
            byte endMask = (byte)~(0xFF >> (endOffset + 1));

            if(x1/8 == x2/8)
            {
                byte mask = (byte)(startMask & endMask);
                screen[(w / 8) * y + (x1 / 8)] |= mask;
            }
            else
            {
                if(startOffset != 0)
                {
                    int byteNum = (w / 8) * y + firstFullByte - 1;
                    screen[byteNum] |= startMask;
                }

                if(endOffset != 7)
                {
                    int byteNum = (w / 8) * y + lastFullByte + 1;
                    screen[byteNum] |= endMask;
                }
            }
        }
    }
}
