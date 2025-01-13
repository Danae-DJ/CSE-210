using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.WriteLine("What is the magic number? ");
        string response = Console.ReadLine();
        int magicNumber = int.Parse(response);

        int guess = -1;

        while (guess != magicNumber)
            {
                Console.WriteLine("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                Console.WriteLine("You guesed it!");
                }
            }
    }
}