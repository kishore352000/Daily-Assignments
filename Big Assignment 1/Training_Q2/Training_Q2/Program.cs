using System;

namespace Training_Q2
{
    // Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle.
        internal class Program
        {
            static void Main(string[] args)
            {
                double radius, perimeter;
                double PI = 3.14;
                Console.Write("Enter the radius: ");
                radius = double.Parse(Console.ReadLine());

                perimeter = (double)(2 * Math.PI * radius);
                Console.WriteLine("Perimeter of Circle: " + perimeter);

            }
        }
    }

