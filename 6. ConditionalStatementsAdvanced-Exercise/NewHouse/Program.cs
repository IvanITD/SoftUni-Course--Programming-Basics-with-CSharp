using System;

namespace NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowersType = Console.ReadLine();
            int flowersAmount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double totalPrice = 0.0;

            double rosesPrice = 5.0;
            double dahliasPrice = 3.80;
            double tulipsPrice = 2.80;
            double narcissusPrice = 3.0;
            double gladiolusPrice = 2.50;

            double discount;
            
            if (flowersType == "Roses")
            {
                if (flowersAmount >= 80)
                {
                    totalPrice = flowersAmount * rosesPrice;
                    discount = totalPrice * 0.10;
                    totalPrice -= discount;
                }
                else
                {
                    totalPrice = flowersAmount * rosesPrice;
                }
            }
            else if (flowersType == "Dahlias")
            {
                if (flowersAmount >= 90)
                {
                    totalPrice = flowersAmount * dahliasPrice;
                    discount = totalPrice * 0.15;
                    totalPrice -= discount;
                }
                else
                {
                    totalPrice = flowersAmount * dahliasPrice;
                }
            }
            else if (flowersType == "Tulips")
            {
                if (flowersAmount >= 80)
                {
                    totalPrice = flowersAmount * tulipsPrice;
                    discount = totalPrice * 0.15;
                    totalPrice -= discount;
                }
                else
                {
                    totalPrice = flowersAmount * tulipsPrice;
                }
            }
            else if (flowersType == "Narcissus")
            {
                if (flowersAmount < 120)
                {
                    totalPrice = flowersAmount * narcissusPrice;
                    discount = totalPrice * 0.15;
                    totalPrice += discount;
                }
                else
                {
                    totalPrice = flowersAmount * narcissusPrice;
                }
            }
            else if (flowersType == "Gladiolus")
            {
                if (flowersAmount < 80)
                {
                    totalPrice = flowersAmount * gladiolusPrice;
                    discount = totalPrice * 0.20;
                    totalPrice += discount;
                }
                else
                {
                    totalPrice = flowersAmount * gladiolusPrice;
                }
            }

            double remainingMoney = budget - totalPrice;
            double neededMoney = totalPrice - budget;

            if (totalPrice >= budget)
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(neededMoney):F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersAmount} {flowersType} and {remainingMoney:F2} leva left.");
            }
        }
    }
}
