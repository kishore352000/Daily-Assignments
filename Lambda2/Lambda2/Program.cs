using System;

namespace Lambda2
{
    public delegate void del(int d);
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            //statement lamda
             del d =(a)=>
              {
                 for(int i=1;i<=a; i++)
                  {
                      sum += i;
                  }
                  Console.WriteLine("sum of numbers=" + sum);
              }; 
            Console.Write("Enter a number :");
            int n = int.Parse(Console.ReadLine());
           
            d.Invoke(n);
        }
    }
}
