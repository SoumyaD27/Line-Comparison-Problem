using System;
namespace UC1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;
            Console.WriteLine("Enter the first point values: ");
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second point values: ");
            y1 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            double length = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.WriteLine("The length ofa line between the two point is: {0}", length);
        }
    }
}

