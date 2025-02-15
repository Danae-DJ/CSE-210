
//CheklistGoal.cs
using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string name, string description, int points, int target, int bonus)
        :base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    //
    public override void RecordEvent()
    {
        if (_amountCompleted < _target) 
        {
            _amountCompleted++;
            int totalPoints = Points;
            
            if (IsComplete())
            {
                totalPoints += _bonus;
                Console.WriteLine($"Congratulations! You completed your goal and earned {_bonus} extra points!");
            }

            Console.WriteLine($"Look at this! You earned {totalPoints} points! (Completed {_amountCompleted}/{_target})");
        }
        else
        {
            Console.WriteLine("Good Job! This goal is already complete.");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {ShortName} ({_amountCompleted}/{_target})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{ShortName}|{Description}|{Points}|{_target}|{_bonus}|{_amountCompleted}";
    }

    //HERE FINALLY WORKING
    public void SetAmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }//DON'T TOUCH...EXTREMALLY NECESSARY!!!

}


/*
//Why dont working??? => here investigate
    public override void RecordEvent()
    {
        _amountCompleted++;
        int totalPoints = _points;

        if (_amountCompleted >= _target)
        {
            totalPoints += _bonus;
            Console.WriteLine($"Congratulations! You complete your goal. Now you earned {_bonus} extra points!");
        }

        Console.WriteLine($"Look at this! You earned {totalPoints} points!");
    }


    // => : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-operator
    */