using System;

namespace Training_WQ5
{
    abstract class Bank_Account
    {
        public abstract void Link_Aadhar_Bank_AccNo();

    }
    class Link : Bank_Account
    {
        double aadhar_no;
        public Link()
        {
            Console.Write("Enter Aadhar Number :");
            aadhar_no = Convert.ToDouble(Console.ReadLine());

        }
        public override void Link_Aadhar_Bank_AccNo()
        {
            Console.WriteLine("Linked Bank Account Number with Aadhar Number Successfully!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Link link = new Link();

            link.Link_Aadhar_Bank_AccNo();
        }
    }
}
