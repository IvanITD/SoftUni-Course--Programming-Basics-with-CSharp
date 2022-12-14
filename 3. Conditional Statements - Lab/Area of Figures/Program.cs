using System;

namespace Area_of_Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();

            if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double result = side * side;
                Console.WriteLine($"{result:F3}");
            }
            else if (figureType == "rectangle")
            {
                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());

                double result = length * width;
                Console.WriteLine($"{result:F3}");
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());

                double result = radius * radius * Math.PI;
                Console.WriteLine($"{result:F3}");
            }
            else if (figureType == "triangle")
            {
                double bottom = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                double result = (bottom * height) / 2;
                Console.WriteLine($"{result:F3}");
            }
        }
    }
}
