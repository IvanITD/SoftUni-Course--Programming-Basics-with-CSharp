using System;

namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int basketballYearSub = int.Parse(Console.ReadLine());

            double basketballSneakers = basketballYearSub - (basketballYearSub * 0.4);
            double basketballOutfit = basketballSneakers - (basketballSneakers * 0.2);
            double basketBall = basketballOutfit / 4 ;
            double basketballAccessories = basketBall / 5;
            double totalEquipmentPrice = basketballYearSub + basketballSneakers + basketballOutfit + basketBall + basketballAccessories;

            Console.WriteLine(totalEquipmentPrice);
        }
    }
}
