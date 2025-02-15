using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Phrases phrases = new Phrases();

        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        //Greeting with a quote: Extra
        Console.WriteLine($"The Motivation is: {phrases.GetRamdomQuote()}");
        GoalManager goalManager = new GoalManager();

        while(true)
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record an Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Delete Goal");//Extra (its a Joke)
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option (1-6): ");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;

                case "2":
                    goalManager.ListGoals();
                    break;

                case "3":
                    goalManager.RecordEvent();
                    break;

                case "4":
                    goalManager.SaveGoals("goals.txt");//don't forget using a file
                    break;

                case "5":
                    goalManager.LoadGoals("goals.txt");
                    break;

                case "6"://Extra: Joke
                    Console.WriteLine("Don't think I'll let you eliminate your goals!");
                    Console.WriteLine("A goal achieved is a trophy for life that no one will take away from you.");
                    Console.WriteLine("Return to the menu and meet the goal of the day!");
                    break;

                case "7": //farewell with a metaphor: Extra
                    Console.WriteLine($"Remember that: {phrases.GetRamdomMetaphor()}");
                    Console.WriteLine("Goodbye Champion!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Try with other option.");
                    break;
            }

        }
    
    }
}