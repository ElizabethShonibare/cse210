using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.Write("Enter a list of numbers, type 0 when finished: ");
        int num = int.Parse(Console.ReadLine());

        while (num != 0)
        {
            numbers.Add(num);

            Console.Write("Enter a list of numbers, type 0 when finished: ");
            num = int.Parse(Console.ReadLine());
        }


        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"\nThe sum is: {sum}");


        if (numbers.Count > 0)
        {
            double average = (double)sum / numbers.Count;
            Console.WriteLine($"The average: {average}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }


        if (numbers.Count > 0)
        {
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine($"The largest number: {max}");
        }


        int smallestPositive = int.MaxValue;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers were entered.");
        }

        
        numbers.Sort();

        Console.WriteLine("\nSorted numbers:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}