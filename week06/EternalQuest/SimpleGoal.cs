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
        Console.WriteLine($"Great! You earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return _isComplete; //here
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}| {_description}| {_points}| {_isComplete}";
    }

}

//bool : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/true-false-operators