using System;

namespace PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodAmount = int.Parse(Console.ReadLine());
            int catFoodAmount = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.50;
            double catFoodPrice = 4;
            
            double dogPrice = dogFoodAmount * dogFoodPrice;
            double catPrice = catFoodAmount * catFoodPrice;
            double wholePrice = dogPrice + catPrice;


            Console.WriteLine($"{wholePrice} lv.");
        }
    }
}
