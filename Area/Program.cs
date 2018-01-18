using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            double radius;
            double area;

            Console.WriteLine("Enter a radius: ");
            input = Console.ReadLine();
            radius = double.Parse(input);

            area = Math.PI * radius * radius;
            Console.WriteLine("The area of a circle with radius {0} is: {1}", radius, area);
            Console.ReadLine();
        }
    }
}
