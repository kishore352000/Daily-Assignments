using System;

namespace Training_Q7
{
    /* Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria: Marks in Maths >=65
Marks in Phy >=55
Marks in Chem>=50
Total in all three subject >=180
or
Total in Math and Subjects >=140 */
        internal class Program
        {
            static void Main(string[] args)
            {
                int p, c, m;


                Console.Write("Input the marks obtained in Physics :");
                p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the marks obtained in Chemistry :");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the marks obtained in Mathematics :");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n", m + p + c);
                Console.Write("Total marks of Maths and  Physics : {0}\n", m + p);

                if (m >= 65)
                    if (p >= 55)
                        if (c >= 50)
                            if ((m + p + c) >= 180 || (m + p) >= 140)
                                Console.Write("The  candidate is eligible for admission.\n");
                            else
                                Console.Write("The candidate is not eligible.\n\n");
                        else
                            Console.Write("The candidate is not eligible.\n\n");
                    else
                        Console.Write("The candidate is not eligible.\n\n");
                else
                    Console.Write("The candidate is not eligible.\n\n");
            }
        }
    }
