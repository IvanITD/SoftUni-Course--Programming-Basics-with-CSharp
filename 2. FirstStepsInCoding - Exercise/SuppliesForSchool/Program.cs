using System;

namespace SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPacketNum = int.Parse(Console.ReadLine());
            int markerPacketNum = int.Parse(Console.ReadLine());
            int detersiveForWood = int.Parse(Console.ReadLine());
            double discount = int.Parse(Console.ReadLine());

            double penPacket = 5.80;
            double markerPacket = 7.20;
            double detersive = 1.20;


            double penPacketPrice = penPacketNum * penPacket;
            double markerPacketPrice = markerPacketNum * markerPacket;
            double detersivePrice = detersiveForWood * detersive;
            
            double totalPrice = penPacketPrice + markerPacketPrice + detersivePrice;

            discount = discount * 0.01;
            double discountedPrice = totalPrice - (totalPrice * discount);

            Console.WriteLine(discountedPrice);
        }
    }
}
