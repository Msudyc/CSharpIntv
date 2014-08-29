/* Question 7.1
 
You have a basketball hoop and someone says that you can play one of two games.
Game 1: You get one shot to make the hoop.
Game 2: You get three shots and you have to make two of these shots.
If p is the probability of making a particular shot, for which values of p 
should you pick one game or the other?
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter07_Q01
    {
        /*
         
         p: probability of winning game.
         s(k, n): probability of making exactly k shots out of n.
         
         P(winning) = s(2, 3) + s(3, 3)
         s(3, 3) = p^3
         s(2, 3) = 3(1-p)p^2
         
         p > 3p^2 -2p^3
         
         p < 0.5, Play game 1
         p = 0, .5, 1 then Game 1 = Game 2
        
         */
    }
}
