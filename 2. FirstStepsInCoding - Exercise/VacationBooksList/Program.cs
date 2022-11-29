using System;

namespace VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pageNum = int.Parse(Console.ReadLine());
            int page = int.Parse(Console.ReadLine());
            int countDays = int.Parse(Console.ReadLine());

            int totalReadingHour = pageNum / page;
            int neededHours = totalReadingHour / countDays;


            Console.WriteLine(neededHours);
        }
    }
}
