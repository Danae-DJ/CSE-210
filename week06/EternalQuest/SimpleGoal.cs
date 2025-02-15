//SimpleGoal.cs(child)
using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points) //return
    {
        _isComplete = false; //
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Great! You earned {Points} points!");
    }

    public override bool IsComplete() => _isComplete; //here
    
    
    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {ShortName} - {Description}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{ShortName}|{Description}|{Points}|{_isComplete}";
    }

}

//bool : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/true-false-operators