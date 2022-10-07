using System;

namespace Day_4
{
    /* class MyClass

    {

        //pass by value, pass by reference

        public void Increase(ref int x)

        {

            x = x + 1;

        }

        public void Equal(int y)

        {

            y = y + 1;

        }



    }

    class Day4

    {

        public static void Main(string[] args)

        {

            MyClass mcs = new MyClass();

            int x = 20;

            int y = 10;

            Console.WriteLine("The original value of x is: " + x);

            Console.WriteLine("The original value of y is: " + y);

            mcs.Increase(ref x);

            mcs.Equal(y);
            Console.WriteLine("Value incremented by using By Reference for the variable x is:" + x);
            Console.WriteLine("Value incremented by using By Reference for the variable y is:" + y);
            Console.ReadKey();

        }
    } */



    /* class Day4
     {
         [Obsolete]
         public void MyFirstMethod()
         {
             Console.WriteLine("Called First Method()");
         }
         [ObsoleteAttribute]
         public void MySecondMethod()
         {
             Console.WriteLine("Called Second Method()");
         }
         [Obsolete("you shouldn't use this method anymore")]
         public void MyThirdMethod()
         {
             Console.WriteLine("Called Third Method()");
         }
         //make the program thread-safe for COM
         [STAThread]
         [Obsolete]
         static void Main(string[] args)
         {
             Day4 obj = new Day4();
             obj.MyFirstMethod();
             obj.MySecondMethod();
             obj.MyThirdMethod();
         }
     } */



    /* public class Person
     {
         public int age;
         public string name;
     }
     public  class Student : Person
     {
         public int rollNumber;
         public string stream;
     }
     public class Employee : Person
     {
         public int employeeId;
         public double salary;
     }
     class Day4
     {
         public static void Main(string[] args)
         {
             Student s = new Student();
             s.name = "Kishore";
             s.age = 22;
             s.rollNumber = 7363;
             s.stream = "CSE";
             Console.WriteLine("-----Student Details---");
             Console.WriteLine(s.name);
             Console.WriteLine(s.age);
             Console.WriteLine(s.rollNumber);
             Console.WriteLine(s.stream);



             Console.WriteLine();
             Console.WriteLine("----Employee Details---");
             Employee e = new Employee();
             e.name = "Deepu";
             e.age = 22;
             e.salary = 60000;
             e.employeeId = 0986;
             Console.WriteLine(e.name);
             Console.WriteLine(e.age);
             Console.WriteLine(e.salary);
             Console.WriteLine(e.employeeId);
         }
     }  */



    /*  class Day4

      {

          public static void Main(string[] args)

          {

              char ch1, ch2, ch3;

              Console.Write("Input 1st letter: ");

              ch1 = Convert.ToChar(Console.ReadLine());

              Console.Write("Input 2nd letter: ");

              ch2 = Convert.ToChar(Console.ReadLine());


              Console.Write("Input 3rd letter: ");

              ch3 = Convert.ToChar(Console.ReadLine());



              Console.WriteLine( ch3+" "  +ch2+" " +ch1);



          }

      }  */


    /*  class Day4

      {

          public static void Main(string[] args)

          {

              Console.Write("Enter number: ");

              int number = Convert.ToInt32(Console.ReadLine());



              Console.Write("Enter width: ");

              int width = Convert.ToInt32(Console.ReadLine());



              int height = width;

              for (int row = 0; row < height; row++)

              {

                  for (int column = 0; column < width; column++)

                  {

                      Console.Write(number);

                  }



                  Console.WriteLine();

                  width--;

              }

          }

      } */



    /* class Day4
     {
         public static void Main(string[] args)
         {
             int x, y;
             for (y = -5; y <= 5; y++)
             {
                 x = y * y - 2 * y + 1;
                 Console.WriteLine(
                      "y = {0} ; x=({0})² - 2*({0}) +1 = {1}",
                     y, x);
             }
         }
     } */



    public class Authenticate
    {
        public static void Main()
        {
            string user, pass;
            int count = 0;

            do
            {
                if(count >0 && count <= 2)
                {
                    Console.WriteLine("Try Again!! ");
                }
                Console.Write("Enter username: ");
                user = Console.ReadLine();

                Console.Write("Enter password: ");
                pass = Console.ReadLine();

                count++;

            }
            while (((user != "user") || (pass != "password"))
                && (count != 3));

            if (count == 3)
                Console.Write("Login attemp fail!");
            else
                Console.Write("Your Login is Successfully ");
        }
    }
}
