using System;

namespace WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayHour = int.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine();

            switch (weekDay)
            {
                case "Monday":
                    if (dayHour >= 10 && dayHour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;

                case "Tuesday":
                    if (dayHour >= 10 && dayHour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;

                case "Wednesday":
                    if (dayHour >= 10 && dayHour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;

                case "Thursday":
                    if (dayHour >= 10 && dayHour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;

                case "Friday":
                    if (dayHour >= 10 && dayHour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;

                case "Saturday":
                    if (dayHour >= 10 && dayHour <= 18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;

                case "Sunday":
                    if (dayHour >= 10 && dayHour <= 18)
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                    
            }
        }
    }
}
