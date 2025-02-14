
//GoalManager.cs
using System;
using System.Collections.Generic;
public class GoalManager
{//list
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;


    public void CreateGoal() //1
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







    public void ListGoals() //2
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }

        Console.WriteLine("Your Goals: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }






    
    public void RecordEvent() //3
    {
        ListGoals();
        Console.Write("Enter the number of the goal you complete: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            _goals[choice].RecordEvent();
            _score += 10; //this number could be change if I want it.
        }

        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }







    public void SaveGoals(string filetext) //4
    {
        using (StreamWriter writer = new StreamWriter(filetext))
        {
            writer.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }







    public void LoadGoals(string filetext) //5
    {
        if (File.Exists(filetext))
        {
            _goals.Clear();
            using (StreamReader reader = new StreamReader(filetext))
            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0].Trim();
                    string name = parts[1].Trim();
                    string description = parts[2].Trim();
                    int points = int.Parse(parts[3].Trim());

                    Goal goal = null;
                    if (type == "SimpleGoal")
                    {
                        bool isComplete = bool.Parse(parts[4].Trim());
                        goal = new SimpleGoal(name, description, points);
                        if (isComplete) goal.RecordEvent();
                    }

                    else if (type == "EternalGoal")
                    {
                        goal = new EternalGoal(name, description, points);
                    }

                    else if (type == "ChecklistGoal")
                    {
                        int target = int.Parse(parts[4].Trim());
                        int bonus = int.Parse(parts[5].Trim());
                        goal = new ChecklistGoal(name, description, points,target, bonus);
                    }

                    if (goal != null)
                        _goals.Add(goal);
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }

        else
        {
            Console.WriteLine("No saved goals found.");
        }

    }   

}      
        


        //1option menu type og goal
        /*public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }
    */
            //opt 1 create a new goal
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
//writer save:  https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-9.0
//reader list: https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=net-9.0
//https://www.geeksforgeeks.org/c-sharp-trim-method/