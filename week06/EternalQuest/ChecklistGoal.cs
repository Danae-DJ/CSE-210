
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

    public override void RecordEvent()
    {
        _amountCompleted++;
        int totalPoints = _points;

        if (_amountCompleted++ >= _target)
        {
            totalPoints += _bonus;
            Console.WriteLine($"Congratulations! You complete your goal. Now you earned {_bonus} extra points!");
        }

        Console.WriteLine($"Look at this! You earned {totalPoints} points!");
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_amountCompleted}/{_target})";

    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_target}|{_bonus}|{_amountCompleted}";
    }
}