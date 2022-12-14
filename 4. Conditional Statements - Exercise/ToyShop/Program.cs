using System;
using System.Reflection.Metadata.Ecma335;

namespace ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tourPrice = double.Parse(Console.ReadLine());
            int puzzleAmount = int.Parse(Console.ReadLine());
            int speakingDollsAmount = int.Parse(Console.ReadLine());
            int fluffyBearsAmount = int.Parse(Console.ReadLine());
            int minionsAmount = int.Parse(Console.ReadLine());
            int trucksAmount = int.Parse(Console.ReadLine());

            double puzzlePrice = puzzleAmount * 2.60;
            double speakingDollPrice = speakingDollsAmount * 3.0;
            double fluffyBearPrice = fluffyBearsAmount * 4.10;
            double minionPrice = minionsAmount * 8.20;
            double truckPrice = trucksAmount * 2.0;

            double totalPrice = puzzlePrice + speakingDollPrice + fluffyBearPrice +
                minionPrice + truckPrice;

            double totalAmount = puzzleAmount + speakingDollsAmount + fluffyBearsAmount +
                minionsAmount + trucksAmount;

            
            double discountedPrice = 0.0;

            if (totalAmount >= 50)
            {
                discountedPrice = totalPrice * 0.25;
            }

            double finalPrice = totalPrice - discountedPrice;
            double rentPrice = finalPrice * 0.1;
            double expectedProfit = finalPrice - rentPrice;

            double remainingMoney = expectedProfit - tourPrice;
            double notenoughMoney = tourPrice - expectedProfit;
            if (expectedProfit >= tourPrice)
            {
                Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {notenoughMoney:F2} lv needed.");
            }
        }
    }
}
