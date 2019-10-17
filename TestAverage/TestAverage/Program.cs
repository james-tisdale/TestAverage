using System;
using System.Collections.Generic;

namespace TestAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tests do you need to average?");
            var totalAmountOfTests = int.Parse(Console.ReadLine());
            Console.Clear();

            List<int> avgList = new List<int>();

            for(int i = 0; i < totalAmountOfTests; i++)
            {
                Console.WriteLine($"Enter test score {i + 1}:");
                avgList.Add(int.Parse(Console.ReadLine()));
                Console.Clear();
            }

            int sum = 0;
            foreach(int num in avgList)
            {
                sum += num;
            }

            int average = sum / totalAmountOfTests;
            Console.WriteLine($"You entered {totalAmountOfTests} tests." +
                $" The average score of all of those tests is : {average}.");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Would you like to average more tests? Y/N?");
            Console.ReadLine();
           
        }
    }
}
