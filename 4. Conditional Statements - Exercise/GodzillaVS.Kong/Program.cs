using System;

namespace GodzillaVS.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int supernumeraryAmount = int.Parse(Console.ReadLine());
            double clothingPricePerEach = double.Parse(Console.ReadLine());

            double decorPrice = movieBudget * 0.1;
            double clothingPrice = supernumeraryAmount * clothingPricePerEach;

            double clothingDiscount = 0.0;

            if (supernumeraryAmount >= 150)
            {
               clothingDiscount = clothingPrice * 0.1;
            }

            double moneyForClothing = clothingPrice - clothingDiscount;

            double totalMoviePrice = decorPrice + moneyForClothing;


            double remainingMoney = movieBudget - totalMoviePrice;
            double notEnoughMoney = totalMoviePrice - movieBudget;

            if (totalMoviePrice > movieBudget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {notEnoughMoney:F2} leva more.");
            }
            else if (totalMoviePrice <= movieBudget)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {remainingMoney:F2} leva left.");
            }
        }
    }
}
