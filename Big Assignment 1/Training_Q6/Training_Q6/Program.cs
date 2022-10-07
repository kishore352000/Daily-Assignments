using System;

namespace Training_Q6
{
    // Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height. (Below 135 - short, above 180, tall. In between average)
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter height(in cms) : ");
                int height = int.Parse(Console.ReadLine());
                if (height < 135)
                {
                    Console.WriteLine("Height is Short");
                }
                else if (height >= 135 && height <= 180)
                {
                    Console.WriteLine("Height is Average");
                }
                else
                {
                    Console.WriteLine("Height is Tall");
                }
            }
        }
    }
