using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("Welcome to the Guess My Number Game!");
        /*Console.WriteLine("What is the magic number? ");
        string response = Console.ReadLine();
        int magicNumber = int.Parse(response);

        int guess = -1;*/
        string playAgain =""; //extra
        do
        {
        //ramdon

            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); 
            int guess = -1;
            int attempts = 0; //extra

            Console.WriteLine("I have picked a magic number between 1 and 100. Try to guess it!");

            while (guess != magicNumber)
            {
                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                attempts++;

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
                        Console.WriteLine($"You guessed it! The magic number was {magicNumber}.");
                        Console.WriteLine($"It took you {attempts} attempts.");
                }

            }
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();
        
        
        }while (playAgain == "yes");
        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}

//solution: https://github.com/byui-cse/cse210-ww-student-sample-solutions/blob/main/week01/Exercise3/Program.cs