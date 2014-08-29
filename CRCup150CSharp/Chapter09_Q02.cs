/* Question 9.2
 
Imagine a robot sitting on the upper left corner of an X by Y grid. The robot can only 
move in two directions: right and down. How many possible paths are there for the robot
to go fom (0,0) to (X,Y)?
Follow up:
Imagine certain spots are "off limits," such that the robot cannot step on them. Design 
an algorithm to find a path for the robot from the top left to the bottom right.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter09_Q02
    {
        public static int GetPathsNumDP(int x, int y)
        {
            int[,] map = new int[x+1, y+1];
            for (int i = 0; i <= y; i++)
                map[0, i] = 1;
            for (int i = 0; i <= x; i++)
                map[i, 0] = 1;

            for (int i = 1; i <= x; i++)
                for (int j = 1; j <= y; j++)
                    map[i, j] = map[i - 1, j] + map[i, j - 1];

            return map[x, y];
        }
    }
}
