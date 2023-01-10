using System;
using System.Text;

namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOfNights = int.Parse(Console.ReadLine());

            double studio = 0.00;
            double apartment = 0.00;

            if (month == "May" || month == "October")
            {
                studio = 50.00;
                apartment = 65.00;

                if (numberOfNights > 14)
                {
                    studio -= studio * 0.30;
                    apartment -= apartment * 0.10;
                }
                else if (numberOfNights > 7)
                {
                    studio -= studio * 0.05;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartment = 68.70;

                if (numberOfNights > 14)
                {
                    studio -= studio * 0.20;
                    apartment -= apartment * 0.10;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76.00;
                apartment = 77.00;

                if (numberOfNights > 14)
                {
                    apartment -= apartment * 0.10;
                }
            }

            double studioPrice = studio * numberOfNights;
            double apartmentPrice = apartment * numberOfNights;

            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice:F2} lv.");
        }
    }
}
