using System;

namespace ExcellentResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double evaluation = double.Parse(Console.ReadLine());

            double honor = 5.50;

            if (evaluation >= honor)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
