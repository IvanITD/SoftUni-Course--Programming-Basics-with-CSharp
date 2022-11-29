using System;
using System.Xml.Schema;

namespace Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int neededAmountNylon = int.Parse(Console.ReadLine());
             int neededAmountPaint = int.Parse(Console.ReadLine());
             int thinnerAmount = int.Parse(Console.ReadLine());
             int Hours = int.Parse(Console.ReadLine());

            double protectiveNylon = 1.50;
            double paint = 14.50;
            double thinnerForPaint = 5.00;

            double moreAddedNylon = 2;
            double moreAddedPaint = neededAmountPaint * 0.1;

            double nylonPrice = (neededAmountNylon + moreAddedNylon) * protectiveNylon;
            double paintPrice = (neededAmountPaint + moreAddedPaint) * paint;
            double thinnerPrice = thinnerAmount * thinnerForPaint;
            double bagPrice = 0.40;

            double totalMaterialPrice = nylonPrice + paintPrice + thinnerPrice + bagPrice;
            double craftsmansPayment = (totalMaterialPrice * 0.3) * Hours;
            double totalPrice = totalMaterialPrice + craftsmansPayment;
            Console.WriteLine(totalPrice);

        }
    }
}
