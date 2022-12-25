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

            if (season == "Spring")
            {
                rentPrice = 3000;
                if (fishersAmount <= 6)
                {
                    rentPrice -= rentPrice * 0.10;
                    if (fishersAmount % 2 == 0)
                    {
                        rentPrice -= rentPrice * 0.5;
                    }
                }
                else if (fishersAmount >= 7 && fishersAmount <= 11)
                {
                    rentPrice -= rentPrice * 0.15;
                    if (fishersAmount % 2 == 0)
                    {
                        rentPrice -= rentPrice * 0.5;
                    }
                }
                else if (fishersAmount > 12)
                {
                    rentPrice -= rentPrice * 0.25;
                    if (fishersAmount % 2 == 0)
                    {
                        rentPrice -= rentPrice * 0.5;
                    }
                }
                
            }
            else if (season == "Summer")
            {
                rentPrice = 4200;
                if (fishersAmount <= 6)
                {
                    rentPrice -= rentPrice * 0.10;
                    if (fishersAmount % 2 == 0)
                    {
                        rentPrice -= rentPrice * 0.5;
                    }
                }
                else if (fishersAmount >= 7 && fishersAmount <= 11)
                {
                    rentPrice -= rentPrice * 0.15;
                    if (fishersAmount % 2 == 0)
                    {
                        rentPrice -= rentPrice * 0.5;
                    }
                }
                else if (fishersAmount > 12)
                {
                    rentPrice -= rentPrice * 0.25;
                    if (fishersAmount % 2 == 0)
                    {
                        rentPrice -= rentPrice * 0.5;
                    }
                }
               
            }
            else if (season == "Autumn")
            {
                rentPrice = 4200;
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
            }
            else if (season == "Winter")
            {
                rentPrice = 2600;
                if (fishersAmount <= 6)
                {
                    rentPrice -= rentPrice * 0.10;
                    if (fishersAmount % 2 == 0)
                    {
                        rentPrice -= rentPrice * 0.5;
                    }
                }
                else if (fishersAmount >= 7 && fishersAmount <= 11)
                {
                    rentPrice -= rentPrice * 0.15;
                    if (fishersAmount % 2 == 0)
                    {
                        rentPrice -= rentPrice * 0.5;
                    }
                }
                else if (fishersAmount > 12)
                {
                    rentPrice -= rentPrice * 0.25;
                    if (fishersAmount % 2 == 0)
                    {
                        rentPrice -= rentPrice * 0.5;
                    }
                }
            }

            double remainingMoney = groupBudget - rentPrice;
            double neededMoney = rentPrice - groupBudget;

            if (rentPrice >= groupBudget)
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(neededMoney):F2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {remainingMoney:F2} leva left.");
            }
        }
    }
}
