using System;

namespace FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double aquariumVolume = length * width * height;
            double volumeInLiters = aquariumVolume * 0.001;
            double filledSpace = procent * 0.01;
            double neededSpace = volumeInLiters * (1 - filledSpace);

            Console.WriteLine(neededSpace);
        }
    }
}
