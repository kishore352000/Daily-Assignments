using System;

namespace LambdaExpression
{

    public delegate int del(int d,int e);
    class Program
    {
        static void Main(string[] args)
        {
            //statement lamda
            del d = (a,b) => a > b ? a : b ;
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Greater of 2 numbers is:"+d.Invoke(num1, num2));
        }
    }
}
