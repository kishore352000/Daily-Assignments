using System;

namespace Training_Q14
{
    
// Write a C# Sharp program to find the length of the longest substring without repeating characters from a given string.
        internal class Program
        {
            public static bool areDistinct(string str,
                                   int i, int j)
            {


                bool[] visited = new bool[26];

                for (int k = i; k <= j; k++)
                {
                    if (visited[str[k] - 'a'] == true)
                        return false;

                    visited[str[k] - 'a'] = true;
                }
                return true;
            }


            public static int longestUniqueSubsttr(string str)
            {
                int n = str.Length;


                int res = 0;

                for (int i = 0; i < n; i++)
                    for (int j = i; j < n; j++)
                        if (areDistinct(str, i, j))
                            res = Math.Max(res, j - i + 1);

                return res;
            }
            static void Main(string[] args)
            {
                string str = "geeksforgeeks";
                Console.WriteLine("The input string is " + str);

                int len = longestUniqueSubsttr(str);

                Console.WriteLine("The length of the longest " +
                                  "non-repeating character " +
                                  "substring is " + len);
            }
        }
    }
