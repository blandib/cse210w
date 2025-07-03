using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine();
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine(" Enter numbers one at a time (enter 0 to finish):");

        do
        {
            Console.Write("Enter a number: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input != 0)
                numbers.Add(input);

        } while (input != 0);

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            double average = numbers.Average();
            int max = numbers.Max();

            Console.WriteLine("\n Results:");
            Console.WriteLine("➡ Total (Sum): " + sum);
            Console.WriteLine("➡ Average: " + average);
            Console.WriteLine("➡ Maximum: " + max);
        }
        else
        {
            Console.WriteLine("⚠ No numbers entered.");
        }
    }
}