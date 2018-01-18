//The first sentence of Alice's Adventures in Wonderland is below. Store this sentence in a
//string, and then prompt the user for a string to search for within this string. Print whether or not the
//search term was found. See if you can make the search case-insensitive, so that searching for "alice"
//prints true.

using System;

namespace SearchString
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of " +
                "having nothing to do: once or twice she had peeped into the book her sister was reading, but " +
                "it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice " +
                "'without pictures or conversation?'";
            string input;
            int index;
            bool found = true;

            Console.WriteLine("Please enter a string to search for within a sentence from 'Alice's Adventures in Wonderland'");
            input = Console.ReadLine().ToLower();

            index = sentence.ToLower().IndexOf(input);
            if (index < 0) {
                found = false;
            }
            Console.WriteLine("The string appears in the sentence: " + found);
            Console.WriteLine("The string appears at index " + index.ToString());
            Console.ReadLine();

        }
    }
}
