using System;

namespace Training_WQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 12, 13,22 };

            for (int i = 0; i <= arr.Length; i++)
            {
                try
                {
                    Console.WriteLine(arr[i]);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


        }
    }
}
