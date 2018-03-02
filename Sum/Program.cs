//Lists: Write a static method to find the sum of all the even numbers in a list. Within Main, create a
//  list with at least 10 integers and call your method on the list.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ourNums = new List<int>() { 1,2,3,4,5,6,7,8,9,10 };
            int total = SumOfEven(ourNums);
            //Console.WriteLine(SumOfEven(ourNums).ToString());
            string stringTotal = total.ToString();
            Console.WriteLine(stringTotal);
            Console.Read();
        }

        static int SumOfEven(List<int> nums)
        {
            int total = 0;
            foreach(int n in nums)
            {
                if (n % 2 == 0)
                {
                    total += n;
                }
            }

            return total;
        }
    }
}
