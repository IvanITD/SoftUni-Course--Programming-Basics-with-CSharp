using System;

namespace WorldSwimRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double swimmingTime = distanceInMeters * timeInSeconds;

            double added15Meters = Math.Floor(distanceInMeters / 15) * 12.5;

            double totalTime = swimmingTime + added15Meters;

            double notEnoughTime = totalTime - recordInSeconds;
            

            if (totalTime < recordInSeconds)
            {

                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
                
            }
            else if (totalTime >= recordInSeconds)
            {
                Console.WriteLine($"No, he failed! He was {notEnoughTime:F2} seconds slower.");
            }
        }
    }
}
