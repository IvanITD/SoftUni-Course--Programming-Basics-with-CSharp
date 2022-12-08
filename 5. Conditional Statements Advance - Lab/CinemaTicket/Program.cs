using System;

namespace CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string weekDay = Console.ReadLine();

            if (weekDay == "Monday")
            {
                Console.WriteLine("12");
            }
            else if (weekDay == "Tuesday")
            {
                Console.WriteLine("12");
            }
            else if (weekDay == "Wednesday")
            {
                Console.WriteLine("14");
            }
            else if (weekDay == "Thursday")
            {
                Console.WriteLine("14");
            }
            else if (weekDay == "Friday")
            {
                Console.WriteLine("12");
            }
            else if (weekDay == "Saturday")
            {
                Console.WriteLine("16");
            }
            else if (weekDay == "Sunday")
            {
                Console.WriteLine("16");
            }
        }
    }
}
