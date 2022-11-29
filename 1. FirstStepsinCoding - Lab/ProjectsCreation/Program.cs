using System;

namespace ProjectsCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int ProjectsAmount = int.Parse(Console.ReadLine());
            int neededHours = ProjectsAmount * 3;

            Console.WriteLine($"The architect {architectName} will need {neededHours} hours to complete {ProjectsAmount} project/s.");
        }
    }
}
