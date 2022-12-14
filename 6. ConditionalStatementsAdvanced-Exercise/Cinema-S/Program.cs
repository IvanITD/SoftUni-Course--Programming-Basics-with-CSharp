using System;

namespace Cinema_S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int linesAmmount = int.Parse(Console.ReadLine());
            int columnsAmmount = int.Parse(Console.ReadLine());

            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;

            double result;
            double seats = linesAmmount * columnsAmmount;

            switch (projectionType)
            {
                case "Premiere":
                    result = seats * premiere;
                    Console.WriteLine($"{result:F2} leva");
                    break;

                case "Normal":
                    result = seats * normal;
                    Console.WriteLine($"{result:F2} leva");
                    break;

                case "Discount":
                    result = seats * discount;
                    Console.WriteLine($"{result:F2} leva");
                    break;
            }
        }
    }
}
