using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modify your HelloWorld program to prompt the user for their name, and greet them by name.
            string input;

            Console.WriteLine("Please enter your name:");
            input = Console.ReadLine();

            Console.WriteLine("Hello, " + input + "!");
            Console.ReadLine();
        }
    }
}
