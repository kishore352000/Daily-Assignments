using System;

namespace Day_5
{
   /* abstract class Solid
    {
        public abstract double Volume();
        public abstract double SurfaceArea();
        public void show()
        {
            Console.WriteLine("volume is:" + Volume());
            Console.WriteLine("surface area is:" + SurfaceArea());
        }

    }



    class Cube : Solid
    {
        double side;
        public Cube(double side)
        {
            this.side = side;
        }
        public override double Volume()
        {
            return (side * side * side);
        }
        public override double SurfaceArea()
        {
            return (6 * side * side);
        }



    }
    class Cylinder : Solid
    {
        double radius, height;
        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }
        public override double Volume()
        {
            return (3.14 * (radius * radius) * height);
        }
        public override double SurfaceArea()
        {
            return ((2 * 3.14 * radius * height) + (2 * 3.14 * (radius * radius)));
        }
    }



    class Day5
    {
        public static void Main(string[] args)
        {
            Cube c = new Cube(4);
            c.show();
            Cylinder cy = new Cylinder(4, 8);
            cy.show();





        }
    }  */



  //  PASSWORD SUM------------>



  class Day5
    {
        public static void hideString(string bank_account)
        {
            for (int i = 0; i < bank_account.Length; i++)
            {
                if (i < bank_account.Length - 4)
                    Console.Write("*");
                else
                    Console.Write(bank_account[i]);
            }

        }
        public static void Main(string[] args)
        {
            Console.Write("Enter Bank Account Number:");
            string bank_account = Console.ReadLine();
            Console.Write("Updated Account Number : ");
            hideString(bank_account);
        }
    } 
}
