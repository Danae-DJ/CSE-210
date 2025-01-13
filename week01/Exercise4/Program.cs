using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int createNumber = -1;


        while (createNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
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

        float average = ((float)sum) / numbers.Count;
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

    }
}