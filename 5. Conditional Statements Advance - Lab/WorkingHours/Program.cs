using System;

namespace WorkingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine();

            if ((hour >= 10 && hour <= 18) && weekDay != "Sunday")
            {
                Console.WriteLine("open");
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
