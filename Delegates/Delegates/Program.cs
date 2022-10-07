using System;

namespace Delegates
{
    public delegate void ans(int a);
    public class Program
    {
            int fa = 1;
            int val1 = 0, val2 = 1, val3;
             void factorial(int f)
            {
                for(int i = 1; i <= f; i++)
                {
                    fa = fa * i;

                }
                Console.WriteLine("Factorial =" + fa);
            }
            void fib(int fi)
            {
                for (int i = 2; i < fi; ++i)
                {
                    val3 = val1 + val2;
                    Console.Write(val3 + " ");
                    val1 = val2;
                    val2 = val3;
                }
            }
            void factors(int fac)
            {
                for (int i = 1; i <= fac; i++)
                {
                    if (fac % i == 0)
                    {
                        Console.WriteLine("Factors of number "+fac +"="+i);
                    }
                }
            }
            void table(int t)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} X {1} = {2} \n", t, j, t * j);
                }
            }
        public static void Main(string[] args)
        {
            Program p = new Program();
            ans del = new ans(p.factorial);
            Console.Write("Enter number for finding factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());
            del.Invoke(number);
            Console.Write("Enter number for fibinocci series: ");
            int num = Convert.ToInt32(Console.ReadLine());
            del = p.fib;
            del.Invoke(num);
            Console.WriteLine(" ");
            Console.Write("Enter number for displaying factors : ");
            int nu = Convert.ToInt32(Console.ReadLine());
            del =p.factors;
            del.Invoke(nu);
            Console.Write("Enter number for displaying the respective table: ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            del =p.table;
            del.Invoke(numbers);


        }
    }
}
