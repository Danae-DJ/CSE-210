
//GoalManager.cs
using System;
using System.Collections.Generic;
public class GoalManager
{//list
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    public void CreateGoal()
    {//menu
        Console.WriteLine("What type of goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Exit");
        Console.WriteLine("*************************************************");
        int choice = int.Parse(Console.ReadLine());

        //opt 2
        if (choice == 4) return;

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter description: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        //options
        switch (choice)
        {
            case 1:
                newGoal = new SimpleGoal(name, description, points);
                break;

            case 2:
                newGoal = new EternalGoal(name, description, points);
                break;

            case 3:
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;

        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal added successfully!");
        }    

    }
}    

            //opt 1
            /*case 4:
                return;

            default:
                Console.WriteLine("Invalid choice. Please, returning to menu and rectify your choice");
                break;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal added successfully!");
    }

    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been added yet");
            return;
        }

        for (int i = 0; i <_goals.Count; i++)
        {
            Console.WriteLine($"{_goals[i].GetDetailsString()}");
        }
    }

}

//What its better? */