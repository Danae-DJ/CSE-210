//GoalManager.cs
using System;

public class GoalManager() : Goal
{
    _goals = new Lazy<Goal>();
    _score = 0;


    public void CreateGoal()
    {//menu
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2.Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Exit");
        Console.WriteLine("*************************************************");
        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter description: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal;

        if (choice == 1)
        {
            newGoal = new SimpleGoal(name, description, points);
        }

        else if (choice == 2)
        {
            newGoal = new EternalGoal(name, description, points);
        }

        else if (choice == 3)
        {
            Console.Write("Enter target count: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());
            newGoal = new ChecklistGoal(name, description, points, target, bonus);

        }

        else {
            //exit
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal added successfully!");
    }


}