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
        throw new NotImplementedException();
    }

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        throw new NotImplementedException();
    }

}

//bool : https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/true-false-operators