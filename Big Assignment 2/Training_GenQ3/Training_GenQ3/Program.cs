using System;

namespace Training_GenQ3
{
    public class A<T,U>
    {
        T obj1;
        U obj2;
        public A(T obj1, U obj2)
        {
            this.obj1 = obj1;
            this.obj2 = obj2;
        }
        public void display()
        {
            Console.Write(obj1 + "\t");
            Console.WriteLine(obj2 + "\t");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A<int, string> one = new A<int, string>(10, "kishore");
            one.display();
            A<int, string> two = new A<int, string>(13, "reddy");
            two.display();
   
        }
    }
}
