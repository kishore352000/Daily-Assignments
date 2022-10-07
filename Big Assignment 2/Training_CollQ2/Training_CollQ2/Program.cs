using System;
using System.Collections.Generic;

namespace Training_CollQ2
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Student =
                     new Dictionary<int, string>();
            Student.Add(39544, "Kishore");
            Student.Add(28466, "Hari");
            Student.Add(38498, "Sai");



            foreach (KeyValuePair<int, string> ele in Student)
            {
                Console.WriteLine("{0} - {1}",
                          ele.Key, ele.Value);

            }

        }

    }
}
