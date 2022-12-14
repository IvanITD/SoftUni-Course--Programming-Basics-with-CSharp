using System;

namespace FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishersAmount = int.Parse(Console.ReadLine());

            double rentPrice = 0.00;

            switch (season)
            {
                case "Spring":
                    rentPrice = 3000.00;
                    break;

                case "Summer":
                case "Autumn":
                    rentPrice = 4200.00;
                    break;

                case "Winter":
                    rentPrice = 2600.00;
                    break;
            }

            if (fishersAmount <= 6)
            {
                rentPrice -= rentPrice * 0.10;
            }
            else if (fishersAmount >= 7 && fishersAmount <= 11)
            {
                rentPrice -= rentPrice * 0.15;
            }
            else if (fishersAmount > 12)
            {
                rentPrice -= rentPrice * 0.25;
            }

            if (fishersAmount % 2 == 0 && season != "Autumn")
            {
                rentPrice -= rentPrice * 0.05;
            }


            double remainingMoney = groupBudget - rentPrice;
            double neededMoney = rentPrice - groupBudget;

            if (groupBudget >= rentPrice)
            {
                Console.WriteLine($"Yes! You have {remainingMoney:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(neededMoney):F2} leva.");
            }
        }
    }
}
