﻿using System;

namespace Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peturBudget = double.Parse(Console.ReadLine());
            int gpuAmount = int.Parse(Console.ReadLine());
            int cpuAmount = int.Parse(Console.ReadLine());
            int ramAmount = int.Parse(Console.ReadLine());

            double gpuPrice = gpuAmount * 250;
            double cpuPrice = (gpuPrice * cpuAmount) * 0.35;
            double ramPrice = (gpuPrice * ramAmount) * 0.10;

            double totalPrice = gpuPrice + cpuPrice + ramPrice;

            
            if (gpuAmount > cpuAmount)
            {
                totalPrice -= totalPrice * 0.15;
            }

            double remainingBudget = peturBudget - totalPrice;
            double neededBudget = totalPrice - peturBudget;

            if (totalPrice <= peturBudget)
            {
                Console.WriteLine($"You have {remainingBudget:F2} leva left!");
            }
            else if (totalPrice > peturBudget)
            {
                Console.WriteLine($"Not enough money! You need {neededBudget:F2} leva more!");
            }
            

           
        }
    }
}
