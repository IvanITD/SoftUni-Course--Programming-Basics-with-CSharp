﻿using System;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int lineAmmount = int.Parse(Console.ReadLine());
            int columnsAmmount = int.Parse(Console.ReadLine());

            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;

            double seats = lineAmmount * columnsAmmount;
            double result;
            if (projectionType == "Premiere")
            {
                result = seats * premiere;
                Console.WriteLine($"{result:F2} leva");
            }
            else if (projectionType == "Normal")
            {
                result = seats * normal;
                Console.WriteLine($"{result:F2} leva");
            }
            else if (projectionType == "Discount")
            {
                result = seats * discount;
                Console.WriteLine($"{result:F2} leva");
            }
        }
    }
}
