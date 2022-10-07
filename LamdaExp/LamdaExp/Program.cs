using System;

namespace LamdaExp
{
    public delegate void del(int a, float b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            //statement lamda
            /*   del d =(p,t,r)=>
              {
                  Console.WriteLine("Simple Interest =" + p * t * r / 100);

              }; */
            // expresion lambda
            del d = (p, t, r) => Console.WriteLine("Simple Interest =" + p * t * r / 100);
            Console.Write("Enter Amount :");
            int am = int.Parse(Console.ReadLine());
            Console.Write("Enter Rate of Interest :");
            float ra = float.Parse(Console.ReadLine());
            Console.Write("Enter years :");
            int t = int.Parse(Console.ReadLine());
            d.Invoke(am, ra, t);
        }
    }
}
