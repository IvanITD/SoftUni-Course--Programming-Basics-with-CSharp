using System;
using System.ComponentModel.Design;

namespace UsdToBgn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Usd = double.Parse(Console.ReadLine());

            double Bgn = Usd * 1.79549;

            Console.WriteLine(Bgn);
        }
    }
}
