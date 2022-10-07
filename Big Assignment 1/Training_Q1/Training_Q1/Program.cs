using System;

namespace Training_Q1
{
    // Write a C# Sharp program that takes three letters as input and display them in reverse order.

        internal class Program
        {
            static void Main(string[] args)
            {
                char first, second, third;

                Console.Write("Input letter1: ");
                first = Convert.ToChar(Console.ReadLine());

                Console.Write("Input letter2: ");
                second = Convert.ToChar(Console.ReadLine());

                Console.Write("Input letter3: ");
                third = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("{0} {1} {2}", third, second, first);
            }
        }

    }
