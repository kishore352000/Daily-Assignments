using System;

namespace Training_Q13
{
    // Write a program in C# Sharp to read a sentence and replace lowercase characters by uppercase and vice-versa.
        internal class Program
        {
            static void Main(string[] args)
            {
                string str1;
                char[] arr1;
                int l, i;
                l = 0;
                char ch;

                Console.Write("Input the string : ");
                str1 = Console.ReadLine();
                l = str1.Length;
                arr1 = str1.ToCharArray(0, l);

                Console.Write("\nAfter conversion, the string is : ");
                for (i = 0; i < l; i++)
                {
                    ch = arr1[i];
                    if (Char.IsLower(ch))
                        Console.Write(Char.ToUpper(ch));
                    else
                        Console.Write(Char.ToLower(ch));
                }
            }
        }
    }

