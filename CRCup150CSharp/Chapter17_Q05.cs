/* Question 17.5
 
The Game of Master Mind if played as follows:
The computer has four lots, and each slot will contain a ball that is red (R), Yellow(Y), 
Green (G) or Blue (b). for example, the computer might have RGGB. You, the user, are trying
to guess the solution. You might, for example, guess YRGB. When you guess the correct collor
for the correct slot, you get a "hit". If you guess a color that exists but is in the wrong
slot, you get a "pseudo-hit". Note that a lot that is a hit can never count as a pseudo-hit.
For example, if the actual solution is RGBY and you guess GGRR, you have one hit and one 
pseudo-hit. Write a method that, given a guess and a solution, returns the number of hits 
and pseudo-hits.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q05
    {
        public static Result Estimate(string guess, string solution)
        {
            if (guess.Length != solution.Length)
                return null;

            Result res = new Result();
            Dictionary<char, int> map = new Dictionary<char, int>();

            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] == solution[i])
                    res.Hits++;
                else
                {
                    if (!map.ContainsKey(solution[i]))
                        map.Add(solution[i], 0);
                    map[solution[i]]++;
                }
            }

            for (int i = 0; i < guess.Length; i++)
            {
                if (guess[i] != solution[i] &&
                    map.ContainsKey(guess[i]) &&
                    map[guess[i]] > 0)
                {
                    res.PseudoHits++;
                    map[guess[i]]--;
                }
            }
            
            return res;
        }

        public class Result
        {
            public int Hits { get; set; }
            public int PseudoHits { get; set; }
        }
    }
}
