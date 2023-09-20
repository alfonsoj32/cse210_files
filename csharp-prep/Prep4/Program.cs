using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> numbers = new List<double>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            double input;
            
            if (double.TryParse(Console.ReadLine(), out input))
            {
                if (input == 0)
                    break;

                numbers.Add(input);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
        }
        else
        {
            double total = 0;
            foreach (double num in numbers)
            {
                total += num;
            }

            double average = total / numbers.Count;
            double maxNumber = numbers[0];

            foreach (double num in numbers)
            {
                if (num > maxNumber)
                {
                    maxNumber = num;
                }
            }

            Console.WriteLine($"The sum is: {total}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {maxNumber}");
        }
    }
}