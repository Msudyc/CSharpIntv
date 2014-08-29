/* Question 17.14
 
Oh, no! You have just completed a lengthy document when you have an unfortunate Find/Replace mishap.
You have accidentally removed all spaces, punctuation, and capitalization in the document. A sentence
like "I reset the computer. It still didn't boot!" would become "iresetthecomputeritstilldidntboot". 
You figure that you can add back in the punctuation and capitalization later, once you get the individual
words properly separated. Most of the word will be in a dictionary, but some strings, like proper names,
will not. Given a dictionary (a list of words), design an algorithm to find the optimal way of 
"unconcatenating" a sequence of words. In this case, "optimal" is defined to be the parsing which 
minimizes the number of unrecognized sequences of characters.
For example, the string "jesslookedjustliketimherbrother" would be optimally parsed 
as "JESS looked just like TIM her brother". This parsing has seven unrecognized characters, 
which we have capitalized for clarity.
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter17_Q14
    {
        private string sentence;
        private Trie dict;

        public Chapter17_Q14(string[] words, string sentence)
        {
            this.sentence = sentence;
            this.dict = new Trie(words);
        }

        public string Parse()
        {
            Dictionary<int, Result> cache = new Dictionary<int, Result>();
            Result result = this.Parse(0, 0, cache);
            return result.Parsed;
        }

        private Result Parse(
            int start, 
            int end, 
            Dictionary<int, Result> cache)
        {
            if (end >= this.sentence.Length)
                return new Result(
                    end - start, 
                    this.sentence.Substring(start).ToUpper());

            if (cache.ContainsKey(start))
                return cache[start].Clone();

            string curWord = this.sentence.Substring(start, end - start + 1);
            bool validPartial = this.dict.Contains(curWord, false);
            bool validExact = validPartial && this.dict.Contains(curWord, true);

            Result bestExact = this.Parse(end + 1, end + 1, cache);
            if (validExact == true)
                bestExact.Parsed = curWord + " " + bestExact.Parsed;
            else
            {
                bestExact.Invalid += curWord.Length;
                bestExact.Parsed = curWord.ToUpper() + " " + bestExact.Parsed;
            }

            Result bestExtend = null;
            if (validPartial == true)
                bestExtend = this.Parse(start, end + 1, cache);

            Result best = Result.Min(bestExact, bestExtend);
            if(!cache.ContainsKey(start))
                cache.Add(start, best.Clone());
            return best;
        }

        private class Result
        {
            public int Invalid { get; set; }
            public string Parsed { get; set; }
            public Result(int inv, string p)
            {
                this.Invalid = inv;
                this.Parsed = p;
            }

            public Result Clone()
            {
                return new Result(this.Invalid, this.Parsed);
            }

            public static Result Min(Result r1, Result r2)
            {
                if (r1 == null)
                    return r2;
                else if (r2 == null)
                    return r1;
                return r2.Invalid < r1.Invalid ? r2 : r1;
            }
        }
    }
}
