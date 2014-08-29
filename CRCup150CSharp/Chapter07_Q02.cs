/* Question 7.2
 
There are three ants on different vertices of a triangle. What is the probability 
of collision (between any two or all of them) if they start walking on the sides 
of the triangle? Assume that each ant randomly picks a direction, with either direction
being equally likely to be chosen, and that they walk at the same speed. Similarly, 
find the probability of collision with n ants on an n-vertext polygon. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter07_Q02
    {
        /*
          
         P(clockwise) = (1/2)^3
         P(counter) = (1/2)^3
         P(same direction) = P(clockwise) + P(counter) = (1/2)^2
         P(collision) = 1 - 1/4 = 3/4
         
         */
    }
}
