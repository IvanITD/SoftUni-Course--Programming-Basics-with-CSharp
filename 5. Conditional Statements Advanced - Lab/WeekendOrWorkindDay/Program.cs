using System;

namespace WeekendOrWorkindDay_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string days = Console.ReadLine();

            if (days == "Monday" || days == "Tuesday" || days == "Wednesday" || days == "Thursday" || days == "Friday")
            {
                Console.WriteLine("Working day");
            }
            else if (days == "Saturday" || days == "Sunday")
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
