using System;

namespace Training_Q4
{
   // Write a C# Sharp program that takes two numbers as input and returns true or false when both numbers are even or odd.
        internal class Program
        {
            static void Main(string[] args)
            {
                int num1, num2;
                Console.Write("Input First number: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input Second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                if ((num1 % 2 == 0 && num2 % 2 == 0) || (num1 % 2 != 0 && num2 % 2 != 0))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
    }

