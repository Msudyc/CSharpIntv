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
            List<string> results = this.WordBreak(this.sentence);

            int k = 0;
            int min = int.MaxValue;
            for (int i = 0; i < results.Count; i++)
                if (results[i].Length < min)
                {
                    min = results[i].Length;
                    k = i;
                }
            return results[k];
        }

        private List<string> WordBreak(string s)
        {
            int len = s.Length;
            List<List<int>> record = new List<List<int>>();

            for (int i = 0; i < len; i++)
                record.Add(new List<int>());

            for (int end = len - 1; end >= 0; end--)
                for (int runner = end; runner >= 0; runner--)
                    if (this.dict.Contains(s.Substring(runner, end - runner + 1), true))
                        record[runner].Add(end);

            List<string> solutionSet = new List<string>();
            WordBreakHelper(record, 0, s, "", "", solutionSet);

            return solutionSet;
        }

        private void WordBreakHelper(
            List<List<int>> record,
            int current,
            string s,
            string solution,
            string notMatch,
            List<string> solutionSet)
        {
            if (current == s.Length - 1)
            {
                if (!string.IsNullOrEmpty(notMatch))
                    notMatch = notMatch.ToUpper();

                solutionSet.Add(solution + " " + notMatch);
                return;
            }

            if (record[current].Count == 0)
                WordBreakHelper(record, current + 1, s, solution, notMatch + s[current], solutionSet);
            else
            {
                if (!string.IsNullOrEmpty(notMatch))
                {
                    string add = string.IsNullOrEmpty(solution) ? notMatch.ToUpper() : " " + notMatch.ToUpper();
                    solution += add;
                }

                foreach (int end in record[current])
                {
                    string sub = s.Substring(current, end - current + 1);
                    string newSoln = solution + (current == 0 ? sub : " " + sub);
                    if (end == s.Length - 1)
                        solutionSet.Add(newSoln);
                    else
                        WordBreakHelper(record, end + 1, s, newSoln, "", solutionSet);
                }
            }
        }
    }
}
