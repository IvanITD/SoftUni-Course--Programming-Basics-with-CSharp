using System;

namespace NewHouse_If_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersAmount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double totalPrice = 0.00;

            double rosesPrice = 5.00;
            double dahliasPrice = 3.80;
            double tulipsPrice = 2.80;
            double narcissusPrice = 3.00;
            double gladiolusPrice = 2.50;

            if (flowersType == "Roses")
            {
                totalPrice = flowersAmount * rosesPrice;
                if (flowersAmount > 80)
                {
                    totalPrice -= totalPrice * 0.10;
                }
            }
            else if (flowersType == "Dahlias")
            {
                totalPrice = flowersAmount * dahliasPrice;
                if (flowersAmount > 90)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (flowersType == "Tulips")
            {
                totalPrice = flowersAmount * tulipsPrice;
                if (flowersAmount > 80)
                {   
                    totalPrice -= totalPrice * 0.15;
                }
            }
            else if (flowersType == "Narcissus")
            {
                totalPrice = flowersAmount * narcissusPrice;
                if (flowersAmount < 120)
                {
                    totalPrice += totalPrice * 0.15;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                totalPrice = flowersAmount * gladiolusPrice;
                if (flowersAmount < 80)
                {

                    totalPrice += totalPrice * 0.20;
                }
            }

            double neededMoney = totalPrice - budget;
            double remainingMoney = budget - totalPrice;

            if (totalPrice > budget)
            {
                Console.WriteLine($"Not enough money, you need {neededMoney:F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersAmount} {flowersType} and {remainingMoney:F2} leva left.");
            }

        }
    }
}
