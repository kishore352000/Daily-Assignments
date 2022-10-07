using System;

namespace Training_Q5
{
    // Write a C# Sharp program to find whether a given year is a leap year or not.
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter Year : ");
                int Year = int.Parse(Console.ReadLine());
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                    Console.WriteLine("{0} is a Leap Year.", Year);
                else
                    Console.WriteLine("{0} is not a Leap Year.", Year);
            }
        }
    }

