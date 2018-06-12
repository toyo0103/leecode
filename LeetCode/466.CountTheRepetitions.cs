using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    //Define S = [s, n] as the string S which consists of n connected strings s.For example, ["abc", 3] = "abcabcabc".
    //On the other hand, we define that string s1 can be obtained from string s2 if we can remove some characters from s2 such that it becomes s1.For example, “abc” can be obtained from “abdbec” based on our definition, but it can not be obtained from “acbbe”.
    //You are given two non-empty strings s1 and s2 (each at most 100 characters long) and two integers 0 ≤ n1 ≤ 106 and 1 ≤ n2 ≤ 106. Now consider the strings S1 and S2, where S1 =[s1, n1] and S2 =[s2, n2].Find the maximum integer M such that[S2, M] can be obtained from S1.

    public partial class Solution
    {
        public int GetMaxRepetitions(string s1, int n1, string s2, int n2)
        {
            var S1Chars = s1.ToCharArray();
            var S2Chars = s2.ToCharArray();


            int S2Cursor = 0;
            int Repetitions = 0;
            var LogFirstLetterMatchInS1Index = new Dictionary<int, Tuple<int, int>>();
            for (int i = 0; i < S1Chars.Length * n1 ; i++)
            {
                var S1Index = i % s1.Length;
                if (S1Chars[S1Index] == S2Chars[S2Cursor])
                {
                    if (S2Cursor == 0)
                    {
                        if (LogFirstLetterMatchInS1Index.ContainsKey(S1Index))
                        {
                            //形成Loop了
                            var PreSameIndexValue = LogFirstLetterMatchInS1Index[S1Index];

                            //Repetitions
                            var OneLoopS2Count = (Repetitions - PreSameIndexValue.Item2);

                            var OneLoopDistance = i - PreSameIndexValue.Item1;

                            while ((i + OneLoopDistance) < S1Chars.Length * n1)
                            {
                                Repetitions += OneLoopS2Count;

                                i += OneLoopDistance;
                            }

                        }
                        else
                        {
                            LogFirstLetterMatchInS1Index.Add(S1Index,new Tuple<int, int>(i, Repetitions));
                        }
                    }
                    S2Cursor++;
                }

                if (S2Cursor == S2Chars.Length)
                {
                    Repetitions++;

                    S2Cursor = 0;
                }
            }

            return Repetitions / n2;
        }
    }
}
