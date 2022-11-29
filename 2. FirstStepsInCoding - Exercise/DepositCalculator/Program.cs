using System;

namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double yearDivident = double.Parse(Console.ReadLine());


            double sum = depositSum + (depositTerm * 0.010) * ((depositSum * yearDivident) / 12);
            Console.WriteLine(sum);
        }
    }
}
