using System;

namespace Anonymous
{
    public  delegate void del (int a, float b, int c);
    class Program
    {
        static void Main(string[] args)
        {
            del d = delegate (int p,float t,int r)
            {
                Console.WriteLine("Simple Interest ="+ p * t * r / 100);

            };
            Console.Write("Enter Amount :");
            int am = int.Parse(Console.ReadLine());
            Console.Write("Enter Rate of Interest :");
           float ra =float.Parse(Console.ReadLine());
            Console.Write("Enter years :");
            int t = int.Parse(Console.ReadLine());
            d.Invoke(am, ra, t);
        }
    }
}
