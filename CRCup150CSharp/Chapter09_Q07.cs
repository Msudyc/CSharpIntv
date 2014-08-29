/* Question 9.7
 
Implement the "paint fill" function that one might see on many image editing 
programs. That is, given a screen (represented by a two-dimensional array of 
colors), a point and a new color, fill in the surrounding area until the color
changes from the original color. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q07
    {
        public enum Color
        {
            Black, White, Red, Yellow, Green
        }

        public static void PaintFill(
            Color[,] screen,
            int x,
            int y,
            Color nColor)
        {
            PaintFill(screen, x, y, screen[x, y], nColor);

        }

        private static void PaintFill(
            Color[,] screen,
            int x,
            int y,
            Color oColor,
            Color nColor)
        {
            if (x < 0 || x >= screen.GetLength(0) ||
                y < 0 || y >= screen.GetLength(1))
                return;

            if (screen[x, y] == oColor)
            {
                screen[x, y] = nColor;
                PaintFill(screen, x - 1, y, oColor, nColor);
                PaintFill(screen, x + 1, y, oColor, nColor);
                PaintFill(screen, x, y - 1, oColor, nColor);
                PaintFill(screen, x, y + 1, oColor, nColor);
            }
        }
    }
}
