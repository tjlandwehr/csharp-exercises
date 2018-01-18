//Write a program that asks a user for the number of miles they have driven and the
//amount of gas they've consumed (in gallons), and print their miles-per-gallon.

using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gas;
            double mpg;
            string input;

            Console.WriteLine("How many miles have you driven on your trip?");
            input = Console.ReadLine();
            miles = double.Parse(input);

            Console.WriteLine("How much gas did you consume on your trip (in gallons)?");
            input = Console.ReadLine();
            gas = double.Parse(input);

            mpg = miles / gas;
            Console.WriteLine("Your car's mileage was " + mpg.ToString() + " miles-per-gallon on this trip.");
            Console.ReadLine();
        }
    }
}
