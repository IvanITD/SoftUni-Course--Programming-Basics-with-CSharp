using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();


            string destination = "";
            string vacationType = "";
            double price = 0.00;

            //The destination depends by the amount of the budget.
            if (budget <= 100)
            {
                destination = "Bulgaria";
            }
            else if (budget <= 1_000)
            {
                destination = "Balkans";
            }
            else if (budget > 1_000)
            {
                destination = "Europe";
            }

            //The  type of vacation depends by the destiantion.
            if (destination == "Bulgaria")
            {
                if (season == "summer")
                {
                    vacationType = "Camp";
                    price = budget - budget * 0.30;
                }
                else if (season == "winter")
                {
                    vacationType = "Hotel";
                    price = budget - budget * 0.70;
                }
            }
            else if (destination == "Balkans")
            {
                if (season == "summer")
                {
                    vacationType = "Camp";
                    price = budget - budget * 0.40;
                }
                else if (season == "winter")
                {
                    vacationType = "Hotel";
                    price = budget - budget * 0.80;
                }
            }
            else if (destination == "Europe")
            {
                if (season == "summer" || season == "winter")
                {
                    vacationType = "Hotel";
                    price = budget - budget * 0.90;
                }
            }

            double spentAmount = budget - price;

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacationType} - {spentAmount:F2}");
        }
    }
}
