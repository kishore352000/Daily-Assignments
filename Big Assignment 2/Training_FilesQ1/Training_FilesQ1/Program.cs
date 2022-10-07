using System;
using System.IO;

namespace Training_FilesQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("C:\\Users\\kishore.lakkireddy\\OneDrive - Entain Group\\sample.txt", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This example adds content to existing file");
            Console.WriteLine("Text appended successfully!!!");
            sw.Close();
            fs.Close();




        }
    }
}
