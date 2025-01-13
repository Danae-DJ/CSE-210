using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
    
        //1
        DisplayWelcomeMessage();

        //2
        string userName = PromptUserName();

        //3
        int userNumber = PromptUserNumber();

        //4
        int squaredNumber = squareNumber(userNumber);

        //5
        DisplayResult(userName, squaredNumber);
    
    }


    //1
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    //2
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    //3
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    //4
    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    //5
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"Hello {name}, the square of your number is {square}");
    }
}

//solution: https://github.com/byui-cse/cse210-ww-student-sample-solutions/blob/main/week01/Exercise5/Program.cs