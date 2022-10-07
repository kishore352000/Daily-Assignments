using System;

namespace Training_WQ2
{
    public class Division
    {
        double res =0;

        public void div(double n1, double n2)
        {
            try
            {
                res = n1 / n2;

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }

    public class Square_root
    {
        double SquareRoot;

        public void square_root_num(double num)
        {
            SquareRoot = Math.Sqrt(num);
            Console.WriteLine("Square Root of" +num + ":" +SquareRoot);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Square_root sqrt = new Square_root();
            Console.Write("Enter the value");

            double num = Convert.ToDouble(Console.ReadLine());

            sqrt.square_root_num(num);

            Division d = new Division();

            d.div(6, 0);


        }
    }
}
