using System;

namespace BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startupNumber = int.Parse(Console.ReadLine());

            double bonus = 0.0;

            if (startupNumber <= 100)
            {
                bonus = 5;
            }
            else if (startupNumber > 1000)
            {
                bonus = startupNumber * 0.1;
            }
            else
            {
                bonus = startupNumber * 0.2;
            }

            if (startupNumber % 2 == 0)
            {
                bonus += 1;
            }
            else if (startupNumber % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(startupNumber + bonus);
        }
    }
}
