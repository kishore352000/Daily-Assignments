using System;

namespace Training_Q8
{
    // Write a C# program to check whether the triangle is Equilateral, Isosceles or Scalene based on the input sides from the user.
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Input side 1 of triangle: ");
                int sidea = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 2 of triangle: ");
                int sideb = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 3 of triangle: ");
                int sidec = Convert.ToInt32(Console.ReadLine());



                if (sidea == sideb && sideb == sidec)
                {
                    Console.Write("This is an equilateral triangle.\n");
                }
                else if (sidea == sideb || sidea == sidec || sideb == sidec)
                {
                    Console.Write("This is an isosceles triangle.\n");
                }
                else
                {
                    Console.Write("This is a scalene triangle.\n");
                }

            }
        }
    }

