﻿using System;

namespace Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myHours = int.Parse(Console.ReadLine());
            int myMinutes = int.Parse(Console.ReadLine());

            myMinutes += 15;

            if (myMinutes >= 60)
            {
                myHours += 1;
                myMinutes %= 60;
            }

            if (myHours >= 24)
            {
                myHours = 0;
            }

            if (myMinutes < 10)
            {
                Console.WriteLine($"{myHours}:0{myMinutes}");
            }
            else
            {
                Console.WriteLine($"{myHours}:{myMinutes}");
            }
        }
    }
}
