using System;

namespace PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double years = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            if (years >= 16 && gender == 'm')
            {
                Console.WriteLine("Mr.");
            }
            else if (years < 16 && gender == 'm')
            {
                Console.WriteLine("Master");
            }
            else if (years >= 16 && gender == 'f')
            {
                Console.WriteLine("Ms.");
            }
            else if (years < 16 && gender == 'f')
            {
                Console.WriteLine("Miss");
            }
        }
    }
}
