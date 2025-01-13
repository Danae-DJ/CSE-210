using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int createNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (createNumber != 0)
        {
            Console.Write("Enter number: ");
            string userResponse = Console.ReadLine();
            createNumber = int.Parse(userResponse);

            if (createNumber !=0)
            {
                numbers.Add(createNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is : {sum}");

        //float average = ((float)sum) / numbers.Count;
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
    
        Console.WriteLine($"The max is: {max}");


        // extra
        // smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        if (smallestPositive == int.MaxValue)
        {
            Console.WriteLine("There is no positive number in the list.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }


        //sorted list
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}

// solution: https://github.com/byui-cse/cse210-ww-student-sample-solutions/blob/main/week01/Exercise4/Program.cs 