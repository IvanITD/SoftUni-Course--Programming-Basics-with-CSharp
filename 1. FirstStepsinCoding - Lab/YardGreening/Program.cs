using System;

namespace YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareMeters = double.Parse(Console.ReadLine());

            double yardGreeningPrice = squareMeters * 7.61;
            double discountedPrice = 0.18 * yardGreeningPrice;
            double finalPrice =   yardGreeningPrice - discountedPrice;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discountedPrice} lv.");

        }
    }
}
