using System;

namespace LuchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int episodeDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());

            double luchTime = breakDuration / 8.0;
            double breakTime = breakDuration / 4.0;

            double remainingTime = breakDuration - (luchTime + breakTime);

            double expectedTime = remainingTime - episodeDuration;

            if (remainingTime >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {seriesName}" +
                    $" and left with {Math.Ceiling(expectedTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}" +
                    $", you need {Math.Ceiling(Math.Abs(expectedTime))} more minutes.");
            }
        }
    }
}
