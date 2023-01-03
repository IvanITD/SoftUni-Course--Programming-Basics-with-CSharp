﻿using System;

namespace OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            char simbol = char.Parse(Console.ReadLine());

            double result = 0.00;

            // The type of operator depends by the User's given simbol.
            if (simbol == '+')
            {
                result = N1 + N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} + {N2} = {result} - odd");
                }
            }
            else if (simbol == '-')
            {
                result = N1 - N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} - {N2} = {result} - odd");
                }
            }
            else if (simbol == '*')
            {
                result = N1 * N2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{N1} * {N2} = {result} - odd");
                }
            }
            else if (simbol == '/')
            {
                result = N1 / N2;
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} / {N2} = {result:F2}");
                }
            }
            else if (simbol == '%')
            {
                result = N1 % N2;
                if (N2 == 0)
                {
                    Console.WriteLine($"Cannot divide {N1} by zero");
                }
                else
                {
                    Console.WriteLine($"{N1} % {N2} = {result}");
                }
            }
        }
    }
}
