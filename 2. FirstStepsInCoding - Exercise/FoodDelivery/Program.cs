using System;

namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenuAmount = int.Parse(Console.ReadLine());
            int fishMenuAmount = int.Parse(Console.ReadLine());
            int vegeterianMenuAmount = int.Parse(Console.ReadLine());

            double chickenMenu = 10.35;
            double fishMenu = 12.40;
            double vegeterianMenu = 8.15;

            double chickenPrice = chickenMenuAmount * chickenMenu;
            double fishPrice = fishMenuAmount * fishMenu;
            double vegeterianPrice = vegeterianMenuAmount * vegeterianMenu;

            double totalMenuPrice = chickenPrice + fishPrice + vegeterianPrice;

            double desertPrice = 0.2 * totalMenuPrice;
            double deliveryPrice = 2.50;

            double totalPrice = totalMenuPrice + desertPrice + deliveryPrice;
            Console.WriteLine(totalPrice);




        }
    }
}
