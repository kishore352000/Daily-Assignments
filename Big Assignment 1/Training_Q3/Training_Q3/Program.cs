using System;

namespace Training_Q3
{
   // Write a C# Sharp program that takes distance and time as input and displays the speed in kilometres per hour and miles per hour.
        internal class Program
        {
            static void Main(string[] args)
            {
                float distance;
                float hour, min, sec;

                float timeSec;
                float mps;
                float kph, mph;

                Console.Write("Input distance(meters): ");
                distance = Convert.ToSingle(Console.ReadLine());
                Console.Write("Input timeSec(hour): ");
                hour = Convert.ToSingle(Console.ReadLine());
                Console.Write("Input timeSec(minutes): ");
                min = Convert.ToSingle(Console.ReadLine());
                Console.Write("Input timeSec(seconds): ");
                sec = Convert.ToSingle(Console.ReadLine());

                timeSec = (hour * 3600) + (min * 60) + sec;
                mps = distance / timeSec;
                kph = (distance / 1000.0f) / (timeSec / 3600.0f);
                mph = kph / 1.609f;

                Console.WriteLine("Your speed in meters/sec is {0}", mps);
                Console.WriteLine("Your speed in km/h is {0}", kph);
                Console.WriteLine("Your speed in miles/h is {0}", mph);
            }
        }
    }

