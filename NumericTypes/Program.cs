//Write a program to calculate the area of a rectangle and print the answer to the console.
//You should prompt the user for the dimensions. (What data types should the dimensions be?)
using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            string input;

            Console.WriteLine("Please enter a length for the rectangle:");
            input = Console.ReadLine();
            length = double.Parse(input);

            Console.WriteLine("Please enter a width for the rectangle:");
            input = Console.ReadLine();
            width = double.Parse(input);

            area = length * width;
            Console.WriteLine("The rectangle's area is " + area.ToString());
            Console.ReadLine();
        }
    }
}
