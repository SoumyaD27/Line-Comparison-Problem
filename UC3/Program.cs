﻿
using System;
namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, a1, a2, b1, b2;
            Console.WriteLine("Enter the first LINE point values: ");
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second LINE point values: ");
            a1 = double.Parse(Console.ReadLine());
            a2 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());

            double firstLength = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            double secondLength = Math.Sqrt((Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2)));

            if (firstLengt == secondLength)
            {
                Console.WriteLine("Two Lines are equal.");
            }
            else if (firstLength > secondLength)
            {
                Console.WriteLine("firstLenth is greater");
            }
            else
            {
                Console.WriteLine("secondLenth is greater");
            }
        }
    }
}